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
                lamd = Convert.ToDouble(lambdaBox.Text);
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
                lamd = Convert.ToDouble(lambdaBox.Text);
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

        private bool calcL() //Расчет лямбы по среднему времени безотказной работы
        {
            double m;
            try
            {
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
                lamd = Convert.ToDouble(lambdaBox.Text);
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
                lamd = Convert.ToDouble(lambdaBox.Text);
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета q(t)", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = Math.Exp(-lamd * t);
            q1Label.Text = "-" + lamd.ToString("N3") + "*" + t.ToString("N3");
            qResult.Text = res.ToString("N5");
            return true;
        }
        private bool calcNormPt() //Расчет P(t). Вероятности безотказной работы системы за t секунд
        {
            double[] lamd = new double[3];
            double[] lT = new double[3];
            double t = 0;
            try
            {
                lamd[0] = Convert.ToDouble(l1Box.Text);
                lamd[1] = Convert.ToDouble(l2Box.Text);
                lamd[2] = Convert.ToDouble(l3Box.Text);
                lT[0] = Convert.ToDouble(l1tBox.Text);
                lT[1] = Convert.ToDouble(l2tBox.Text);
                lT[2] = Convert.ToDouble(l3tBox.Text);
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
            norm1Label.Text = l[0].ToString("N3") + "-" + l[1].ToString("N3") + "-" + l[2].ToString("N3");
            double res = Math.Exp(-l[0]-l[1]-l[2]);
            normResult.Text = res.ToString("N5");
            return true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ptPanel.Visible = false;
            if (ptCheckBox.Checked)
            {
                ptPanel.Visible = calcPt();
            }

            ftPanel.Visible = false;
            if (ftCheckBox.Checked)
            {
                ftPanel.Visible = calcFt();
            }

            lmPanel.Visible = false;
            if(lmCheckBox.Checked)
            {
                lmPanel.Visible = calcL();
            }

            mPanel.Visible = false;
            if(mCheckBox.Checked)
            {
                mPanel.Visible = calcM();
            }

            qPanel.Visible = false;
            if(qCheckBox.Checked)
            {
                qPanel.Visible = calcQ();
            }

            normPtPanel.Visible = false;
            if(normPCheckBox.Checked)
            {
                normPtPanel.Visible = calcNormPt();
            }
        }
    }
}
