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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Examen1 = 0;
            double Examen2 = 0;
            double Examen3 = 0;
            double Promedio = 0;
            Examen1 = Convert.ToDouble(txtExamen1.Text);
            Examen2 = Convert.ToDouble(txtExamen2.Text);
            Examen3 = Convert.ToDouble(txtExamen3.Text);
            Promedio = (Examen1 + Examen2 + Examen3) / 3;
            txtPromedio.Text = Promedio.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExamen1.Clear();
            txtExamen2.Clear();
            txtExamen3.Clear();
            txtPromedio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
