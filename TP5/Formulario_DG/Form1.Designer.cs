﻿namespace Formulario_DG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.tAPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDEL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFOT = new System.Windows.Forms.DataGridViewImageColumn();
            this.tRUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgFOTO = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtFECHA = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.checkMujer = new System.Windows.Forms.CheckBox();
            this.checkHombre = new System.Windows.Forms.CheckBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.txtRUTA = new System.Windows.Forms.TextBox();
            this.txtSALDO = new System.Windows.Forms.TextBox();
            this.txtAPE = new System.Windows.Forms.TextBox();
            this.txtNOM = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblFec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFOTO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrid
            // 
            this.dgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tAPE,
            this.tNOM,
            this.tFEC,
            this.tSEX,
            this.tDEL,
            this.tSAL,
            this.tFOT,
            this.tRUT});
            this.dgrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgrid.Location = new System.Drawing.Point(12, 317);
            this.dgrid.Name = "dgrid";
            this.dgrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgrid.Size = new System.Drawing.Size(608, 116);
            this.dgrid.TabIndex = 2;
            this.dgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_CellClick);
            this.dgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tAPE
            // 
            this.tAPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tAPE.HeaderText = "Apellido";
            this.tAPE.Name = "tAPE";
            this.tAPE.Width = 47;
            // 
            // tNOM
            // 
            this.tNOM.FillWeight = 43.42587F;
            this.tNOM.HeaderText = "Nombre";
            this.tNOM.Name = "tNOM";
            this.tNOM.Width = 69;
            // 
            // tFEC
            // 
            this.tFEC.FillWeight = 56.62392F;
            this.tFEC.HeaderText = "Fecha de nacimiento";
            this.tFEC.Name = "tFEC";
            this.tFEC.Width = 120;
            // 
            // tSEX
            // 
            this.tSEX.FillWeight = 56.62392F;
            this.tSEX.HeaderText = "Sexo";
            this.tSEX.Name = "tSEX";
            this.tSEX.Width = 56;
            // 
            // tDEL
            // 
            this.tDEL.DataPropertyName = "(nas";
            this.tDEL.FillWeight = 56.62392F;
            this.tDEL.HeaderText = "Eliminar";
            this.tDEL.Name = "tDEL";
            this.tDEL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tDEL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tDEL.Text = "Eliminar";
            this.tDEL.Width = 68;
            // 
            // tSAL
            // 
            this.tSAL.FillWeight = 56.62392F;
            this.tSAL.HeaderText = "Saldo";
            this.tSAL.Name = "tSAL";
            this.tSAL.Width = 59;
            // 
            // tFOT
            // 
            this.tFOT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tFOT.FillWeight = 56.62392F;
            this.tFOT.HeaderText = "Foto";
            this.tFOT.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.tFOT.Name = "tFOT";
            this.tFOT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tFOT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tRUT
            // 
            this.tRUT.FillWeight = 56.62392F;
            this.tRUT.HeaderText = "Ruta";
            this.tRUT.Name = "tRUT";
            this.tRUT.Width = 55;
            // 
            // imgFOTO
            // 
            this.imgFOTO.Image = global::Formulario_DG.Properties.Resources.usuario;
            this.imgFOTO.Location = new System.Drawing.Point(441, 80);
            this.imgFOTO.Name = "imgFOTO";
            this.imgFOTO.Size = new System.Drawing.Size(179, 180);
            this.imgFOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFOTO.TabIndex = 1;
            this.imgFOTO.TabStop = false;
            this.imgFOTO.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = global::Formulario_DG.Properties.Resources.Gaming_Cloud_780x525_1;
            this.panel1.Controls.Add(this.dtFECHA);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.checkMujer);
            this.panel1.Controls.Add(this.checkHombre);
            this.panel1.Controls.Add(this.btnFoto);
            this.panel1.Controls.Add(this.txtRUTA);
            this.panel1.Controls.Add(this.txtSALDO);
            this.panel1.Controls.Add(this.txtAPE);
            this.panel1.Controls.Add(this.txtNOM);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Controls.Add(this.lblApe);
            this.panel1.Controls.Add(this.lblFec);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 271);
            this.panel1.TabIndex = 0;
            // 
            // dtFECHA
            // 
            this.dtFECHA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFECHA.Location = new System.Drawing.Point(228, 91);
            this.dtFECHA.Name = "dtFECHA";
            this.dtFECHA.Size = new System.Drawing.Size(106, 20);
            this.dtFECHA.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAgregar.Location = new System.Drawing.Point(151, 214);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 38);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // checkMujer
            // 
            this.checkMujer.AutoSize = true;
            this.checkMujer.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMujer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkMujer.Location = new System.Drawing.Point(208, 112);
            this.checkMujer.Name = "checkMujer";
            this.checkMujer.Size = new System.Drawing.Size(89, 37);
            this.checkMujer.TabIndex = 13;
            this.checkMujer.Text = "Mujer";
            this.checkMujer.UseVisualStyleBackColor = true;
            // 
            // checkHombre
            // 
            this.checkHombre.AutoSize = true;
            this.checkHombre.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkHombre.Location = new System.Drawing.Point(97, 112);
            this.checkHombre.Name = "checkHombre";
            this.checkHombre.Size = new System.Drawing.Size(108, 37);
            this.checkHombre.TabIndex = 12;
            this.checkHombre.Text = "Hombre";
            this.checkHombre.UseVisualStyleBackColor = true;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(30, 183);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(53, 28);
            this.btnFoto.TabIndex = 11;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // txtRUTA
            // 
            this.txtRUTA.Location = new System.Drawing.Point(116, 188);
            this.txtRUTA.Name = "txtRUTA";
            this.txtRUTA.Size = new System.Drawing.Size(218, 20);
            this.txtRUTA.TabIndex = 10;
            // 
            // txtSALDO
            // 
            this.txtSALDO.Location = new System.Drawing.Point(116, 155);
            this.txtSALDO.Name = "txtSALDO";
            this.txtSALDO.Size = new System.Drawing.Size(218, 20);
            this.txtSALDO.TabIndex = 9;
            this.txtSALDO.TextChanged += new System.EventHandler(this.txtSALDO_TextChanged);
            this.txtSALDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSALDO_KeyPress);
            // 
            // txtAPE
            // 
            this.txtAPE.Location = new System.Drawing.Point(116, 61);
            this.txtAPE.Name = "txtAPE";
            this.txtAPE.Size = new System.Drawing.Size(218, 20);
            this.txtAPE.TabIndex = 8;
            this.txtAPE.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtAPE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPE_KeyPress);
            // 
            // txtNOM
            // 
            this.txtNOM.Location = new System.Drawing.Point(116, 26);
            this.txtNOM.Name = "txtNOM";
            this.txtNOM.Size = new System.Drawing.Size(218, 20);
            this.txtNOM.TabIndex = 7;
            this.txtNOM.TextChanged += new System.EventHandler(this.txtNOM_TextChanged);
            this.txtNOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOM_KeyPress);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSex.Location = new System.Drawing.Point(10, 116);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(66, 33);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaldo.Location = new System.Drawing.Point(10, 147);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(74, 33);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApe.Location = new System.Drawing.Point(10, 53);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(94, 33);
            this.lblApe.TabIndex = 3;
            this.lblApe.Text = "Apellido";
            // 
            // lblFec
            // 
            this.lblFec.AutoSize = true;
            this.lblFec.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFec.Location = new System.Drawing.Point(10, 86);
            this.lblFec.Name = "lblFec";
            this.lblFec.Size = new System.Drawing.Size(197, 33);
            this.lblFec.TabIndex = 4;
            this.lblFec.Text = "Fecha de nacimiento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formulario_DG.Properties.Resources.fondogamer6;
            this.ClientSize = new System.Drawing.Size(650, 445);
            this.Controls.Add(this.dgrid);
            this.Controls.Add(this.imgFOTO);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario con DataGrid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFOTO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgFOTO;
        private System.Windows.Forms.TextBox txtRUTA;
        private System.Windows.Forms.TextBox txtSALDO;
        private System.Windows.Forms.TextBox txtAPE;
        private System.Windows.Forms.TextBox txtNOM;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblFec;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.CheckBox checkMujer;
        private System.Windows.Forms.CheckBox checkHombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtFECHA;
        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn tFEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSEX;
        private System.Windows.Forms.DataGridViewButtonColumn tDEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSAL;
        private System.Windows.Forms.DataGridViewImageColumn tFOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUT;
    }
}

