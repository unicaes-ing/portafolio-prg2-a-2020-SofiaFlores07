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

namespace Practica2
{
    public partial class Correo : Form
    {
        public Correo()
        {
            InitializeComponent();
        }

        private void txtcorreo_Validating(object sender, CancelEventArgs e)
        {
            string patron = @"^[^@]+@[^@]+\.[a-zA-Z]{2,}";
            if (!Regex.IsMatch(txtcorreo.Text, patron))
            {
                e.Cancel = true;
                txtcorreo.SelectAll();
                err.SetError(txtcorreo, "Ingrese un correo válido ");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtcorreo_Validated(object sender, EventArgs e)
        {
            err.Clear();
        }

        private void txtcontra_Validating(object sender, CancelEventArgs e)
        {
            string patron2 = @"(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$";
            if(txtcontra.TextLength<8)
            {
                e.Cancel = true;
                txtcontra.SelectAll();
                err2.SetError(txtcontra, "La contraseña debe tener al menos 8 caracteres");
            }
            else if(!Regex.IsMatch(txtcontra.Text,patron2))
            {
                e.Cancel = true;
                txtcontra.SelectAll();
                err2.SetError(txtcontra, "La contraseña debe tener al menos 8 caracteres");
            }
        }

        private void txtcontra_Validated(object sender, EventArgs e)
        {
            err2.Clear();
        }

        private void txtconfirmacion_Validating(object sender, CancelEventArgs e)
        {
            string patron3= @"(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$";
            if (txtcontra.TextLength < 8)
            {
                e.Cancel = true;
                txtcontra.SelectAll();
                err2.SetError(txtcontra, "La contraseña debe tener al menos 8 caracteres");
            }
            else if (!Regex.IsMatch(txtcontra.Text, patron3))
            {
                e.Cancel = true;
                txtcontra.SelectAll();
                err2.SetError(txtcontra, "La contraseña debe tener al menos 8 caracteres");
            }
        }

        private void txtconfirmacion_Validated(object sender, EventArgs e)
        {
            err3.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtcorreo.Text=="")
            {
                txtcorreo.Focus();
                MessageBox.Show("Debe crear un correo electronico");
            }
            else if(txtcontra.Text=="")
            {
                txtcontra.Focus();
                MessageBox.Show("Ingrese una contraseña");
            }
            else if(txtconfirmacion.Text=="")
            {
                txtconfirmacion.Focus();
                MessageBox.Show("Ingrese una contraseña para confirmarla");
            }
            else if(txtcontra.Text!=txtconfirmacion.Text)
            {
                txtconfirmacion.Focus();
                txtconfirmacion.SelectAll();
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                MessageBox.Show("Los datos han sido ingresados correctamente");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    }

