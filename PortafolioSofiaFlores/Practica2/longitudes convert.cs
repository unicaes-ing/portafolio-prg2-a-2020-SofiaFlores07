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
    public partial class longitudes_convert : Form
    {
        public longitudes_convert()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double lng, pulgadas = 0, pies = 0, yardas = 0;
                lng = Convert.ToDouble(txtlongitud.Text);
                if (rdoYardas.Checked)
                {
                    if (rdoPies2.Checked)
                    {
                        pies = lng * 3.0;
                    }
                    else if (rdoPulgadas2.Checked)
                    {
                        pulgadas = lng * 36.0;
                    }
                }
                if (rdoPies.Checked)
                {
                    if (rdoYardas2.Checked)
                    {
                        yardas = lng * 0.333333;
                    }
                    else if (rdoPulgadas2.Checked)
                    {
                        pulgadas = lng * 12.0;
                    }
                }
                if (rdoPulgadas.Checked)
                {
                    if (rdoYardas2.Checked)
                    {
                        yardas = lng * 0.0277778;
                    }
                    else if (rdoPies2.Checked)
                    {
                        pies = lng * 0.0833333;
                    }
                }
                txtConversion.Text = (yardas + pies + pulgadas).ToString("N2");
            }
            catch (Exception)
            {

                MessageBox.Show("Debe ingresar una longitud");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

