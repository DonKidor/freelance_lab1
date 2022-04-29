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
    public partial class RouteForm : Form
    {
        public RouteForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Form1().Show(this);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Form2().Show(this);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new Form3().Show(this);
        }
    }
}
