using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Letras : Form
    {
        public Letras()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstletras.ForeColor = Color.Red;
            lstletras.Font = new Font("Arial", 20, FontStyle.Bold);
            lstletras.Items.Clear();
            for(char letra = 'A'; letra<= 'Z'; letra++)
            {
                lstletras.Items.Add(letra);
            }
            lstletras.Items.Insert(14, 'Ñ');
        }
    }
}
