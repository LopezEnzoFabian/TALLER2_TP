using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Formulario1
{
    public partial class Fomulario1 : Form
    {
        public Fomulario1()
        {
            InitializeComponent();
        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void concatenar(object sender, EventArgs e)
        {
            txtapeynom.Text = txtapellido.Text +" " +txtnombre.Text;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            txtapeynom.Text = " ";
        }

        private void Fomulario1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fomulario1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                Application.Exit();
            }
        }
    }
}
