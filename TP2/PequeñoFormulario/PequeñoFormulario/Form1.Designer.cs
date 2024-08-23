namespace PequeñoFormulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnomyape = new System.Windows.Forms.Label();
            this.lblmodif = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtAPE = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNOM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnomyape
            // 
            this.lblnomyape.AutoSize = true;
            this.lblnomyape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomyape.Location = new System.Drawing.Point(31, 33);
            this.lblnomyape.Name = "lblnomyape";
            this.lblnomyape.Size = new System.Drawing.Size(122, 16);
            this.lblnomyape.TabIndex = 0;
            this.lblnomyape.Text = "Nombre y Apellido:";
            this.lblnomyape.Click += new System.EventHandler(this.lblnomyape_Click);
            // 
            // lblmodif
            // 
            this.lblmodif.AutoSize = true;
            this.lblmodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodif.ForeColor = System.Drawing.Color.Red;
            this.lblmodif.Location = new System.Drawing.Point(159, 33);
            this.lblmodif.Name = "lblmodif";
            this.lblmodif.Size = new System.Drawing.Size(62, 16);
            this.lblmodif.TabIndex = 1;
            this.lblmodif.Text = "modificar";
            this.lblmodif.Click += new System.EventHandler(this.lblmodificar_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(31, 193);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(56, 16);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldni.Location = new System.Drawing.Point(31, 98);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(30, 16);
            this.lbldni.TabIndex = 3;
            this.lbldni.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.Location = new System.Drawing.Point(31, 147);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(57, 16);
            this.lblapellido.TabIndex = 5;
            this.lblapellido.Text = "Apellido";
            this.lblapellido.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(144, 276);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(34, 276);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtAPE
            // 
            this.txtAPE.Location = new System.Drawing.Point(144, 143);
            this.txtAPE.Name = "txtAPE";
            this.txtAPE.Size = new System.Drawing.Size(113, 20);
            this.txtAPE.TabIndex = 8;
            this.txtAPE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPE_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.White;
            this.txtDNI.Location = new System.Drawing.Point(144, 94);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(113, 20);
            this.txtDNI.TabIndex = 9;
            this.txtDNI.Click += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtNOM
            // 
            this.txtNOM.Location = new System.Drawing.Point(144, 189);
            this.txtNOM.Name = "txtNOM";
            this.txtNOM.Size = new System.Drawing.Size(113, 20);
            this.txtNOM.TabIndex = 10;
            this.txtNOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOM_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 343);
            this.Controls.Add(this.txtNOM);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtAPE);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblmodif);
            this.Controls.Add(this.lblnomyape);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnomyape;
        private System.Windows.Forms.Label lblmodif;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtAPE;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNOM;
    }
}

