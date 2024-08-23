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
            this.lblapellido = new System.Windows.Forms.Label();
            this.txtAPE = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNOM = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxmastercard = new System.Windows.Forms.CheckBox();
            this.cboxvisa = new System.Windows.Forms.CheckBox();
            this.cboxnaranja = new System.Windows.Forms.CheckBox();
            this.lbltarjeta = new System.Windows.Forms.Label();
            this.txtTEL = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pboxGenero = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnomyape
            // 
            this.lblnomyape.AutoSize = true;
            this.lblnomyape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomyape.Location = new System.Drawing.Point(19, 15);
            this.lblnomyape.Name = "lblnomyape";
            this.lblnomyape.Size = new System.Drawing.Size(122, 16);
            this.lblnomyape.TabIndex = 0;
            this.lblnomyape.Text = "Nombre y Apellido:";
            this.lblnomyape.Click += new System.EventHandler(this.lblnomyape_Click);
            // 
            // lblmodif
            // 
            this.lblmodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodif.ForeColor = System.Drawing.Color.Red;
            this.lblmodif.Location = new System.Drawing.Point(147, 1);
            this.lblmodif.Name = "lblmodif";
            this.lblmodif.Size = new System.Drawing.Size(129, 45);
            this.lblmodif.TabIndex = 1;
            this.lblmodif.Text = "modificar";
            this.lblmodif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblmodif.Click += new System.EventHandler(this.lblmodificar_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(19, 131);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(56, 16);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldni.Location = new System.Drawing.Point(19, 52);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(30, 16);
            this.lbldni.TabIndex = 3;
            this.lbldni.Text = "DNI";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.Location = new System.Drawing.Point(19, 92);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(57, 16);
            this.lblapellido.TabIndex = 5;
            this.lblapellido.Text = "Apellido";
            this.lblapellido.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtAPE
            // 
            this.txtAPE.Location = new System.Drawing.Point(123, 88);
            this.txtAPE.Name = "txtAPE";
            this.txtAPE.Size = new System.Drawing.Size(113, 20);
            this.txtAPE.TabIndex = 8;
            this.txtAPE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPE_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.White;
            this.txtDNI.Location = new System.Drawing.Point(123, 48);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(113, 20);
            this.txtDNI.TabIndex = 9;
            this.txtDNI.Click += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtNOM
            // 
            this.txtNOM.Location = new System.Drawing.Point(123, 127);
            this.txtNOM.Name = "txtNOM";
            this.txtNOM.Size = new System.Drawing.Size(113, 20);
            this.txtNOM.TabIndex = 10;
            this.txtNOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOM_KeyPress);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.cboxmastercard);
            this.panel1.Controls.Add(this.cboxvisa);
            this.panel1.Controls.Add(this.cboxnaranja);
            this.panel1.Controls.Add(this.lbltarjeta);
            this.panel1.Controls.Add(this.txtTEL);
            this.panel1.Controls.Add(this.lbltelefono);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Controls.Add(this.txtNOM);
            this.panel1.Controls.Add(this.lbldni);
            this.panel1.Controls.Add(this.lblmodif);
            this.panel1.Controls.Add(this.txtAPE);
            this.panel1.Controls.Add(this.lblnomyape);
            this.panel1.Controls.Add(this.lblapellido);
            this.panel1.Controls.Add(this.lblnombre);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 299);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboxmastercard
            // 
            this.cboxmastercard.AutoSize = true;
            this.cboxmastercard.Location = new System.Drawing.Point(138, 265);
            this.cboxmastercard.Name = "cboxmastercard";
            this.cboxmastercard.Size = new System.Drawing.Size(79, 17);
            this.cboxmastercard.TabIndex = 17;
            this.cboxmastercard.Text = "Mastercard";
            this.cboxmastercard.UseVisualStyleBackColor = true;
            // 
            // cboxvisa
            // 
            this.cboxvisa.AutoSize = true;
            this.cboxvisa.Location = new System.Drawing.Point(138, 242);
            this.cboxvisa.Name = "cboxvisa";
            this.cboxvisa.Size = new System.Drawing.Size(46, 17);
            this.cboxvisa.TabIndex = 16;
            this.cboxvisa.Text = "Visa";
            this.cboxvisa.UseVisualStyleBackColor = true;
            // 
            // cboxnaranja
            // 
            this.cboxnaranja.AutoSize = true;
            this.cboxnaranja.Location = new System.Drawing.Point(138, 219);
            this.cboxnaranja.Name = "cboxnaranja";
            this.cboxnaranja.Size = new System.Drawing.Size(63, 17);
            this.cboxnaranja.TabIndex = 15;
            this.cboxnaranja.Text = "Naranja";
            this.cboxnaranja.UseVisualStyleBackColor = true;
            // 
            // lbltarjeta
            // 
            this.lbltarjeta.AutoSize = true;
            this.lbltarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltarjeta.Location = new System.Drawing.Point(19, 218);
            this.lbltarjeta.Name = "lbltarjeta";
            this.lbltarjeta.Size = new System.Drawing.Size(113, 16);
            this.lbltarjeta.TabIndex = 13;
            this.lbltarjeta.Text = "Tarjeta de credito";
            // 
            // txtTEL
            // 
            this.txtTEL.Location = new System.Drawing.Point(123, 166);
            this.txtTEL.Name = "txtTEL";
            this.txtTEL.Size = new System.Drawing.Size(113, 20);
            this.txtTEL.TabIndex = 12;
            this.txtTEL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(19, 170);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(61, 16);
            this.lbltelefono.TabIndex = 11;
            this.lbltelefono.Text = "Telefono";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbltitulo.Location = new System.Drawing.Point(214, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(142, 24);
            this.lbltitulo.TabIndex = 12;
            this.lbltitulo.Text = "Nuevo Cliente";
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.Checked = true;
            this.rbtnHombre.Location = new System.Drawing.Point(359, 220);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(53, 17);
            this.rbtnHombre.TabIndex = 19;
            this.rbtnHombre.TabStop = true;
            this.rbtnHombre.Text = "Varon";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            this.rbtnHombre.CheckedChanged += new System.EventHandler(this.rbtnHombre_CheckedChanged);
            this.rbtnHombre.Click += new System.EventHandler(this.rbtnHombre_Click);
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.Location = new System.Drawing.Point(438, 220);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(51, 17);
            this.rbtnMujer.TabIndex = 20;
            this.rbtnMujer.Text = "Mujer";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            this.rbtnMujer.CheckedChanged += new System.EventHandler(this.rbtnMujer_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Image = global::PequeñoFormulario.Properties.Resources.icons8_save_32;
            this.btnGuardar.Location = new System.Drawing.Point(34, 368);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 52);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::PequeñoFormulario.Properties.Resources.icons8_exit_32;
            this.btnSalir.Location = new System.Drawing.Point(421, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 52);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pboxGenero
            // 
            this.pboxGenero.Image = global::PequeñoFormulario.Properties.Resources.jefe;
            this.pboxGenero.InitialImage = null;
            this.pboxGenero.Location = new System.Drawing.Point(328, 50);
            this.pboxGenero.Name = "pboxGenero";
            this.pboxGenero.Size = new System.Drawing.Size(190, 160);
            this.pboxGenero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxGenero.TabIndex = 18;
            this.pboxGenero.TabStop = false;
            this.pboxGenero.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::PequeñoFormulario.Properties.Resources.icons8_delete_user_32;
            this.btnEliminar.Location = new System.Drawing.Point(218, 368);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 52);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 454);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rbtnMujer);
            this.Controls.Add(this.rbtnHombre);
            this.Controls.Add(this.pboxGenero);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnomyape;
        private System.Windows.Forms.Label lblmodif;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtAPE;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNOM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTEL;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.CheckBox cboxmastercard;
        private System.Windows.Forms.CheckBox cboxvisa;
        private System.Windows.Forms.CheckBox cboxnaranja;
        private System.Windows.Forms.Label lbltarjeta;
        private System.Windows.Forms.PictureBox pboxGenero;
        private System.Windows.Forms.RadioButton rbtnHombre;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
    }
}

