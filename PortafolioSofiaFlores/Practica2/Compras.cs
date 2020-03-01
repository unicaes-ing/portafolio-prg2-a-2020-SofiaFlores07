using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double total, descuento;
            total = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
            if(rdodescu1.Checked)
            {
                descuento = total * 0.0;
                txtDescuento.Text = "$" + Convert.ToString((total * 0.0).ToString("N2"));
                txttotal.Text = "$" + Convert.ToString((total - descuento).ToString("N2"));
            }
            else if(rdodescu2.Checked)
            {
                descuento = total * 0.05;
                txtDescuento.Text = "$" + Convert.ToString((total * 0.05).ToString("N2"));
                txttotal.Text = "$" + Convert.ToString((total - descuento).ToString("N2"));
            }
            else if (rdodescu3.Checked)
            {
                descuento = total * 0.10;
                txtDescuento.Text = "$" + Convert.ToString((total * 0.10).ToString("N2"));
                txttotal.Text = "$" + Convert.ToString((total - descuento).ToString("N2"));
            }
            else if(rdodescu4.Checked)
            {
                descuento = total * 0.15;
                txtDescuento.Text = "$" + Convert.ToString((total * 0.15).ToString("N2"));
                txttotal.Text = "$" + Convert.ToString((total - descuento).ToString("N2"));
            }
            else if(rdodescu5.Checked)
            {
                descuento = total * 0.20;
                txtDescuento.Text = "$" + Convert.ToString((total * 0.15).ToString("N2"));
                txttotal.Text = "$" + Convert.ToString((total-descuento).ToString("N2"));
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            rdodescu1.Checked = false;
            rdodescu2.Checked = false;
            rdodescu3.Checked = false;
            rdodescu4.Checked = false;
            rdodescu5.Checked = false;
            txtCantidad.Text = "";
            txtDescuento.Text = "";
            txtPrecio.Text = "";
            txttotal.Text = "";

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
