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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private double getCP(double l, double t, int m)
        {
            double res = Math.Exp(-l * t);
            double z = calcZC(l, t, m);
            res *= z;
            return res;
        }

        private double getWP(double l, double t, int m, double l1)
        {
            double z = calcZai(l, l1, m, t);
            pctWzLabel.Text = z.ToString("N3");

            double res = Math.Exp(-l * t) * (1 + z);

            return res;
        }

        private double getLamda()
        {
            if (lambdaBox.Text.Length > 0) return Convert.ToDouble(lambdaBox.Text);
            if(lamiBox.Text.Length>0)
            {
                if(calcL0l())
                {
                    lam0lPanel.Visible = true;
                    double l = Convert.ToDouble(lamiBox.Text);
                    int n = Convert.ToInt32(nBox.Text);
                    double res = l*n;
                    return res;
                }
            }
            if(mtiBox.Text.Length>0)
            {
                if(calcL0m())
                {
                    lam0mPanel.Visible = true;
                    double m = Convert.ToDouble(mtiBox.Text);
                    int n = Convert.ToInt32(nBox.Text);
                    double res = n / m;
                    return res;
                }
            }
            if(pBox.Text.Length>0 && timeBox.Text.Length>0)
            {
                double l1 = Convert.ToDouble(lam1Box.Text);
                double p = Convert.ToDouble(pBox.Text);
                double t = Convert.ToDouble(timeBox.Text);
                int m = Convert.ToInt32(mBox.Text);
                if (l1 == 0)
                {
                    double L = 0;
                    double R = 1;
                    int count = 100;
                    while (R - L > 0.000001 && count > 0)
                    {
                        count--;
                        double mid = (L + R) / 2;
                        double pt = getCP(mid, t, m);
                        if (pt > p) L = mid;
                        else R = mid;
                    }
                    lam0PcPanel.Visible = true;
                    lam0PcResult.Text = L.ToString("N5");
                    return L;
                } else
                {
                    double L = 0;
                    double R = 1;
                    int count = 100;
                    while (R - L > 0.000001 && count > 0)
                    {
                        count--;
                        double mid = (L + R) / 2;
                        double pt = getWP(mid, t, m, l1);
                        if (pt > p) L = mid;
                        else R = mid;
                    }
                    lam0PWPanel.Visible = true;
                    lam0PWResult.Text = L.ToString("N5");

                    return L;
                }
            }
            throw new FormatException();
        }
        private bool calcL0m()
        {
            double m;
            int n;
            try
            {
                n = Convert.ToInt32(nBox.Text);
                m = Convert.ToDouble(mtiBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета λ через m", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = n / m;

            l0mnLabel.Text = n.ToString();
            l0mmtiLabel.Text = m.ToString("N3");
            l0mResult.Text = res.ToString("N5");
            return true;
        }

        private bool calcL0l()
        {
            double l;
            int n;
            try
            {
                n = Convert.ToInt32(nBox.Text);
                l = Convert.ToDouble(lamiBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета λ через λi", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = n * l;

            l0l1Label.Text = l.ToString("N3") + "*" + n.ToString();
            l0lResult.Text = res.ToString("N5");
            return true;
        }

        private double calcZai(double l0, double l1, int m, double t)
        {
            double res = 0;
            for(int i=1; i<=m; ++i)
            {
                double a = 1;
                for (int j = 0; j <= i - 1; ++j) a *= j + (l0 / l1);    // a (i)
                for (int j = 2; j <= i; ++j) a /= i;                    // /(i)!
                a *= Math.Pow(1 - Math.Exp(-l1*t), i);                  // (1-e)^i
                res += a;
            }
            return res;
        }

        private double calcZC(double l0, double t, int m)
        {
            double res = 0;
            for(int i=0; i<=m; ++i)
            {
                double a = Math.Pow(l0 * t, i);                         // (l*t)^i
                for (int j = 2; j <= i; ++j) a /= j;                    // /(i)!
                res += a;
            }
            return res;
        }

        private bool calcWQct(double l1)
        {
            double l0, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l0 = getLamda();
                t = Convert.ToDouble(timeBox.Text);
            } catch(FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета Qct в теплом резерве", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double z = calcZai(l0, l1, m, t);
            qctWzLabel.Text = z.ToString("N3");
            qctW1Label.Text = l0.ToString("N3") + "*" + t.ToString("N3");
            qctW2Label.Text = z.ToString("N3");
            double res = 1 - (Math.Exp(-l0 * t) * (1 + z));
            qctWResult.Text = res.ToString("N7");
            return true;
        }

        private bool calcCQct()
        {
            double l0, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l0 = getLamda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета Qct в ненагруженном резерве", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double z = calcZC(l0, t, m);
            qtcCzLabel.Text = z.ToString("N3");
            qtcC1Label.Text = l0.ToString("N3") + "*" + t.ToString("N3");
            qtcC2Label.Text = z.ToString("N3");
            double res = 1 - (Math.Exp(-l0 * t) * z);
            qtcCResult.Text = res.ToString("N7");

            return true;
        }

        private bool calcCPct()
        {
            double l0, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l0 = getLamda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета Pct в ненагруженном резерве", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double z = calcZC(l0, t, m);
            pctCzLabel.Text = z.ToString("N3");

            double res = Math.Exp(-l0 * t) * z;
            pctC1Label.Text = l0.ToString("N3") + "*" + t.ToString("N3");
            pctC2Label.Text = z.ToString("N3");
            pctCResult.Text = res.ToString("N7");
            return true;
        }

        private bool calcWPct(double l1)
        {
            double l0, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l0 = getLamda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета Pct в теплом резерве", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double z = calcZai(l0, l1, m, t);
            pctWzLabel.Text = z.ToString("N3");

            double res = Math.Exp(-l0 * t) * (1 + z);

            pctW1Label.Text = l0.ToString("N4") + "*" + t.ToString("N3");
            pctW2Label.Text = z.ToString("N3");
            pctWResult.Text = res.ToString("N7");
            return true;
        }

        private bool calcWMtc(double l1)
        {
            double l0;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l0 = getLamda();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета Mtc в теплом резерве", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double k = l1 / l0;
            double z = 0;
            for(int i=0; i<=m; ++i)
            {
                z += 1 / (1 + i * k);
            }

            mtcWkLabel.Text = k.ToString("N3");
            mtcW1Label.Text = z.ToString("N3");
            mtcW2Label.Text = l0.ToString("N3");
            mtcWzLabel.Text = z.ToString("N3");
            double res = z / l0;
            mtcWResult.Text = res.ToString("N7");
            return true;
        }
        private bool calcCMtc()
        {
            double l0;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l0 = getLamda();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета Mtc в ненагруженном резерве", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            mtcC1Label.Text = (m + 1).ToString("N3");
            mtcC2Label.Text = l0.ToString("N3");
            double res = (m + 1) / l0;
            mtcCResult.Text = res.ToString("N7");
            return true;
        }

        private bool calcWFct(double l1)
        {
            double l0, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l0 = getLamda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета Fct в теплом резерве", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double z = calcZai(l0, l1, m, t);
            double z2 = 0;
            for(int i=1; i<=m; ++i)
            {
                double a = 1;
                for (int j = 0; j <= i - 1; ++j) a *= j + (l0 / l1);    // a (i)
                for (int j = 2; j <= i-1; ++j) a /= i;                    // /(i-1)!
                a *= Math.Pow(1 - Math.Exp(-l1*t), i - 1);
                z2 += a;
            }
            z2 *= Math.Exp(-l1 * t);
            z2 *= l1 / l0;
            double b = 1 + z - z2;
            fctWzLabel.Text = z.ToString("N3");
            fctW1Label.Text = l0.ToString("N3");
            fctW2Label.Text = l0.ToString("N3") + "*" + t.ToString("N3");
            fctW3Label.Text = b.ToString("N3");
            double res = l0 * Math.Exp(-l0 * t) * b;
            fctWResult.Text = res.ToString("N7");
            return true;
        }

        private bool calcCFct()
        {
            double l0, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l0 = getLamda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета Fct в ненагруженном резерве", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double a = Math.Pow(l0, m + 1);
            double mf = 1;
            for (int i = 2; i <= m; ++i) mf *= i;
            double c = Math.Pow(t, m) * Math.Exp(-l0 * t);
            fctC1Label.Text = a.ToString("N3");
            fctC2Label.Text = mf.ToString("N3");
            fctC3Label.Text = Math.Pow(t, m).ToString("N3");
            fctC4Label.Text = l0.ToString("N3") + "*" + t.ToString("N3");
            double res = (a / mf) * c;
            fctCResult.Text = res.ToString("N7");
            return true;
        }

        private bool calcWLct(double l1)
        {
            double l0, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l0 = getLamda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета λc в теплом резерве", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double z = calcZai(l0, l1, m, t);
            double z2 = 0;
            for (int i = 1; i <= m; ++i)
            {
                double a = 1;
                for (int j = 0; j <= i - 1; ++j) a *= j + (l0 / l1);    // a (i)
                for (int j = 2; j <= i - 1; ++j) a /= i;                    // /(i-1)!
                a *= Math.Pow(1 - Math.Exp(-l1 * t), i - 1);
                z2 += a;
            }

            double res = l0 * (1 - ((l1 * z2 * Math.Exp(-l1 * t) / l0) / (1 + z)));

            lctWzLabel.Text = z.ToString("N3");
            lctW1Label.Text = l0.ToString("N3");
            lctW2Label.Text = l1.ToString("N3");
            lctW3Label.Text = l0.ToString("N3");
            lctW4Label.Text = l1.ToString("N3") + "*" + t.ToString("N3");
            lctW5Label.Text = z2.ToString("N3");
            lctW6Label.Text = (1 + z).ToString("N3");
            lctWResult.Text = res.ToString("N7");

            return true;
        }

        private bool calcCLct()
        {
            double l0, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l0 = getLamda();
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета λc в ненагруженном резерве", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double z = calcZC(l0, t, m);
            double a = Math.Pow(l0, m + 1) * Math.Pow(t, m);
            double b = 1;
            for (int i = 2; i <= m; ++i) b *= i;
            b *= z;
            lctC1Label.Text = a.ToString("N3");
            lctC2Label.Text = b.ToString("N3");
            lctCzLabel.Text = z.ToString("N3");
            double res = a / b;
            lctCResult.Text = res.ToString("N7");
            return true;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            double? l1 = null;
            try
            {
                l1 = Convert.ToDouble(lam1Box.Text);
            } catch(FormatException){ }

            lam0mPanel.Visible = false;
            if (lam0mCheckBox.Checked)
            {
                try
                {
                    getLamda();
                } catch(FormatException) { }
                
            }
            lam0PcPanel.Visible = false;
            lam0PWPanel.Visible = false;
            lam0lPanel.Visible = false;

            qctCPanel.Visible = false;
            qctWPanel.Visible = false;
            if(qctCheckBox.Checked)
            {
                if (l1 == null || l1 == 0) qctCPanel.Visible = calcCQct();
                else qctWPanel.Visible = calcWQct(l1.Value);
            }

            pctCPanel.Visible = false;
            pctWPanel.Visible = false;
            if (pctCheckBox.Checked)
            {
                if (l1 == null || l1 == 0) pctCPanel.Visible = calcCPct();
                else pctWPanel.Visible = calcWPct(l1.Value);
            }

            mtcCPanel.Visible = false;
            mtcWPanel.Visible = false;
            if (mtcCheckBox.Checked)
            {
                if (l1 == null || l1 == 0) mtcCPanel.Visible = calcCMtc();
                else mtcWPanel.Visible = calcWMtc(l1.Value);
            }

            fctCPanel.Visible = false;
            fctWPanel.Visible = false;
            if (fctCheckBox.Checked)
            {
                if (l1 == null || l1 == 0) fctCPanel.Visible = calcCFct();
                else fctWPanel.Visible = calcWFct(l1.Value);
            }

            lctCPanel.Visible = false;
            lctWPanel.Visible = false;
            if (lamtCheckBox.Checked)
            {
                if (l1 == null || l1 == 0) lctCPanel.Visible = calcCLct();
                else lctWPanel.Visible = calcWLct(l1.Value);
            }
        }
    }
}
