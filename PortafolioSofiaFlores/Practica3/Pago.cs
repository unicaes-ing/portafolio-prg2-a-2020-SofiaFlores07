using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
        }

        private void txtnombre_Validating(object sender, CancelEventArgs e)
        {
            
            if (txtnombre.TextLength < 0)
            {
                errorProvider1.SetError(txtnombre, "Ingrese su nombre");
                

            }
            else
            {
                string patronNombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{2,})(\s)?*[^\s]$";
                if (!Regex.IsMatch(txtnombre.Text, patronNombre))
                {
                    e.Cancel = true;
                    txtnombre.SelectAll();
                    errorProvider1.SetError(txtnombre, "El nombre ingresado no es valido...\ncada nombre debe de iniciar con mayuscula");
                }
            }
        }

        private void txtnombre_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txthoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txthoras_Validating(object sender, CancelEventArgs e)
        {
            if(txthoras.Text=="")
            {
                e.Cancel = true;
                txthoras.Focus();
                errorProvider1.SetError(txthoras, "La cantidad de horas es un campo obligatorio...\n Ingrese la cantidad de horas");
            }
        }

        private void txthoras_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            int horas;
            double precio, subtotal, total = 0, impuesto= 0;
            if( nombre!= string.Empty && int.TryParse(txthoras.Text,out horas) && double.TryParse(txtValor.Text,out precio))
            {
                subtotal = horas * precio;
                impuesto = (subtotal * 0.10);
                total = subtotal - impuesto;
                dataGridView1.Rows.Add(nombre, horas, precio, subtotal, impuesto, total);

            }
            double suma = 0.0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                suma = suma + Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }
            lbltotalplani.Text = suma.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtValor.Clear();
            txthoras.Clear();
        }
    }
}
