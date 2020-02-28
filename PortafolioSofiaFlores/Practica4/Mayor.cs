using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class Mayor : Form
    {
        public Mayor()
        {
            InitializeComponent();
        }
        public static int NumeroM(int nu1, int nu2, int nu3)
        {
            int num1, num2, num3;
            num1 = nu1;
            num2 = nu2;
            num3 = nu3;
            if(num1>num2 && num1>num3)
            {
                return num1;
            }
            else if(num2>num1 && num2>num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        private void btnmayor_Click(object sender, EventArgs e)
        {
            int nu1, nu2, nu3, nmayor;
            nu1 = Convert.ToInt32(txtnum1.Text);
            nu2 = Convert.ToInt32(txtnum2.Text);
            nu3 = Convert.ToInt32(txtnum3.Text);
            nmayor = NumeroM(nu1, nu2, nu3);
            lblmayor.Text = string.Format("{0}", nmayor);
        }
    }
}
