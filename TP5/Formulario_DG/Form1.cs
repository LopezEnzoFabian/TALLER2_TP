using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
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
            // Crear y configurar el OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";

            // Mostrar el diálogo y comprobar si se seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                string rutaImagen = openFileDialog.FileName;
                imgFOTO.Image = Image.FromFile(rutaImagen);
                // Asignar la ruta al TextBox txtfoto
                txtRUTA.Text = rutaImagen;
            }
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

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            string destinationFilePath = null;
            //Obtener la ruta de la carpeta donde se encuentra el ejecutable
            string ejecutablePath = Application.StartupPath;

            if (string.IsNullOrEmpty(txtNOM.Text) || string.IsNullOrEmpty(txtAPE.Text) || string.IsNullOrEmpty(txtSALDO.Text) || string.IsNullOrEmpty(txtRUTA.Text))
            {
                MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                
          
            dgrid.Rows[fila].Cells[0].Value = textInfo.ToTitleCase(txtNOM.Text.ToLower());
            dgrid.Rows[fila].Cells[1].Value = textInfo.ToTitleCase(txtAPE.Text.ToLower());
            dgrid.Rows[fila].Cells[2].Value = dtFECHA.Value;

            if (checkHombre.Checked)          
            dgrid.Rows[fila].Cells[3].Value = checkHombre.Text; 
            else dgrid.Rows[fila].Cells[3].Value = checkMujer.Text;

            dgrid.Rows[fila].Cells[4].Value = "Eliminar";

            if(Decimal.Parse(txtSALDO.Text) < 50)
            dgrid.Rows[fila].DefaultCellStyle.BackColor = Color.Red;
            dgrid.Rows[fila].Cells[5].Value = Decimal.Parse(txtSALDO.Text);

            try
            {
                string fotosPath = Path.Combine(ejecutablePath, "FOTO");
                // Obtener la ruta del archivo seleccionado desde el TextBox
                string sourceFilePath = txtRUTA.Text;
                // Obtener el nombre del archivo seleccionado
                string fileName = Path.GetFileName(sourceFilePath);

                destinationFilePath = Path.Combine(fotosPath, txtAPE.Text + txtNOM.Text + fila + fileName);
                
                File.Copy(sourceFilePath, destinationFilePath, true); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                return;
            }


            Image imagen = Image.FromFile(destinationFilePath);

            dgrid.Rows[fila].Cells[6].Value = imagen;

            dgrid.Rows[fila].Cells[7].Value = destinationFilePath;

            limpiarCampos();

        }

        private void limpiarCampos()
        {
            txtNOM.Clear();
            txtAPE.Clear();
            dtFECHA.Value = DateTime.Now;
            checkHombre.Checked = true;
            txtSALDO.Clear();
            txtRUTA.Clear();
            imgFOTO.Image = Formulario_DG.Properties.Resources.usuario;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgrid.Columns["tDEL"].Index && e.RowIndex >= 0)
            {
                // Eliminar la fila seleccionada
                dgrid.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
