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

        private void calcPt()
        {
            double lamd = 0, t = 0;
            try
            {
                lamd = Convert.ToDouble(lambdaBox.Text);
                t = Convert.ToDouble(timeBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные значения для расчета P(t)", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double res = Math.Exp(-lamd * t);
            ptLabel.Text = "-" + lamd.ToString("N3") + "*" + t.ToString("N3");
            ptLabelAnswer.Text = res.ToString("N5");
        }

        private void calcFt()
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
                return;
            }
            double res = lamd * Math.Exp(-lamd * t);
            ft1Label.Text = lamd.ToString("N4");
            ft2Label.Text = "-" + lamd.ToString("N3") + "*" + t.ToString("N3");
            ftResult.Text = res.ToString("N5");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ptPanel.Visible = ptCheckBox.Checked;
            if (ptCheckBox.Checked)
            {
                calcPt();
            }

            ftPanel.Visible = ftCheckBox.Checked;
            if(ftCheckBox.Checked)
            {
                calcFt();
            }

        }

        private void FtCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
