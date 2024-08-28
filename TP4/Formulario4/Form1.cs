using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario4
{
    public partial class lblLista : Form
    {
        public lblLista()
        {
            InitializeComponent();
        }

        private void lblDesde_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void btnFuncion_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(txtDesde.Text, out int start) || !int.TryParse(txtHasta.Text, out int end))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (start <= end)
            {
                // Imprimir en orden ascendente
                for (int i = start; i <= end; i++)
                {
                    listBox1.Items.Add(i);
                }
            }
            else
            {
                // Imprimir en orden descendente
                for (int i = start; i >= end; i--)
                {
                    listBox1.Items.Add(i);
                }
            }
         }

        private void btnPares_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(txtDesde.Text, out int start) || !int.TryParse(txtHasta.Text, out int end))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void btnImpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(txtDesde.Text, out int start) || !int.TryParse(txtHasta.Text, out int end))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
       

            if (!int.TryParse(txtDesde.Text, out int start) || !int.TryParse(txtHasta.Text, out int end))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    listBox1.Items.Add(i);        
                }
            }
        }
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
