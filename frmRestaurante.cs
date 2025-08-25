using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_Restaurante
{
    public partial class frmRestaurante : Form
    {
        public frmRestaurante()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(Interaction.InputBox("Ingrese la cantidad: "));
            dataGridView1.Rows.Add(cantidad, "Hamburguesa", 20, cantidad * 20);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int suma = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                suma += (int)fila.Cells[3].Value;
            }
            txtTotal.Text = suma.ToString();
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {

        }
    }
}
