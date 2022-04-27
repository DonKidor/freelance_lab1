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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        private bool calcPct()
        {
            double l, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l = Convert.ToDouble(lambdaBox.Text);
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета Pc(t)", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = 1 - Math.Pow(1 - Math.Exp(-l*t), m + 1);
            pct1Label.Text = l.ToString("N3") + "*" + t.ToString("N3");
            pctmLabel.Text = (m + 1).ToString();


            pctResult.Text = res.ToString("N5");
            return true;
        }

        private bool calcMtc()
        {
            double l;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l = Convert.ToDouble(lambdaBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета m", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double k = 0;
            for(int i=0; i<=m; ++i)
            {
                k += 1d / (1 + i);
            }

            mtc1Label.Text = k.ToString("N5");
            mtclLabel.Text = l.ToString("N5");

            double res = k / l;
            mtcResult.Text = res.ToString("N5");
            return true;
        }

        private bool calcFct()
        {
            double l, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l = Convert.ToDouble(lambdaBox.Text);
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета f", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = l * (m + 1) * Math.Exp(-l * t) * Math.Pow(1 - Math.Exp(-l * t), m);

            fctl1Label.Text = l.ToString("N3");
            fctmLabel.Text = (m + 1).ToString();
            fctl2Label.Text = l.ToString("N3") + "*" + t.ToString("N3");
            fctl3Label.Text = l.ToString("N3") + "*" + t.ToString("N3");
            fctResult.Text = res.ToString("N5");
            return true;
        }

        private bool calcQct()
        {
            double l, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l = Convert.ToDouble(lambdaBox.Text);
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета f", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double res = Math.Pow(1 - Math.Exp(-l * t), m + 1);

            qct1Label.Text = l.ToString("N3") + "*" + t.ToString("N3");
            qct2Label.Text = (m + 1).ToString();
            qctResult.Text = res.ToString("N5");
            
            return true;
        }

        private bool calcLct()
        {
            double l, t;
            int m;
            try
            {
                m = Convert.ToInt32(mBox.Text);
                l = Convert.ToDouble(lambdaBox.Text);
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета f", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            double f = l * (m + 1) * Math.Exp(-l * t) * Math.Pow(1 - Math.Exp(-l * t), m);
            double p = 1 - Math.Pow(1 - Math.Exp(-l * t), m + 1);
            double res = f / p;

            lcResult.Text = res.ToString("N5");
            lcpLabel.Text = p.ToString("N5");
            lctfLabel.Text = f.ToString("N5");
            return true;
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            lam0mPanel.Visible = false;
            if(lam0mCheckBox.Checked)
            {
                lam0mPanel.Visible = calcL0m();
            }

            lam0lPanel.Visible = false;
            if(lam0lCheckBox.Checked)
            {
                lam0lPanel.Visible = calcL0l();
            }

            pctPanel.Visible = false;
            if(pctCheckBox.Checked)
            {
                pctPanel.Visible = calcPct();
            }

            mtcPanel.Visible = false;
            if(mtcCheckBox.Checked)
            {
                mtcPanel.Visible = calcMtc();
            }

            fctPanel.Visible = false;
            if(fctCheckBox.Checked)
            {
                fctPanel.Visible = calcFct();
            }

            qctPanel.Visible = false;
            if (qctCheckBox.Checked)
            {
                qctPanel.Visible = calcQct();
            }

            lctPanel.Visible = false;
            if (lamtCheckBox.Checked)
            {
                lctPanel.Visible = calcLct();
            }
        }
    }
}
