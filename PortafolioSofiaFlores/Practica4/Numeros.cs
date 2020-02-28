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
    public partial class Numeros : Form
    {
        public Numeros()
        {
            InitializeComponent();
        }
        public static double Sumar(double n1,double n2,double n3, double n4)
        {
            return n1 + n2 + n3 + n4;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtnum1.Text);
                double num2 = Convert.ToDouble(txtnum2.Text);
                double num3 = Convert.ToDouble(txtnum3.Text);
                double num4 = Convert.ToDouble(txtnum4.Text);
                lblsuma.Text = "Suma = " + Sumar(num1, num2, num3, num4).ToString();
                txtnum1.Clear();
                txtnum2.Clear();
                txtnum3.Clear();
                txtnum4.Clear();
            }
            catch
            {
                MessageBox.Show("Ingrese 4 números");
            }
        }
    }
}
