using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Inversiones : Form
    {
        public Inversiones()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double inversion1;
            double inversion2;
            double inversion3;
            double Total;
            inversion1 = Convert.ToDouble(txtInver1.Text);
            inversion2 = Convert.ToDouble(txtInver2.Text);
            inversion3 = Convert.ToDouble(txtInver3.Text);
            Total = inversion1 + inversion2 + inversion3;
            txtTotal.Text = Total.ToString("N2");
            double Porcentaje1;
            double Porcentaje2;
            double Porcentaje3;
            Porcentaje1 = ((inversion1 / Total) * 100);
            Porcentaje2 = ((inversion2 / Total) * 100);
            Porcentaje3 = ((inversion3 / Total) * 100);
            txtPorcen1.Text = Porcentaje1.ToString("N2") + " %";
            txtPorcen2.Text = Porcentaje2.ToString("N2") + " %";
            txtPorcen3.Text = Porcentaje3.ToString("N2") + " %";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInver1.Clear();
            txtInver2.Clear();
            txtInver3.Clear();
            txtPorcen1.Clear();
            txtPorcen2.Clear();
            txtPorcen3.Clear();
            txtTotal.Clear();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
