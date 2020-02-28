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
    public partial class Aleatorio : Form
    {
        public Aleatorio()
        {
            InitializeComponent();
        }

        private void Aleatorio_Load(object sender, EventArgs e)
        {
            dgvNumero.Size= new Size(210, 220);
            dgvNumero.AllowUserToAddRows = false;
            dgvNumero.ScrollBars = ScrollBars.None;
            dgvNumero.ColumnCount = 10;
            dgvNumero.ColumnHeadersVisible = false;
            dgvNumero.RowHeadersVisible = false;
            dgvNumero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            Random r = new Random();
            for (int f=0; f<10; f++)
            {
                dgvNumero.Rows.Add();
                for (int c = 0; c < 10; c++)
                {
                    dgvNumero.Rows[f].Cells[c].Value = r.Next(10, 100);
                    
                }
            }
   

dgvNumero.ClearSelection();
            
        }
    }
}
