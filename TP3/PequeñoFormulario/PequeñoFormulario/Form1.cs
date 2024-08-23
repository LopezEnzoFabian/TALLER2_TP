using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PequeñoFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblnomyape_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
        string.IsNullOrWhiteSpace(txtAPE.Text) ||
        string.IsNullOrWhiteSpace(txtNOM.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            string mensaje = "Esta a punto de eliminar al usuario" +" " +txtAPE.Text +" " +txtNOM.Text;
            string titulo = "Confirmar Eliminación";
            DialogResult resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
      
                if (resultado == DialogResult.Yes)
                {
                    string msj = "El Cliente " + txtAPE.Text + " " + txtNOM.Text + " se elimino correctamente";
                    string titulo2 = "Eliminar";
                    MessageBox.Show(msj, titulo2, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtDNI.Clear();
                    txtAPE.Clear();
                    txtNOM.Clear();
                    txtTEL.Clear();
                }
            }
               
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
 
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
        string.IsNullOrWhiteSpace(txtAPE.Text) ||
        string.IsNullOrWhiteSpace(txtNOM.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("¿Desea guardar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Tomar decisiones basadas en la respuesta del usuario
                if (ask == DialogResult.Yes)
                {
                    // Si el usuario hizo clic en "Sí"
                    lblmodif.Text = "¡Los datos han sido guardados!";

                    string nombreCompleto = $"{txtNOM.Text} {txtAPE.Text}";
                    MessageBox.Show($"El Cliente: {nombreCompleto} se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ask == DialogResult.No)
                {
                    // Si el usuario hizo clic en "No"
                    lblmodif.Text = "Operación cancelada.";
                }
            }

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
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

        private void txtNOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evitar que el carácter se introduzca en el TextBox
            }
        }

        private void lblmodificar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbtnHombre_CheckedChanged(object sender, EventArgs e)
        {
            pboxGenero.Image = Properties.Resources.jefe;
        }

        private void rbtnHombre_Click(object sender, EventArgs e)
        {
            
        }

        private void rbtnMujer_CheckedChanged(object sender, EventArgs e)
        {
            pboxGenero.Image = Properties.Resources.mujer;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evitar que el carácter se introduzca en el TextBox
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
   }
