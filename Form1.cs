using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool calcPt() //Расчет P(t) по экспоненциальному закону. Вероятности безотказной работы системы за t секунд
        {
            double lamd = 0, t = 0;
            try
            {
                lamd = getLamda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета P(t) по экспоненциальному закону", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = Math.Exp(-lamd * t);
            ptLabel.Text = "-" + lamd.ToString("N3") + "*" + t.ToString("N3");
            ptLabelAnswer.Text = res.ToString("N5");
            return true;
        }

        private bool calcFt() //Расчет f(t) по экспоненциальному закону. Частота отказов системы
        {
            double lamd, t;
            try
            {
                lamd = getLamda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета f(t)", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = lamd * Math.Exp(-lamd * t);
            ft1Label.Text = lamd.ToString("N4");
            ft2Label.Text = "-" + lamd.ToString("N3") + "*" + t.ToString("N3");
            ftResult.Text = res.ToString("N5");
            return true;
        }

        private double getLamda()
        {
            if (lambdaBox.Text.Length > 0) return Convert.ToDouble(lambdaBox.Text);

            if(mtBox.Text.Length>0)
            {
                double mt = Convert.ToDouble(mtBox.Text);
                lmPanel.Visible = calcL();
                return 1 / mt;
            }
            if(mt1Box.Text.Length>0)
            {
                TextBox[] mts = new TextBox[] {mt1Box, mt2Box, mt3Box, mt4Box, mt5Box};
                double res = 0;
                for(int i=0; i<mts.Length; ++i)
                {
                    if (mts[i].Text.Length > 0)
                    {
                        res += 1 / Convert.ToDouble(mts[i].Text);
                    }
                }
                lamMiPanel.Visible = true;
                lamMiResult.Text = res.ToString("N5");
                return res;
            }
            if(lamiBox.Text.Length > 0)
            {
                double lami = Convert.ToDouble(lamiBox.Text);
                int n = Convert.ToInt32(nBox.Text);
                double res = lami * n;
                lamiResult.Text = res.ToString("N5");
                lamiPanel.Visible = true;
                return res;
            }
            if(pcBox.Text.Length>0)
            {
                double t = Convert.ToDouble(timeBox.Text);
                double res = getPc();
                res = -Math.Log(res) / t;
                lamPcPanel.Visible = true;
                lamPcResult.Text = res.ToString("N5");
                return res;
            }
            if(p1Box.Text.Length>0)
            {
                double res = getPc();
                double t = Convert.ToDouble(timeBox.Text);

                res = -Math.Log(res) / t;
                lamPcPanel.Visible = true;
                lamPcResult.Text = res.ToString("N5");
                return res;
            }
            throw new FormatException();
        }


        private double getPc()
        {
            if (pcBox.Text.Length > 0) return Convert.ToDouble(pcBox.Text);
            if (pcBox.Text.Length > 0)
            {
                double t = Convert.ToDouble(timeBox.Text);
                double res = Convert.ToDouble(pcBox.Text);
                res = -Math.Log(res) / t;
                lamPcPanel.Visible = true;
                lamPcResult.Text = res.ToString("N5");
                return res;
            }
            if (p1Box.Text.Length > 0)
            {
                TextBox[] pis = new TextBox[] { p1Box, p2Box, p3Box, p4Box, p5Box };
                double res = 1;
                foreach (TextBox p in pis)
                {
                    if (p.Text.Length > 0) res *= Convert.ToDouble(p.Text);
                }
                pcPiPanel.Visible = true;
                pcPiResult.Text = res.ToString("N5");
                return res;
            }
            if(pBox.Text.Length > 0)
            {
                double res = Convert.ToDouble(pBox.Text);
                int n = Convert.ToInt32(nBox.Text);
                res = Math.Pow(res, n);
                pcPnPanel.Visible = true;
                pcPnResult.Text = res.ToString("N5");
                return res;
            }
            if(calcPt())
            {
                double l = getLamda();
                double t = Convert.ToDouble(timeBox.Text);
                double res = Math.Exp(-l * t);
                return res;
            }
            throw new FormatException();
        }

        private bool calcL() //Расчет лямбы
        {
            double m;
            try
            {
                if (mtBox.Text.Length == 0)
                {
                    getLamda();
                    return false;
                }
                m = Convert.ToDouble(mtBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета λ", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = 1/m;
            lm1Label.Text = m.ToString("N4");
            lmResult.Text = res.ToString("N5");
            return true;
        }

        private bool calcM() //Расчет среднего безотказного времени работы по лямбде
        {
            double lamd;
            try
            {
                lamd = getLamda();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета m", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = 1 / lamd;
            m1Label.Text = lamd.ToString("N4");
            mResult.Text = res.ToString("N5");
            return true;
        }

        private bool calcQ() //Расчет q(t) вероятности отказа системы за t секунд
        {
            double lamd = 0, t = 0;
            try
            {
                lamd = getLamda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета q(t)", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = 1 - Math.Exp(-lamd * t);
            q1Label.Text = "-" + lamd.ToString("N3") + "*" + t.ToString("N3");
            qResult.Text = res.ToString("N5");
            return true;
        }
        private bool calcNormPt() //Расчет P(t). Вероятности безотказной работы системы за t секунд
        {
            if(pBox.Text.Length>0)
            {
                try
                {
                    getPc();
                } catch(FormatException) { }
                return false;
            }
            if(p1Box.Text.Length>0)
            {
                try
                {
                    getLamda();
                } catch(FormatException) { }
                return false;
            }
            if(l1Box.Text.Length==0)
            {
                ptPanel.Visible = calcPt();
                return false;
            }
            double[] lamd = new double[3];
            double[] lT = new double[3];
            double t = 0;
            try
            {
                TextBox[] lbs = new TextBox[] { l1Box, l2Box, l3Box };
                TextBox[] tbs = new TextBox[] { l1tBox, l2tBox, l3tBox };
                for(int i=0; i<3; ++i)
                {
                    if (lbs[i].Text.Length > 0)
                    {
                        lamd[i] = Convert.ToDouble(lbs[i].Text);
                        lT[i] = Convert.ToDouble(tbs[i].Text);
                    }
                    else lamd[i] = 0.0;
                }
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета P(t)", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double[] l = new double[3];
            for(int i=0; i<3; ++i) // сумма интегралов
            {
                l[i] = lamd[i] * Math.Pow(t, lT[i] + 1) / (lT[i] + 1);
            }
            norm1Label.Text = l[0].ToString("N3");
            for(int i=1; i<3; ++i)
            {
                if (lamd[i] > 0)
                    norm1Label.Text += "-" + l[i].ToString("N3");
            }
            double res = Math.Exp(-l[0]-l[1]-l[2]);
            normResult.Text = res.ToString("N5");
            normPtPanel.Visible = true;
            return true;
        }

        private bool calcPit()
        {
            double p = 0;
            int n;
            try
            {
                p = getPc();
                n = Convert.ToInt32(nBox.Text);
            } catch(FormatException)
            {
                return false;
            }
            double res = Math.Pow(p, 1.0/ n);
            pitResult.Text = res.ToString("N5");
            return true;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            ptPanel.Visible = false;
            ftPanel.Visible = false;
            lmPanel.Visible = false;
            mPanel.Visible = false;
            qPanel.Visible = false;
            lamiPanel.Visible = false;
            lamMiPanel.Visible = false;
            normPtPanel.Visible = false;
            lamPcPanel.Visible = false;
            pcPiPanel.Visible = false;
            pcPnPanel.Visible = false;
            pitPanel.Visible = false;

            if (ptCheckBox.Checked)
            {
                pitPanel.Visible = calcPit();
            }

            if (ftCheckBox.Checked)
            {
                ftPanel.Visible = calcFt();
            }

            if(lmCheckBox.Checked)
            {
                lmPanel.Visible = calcL();
            }

            if(mCheckBox.Checked)
            {
                mPanel.Visible = calcM();
            }

            if(qCheckBox.Checked)
            {
                qPanel.Visible = calcQ();
            }

            if(PctCheckBox.Checked)
            {
                calcNormPt();
            }
        }
    }
}
