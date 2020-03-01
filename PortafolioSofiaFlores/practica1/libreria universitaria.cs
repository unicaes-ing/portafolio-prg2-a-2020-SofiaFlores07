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
    public partial class libreria_universitaria : Form
    {
        public libreria_universitaria()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double subtotal, precio;
            double impuesto, total;
            int cantidad;
            precio = Convert.ToDouble(txtPrecio.Text);
            cantidad = Convert.ToInt32(txtCantidad.Text);
            subtotal = (precio * cantidad);
            txtSubtotal.Text = subtotal.ToString("N2");
            impuesto = (subtotal * 0.13);
            txtImpuesto.Text = impuesto.ToString("N2");
            total = impuesto + subtotal;
            txtTotal.Text = total.ToString("N2");
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtImpuesto.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void libreria_universitaria_Load(object sender, EventArgs e)
        {

        }
    }
}
