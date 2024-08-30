using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_DG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {

        }

        private void txtNOM_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtNOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evitar que el carácter se introduzca en el TextBox
            }
        }

        private void txtAPE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evitar que el carácter se introduzca en el TextBox
            }
        }

        private void txtSALDO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSALDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evitar que el carácter se introduzca en el TextBox
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int fila = dgrid.Rows.Add();


            dgrid.Rows[fila].Cells[0].Value = txtNOM.Text;
            dgrid.Rows[fila].Cells[1].Value = txtAPE.Text;
            dgrid.Rows[fila].Cells[2].Value = dtFECHA.Value;
            if (checkHombre.Checked)
            {
                dgrid.Rows[fila].Cells[3].Value = checkHombre.Text;
                checkHombre.Checked = false;
            }
            else {
                if(checkMujer.Checked)
                dgrid.Rows[fila].Cells[3].Value = checkMujer.Text;
                checkMujer.Checked = false;
            }
           


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
