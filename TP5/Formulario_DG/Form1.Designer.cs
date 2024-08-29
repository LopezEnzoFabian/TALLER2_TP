namespace Formulario_DG
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.checkMujer = new System.Windows.Forms.CheckBox();
            this.checkHombre = new System.Windows.Forms.CheckBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblFec = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.tAPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.checkMujer);
            this.panel1.Controls.Add(this.checkHombre);
            this.panel1.Controls.Add(this.btnFoto);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Controls.Add(this.lblApe);
            this.panel1.Controls.Add(this.lblFec);
            this.panel1.Location = new System.Drawing.Point(28, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 247);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(116, 187);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 48);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // checkMujer
            // 
            this.checkMujer.AutoSize = true;
            this.checkMujer.Location = new System.Drawing.Point(166, 112);
            this.checkMujer.Name = "checkMujer";
            this.checkMujer.Size = new System.Drawing.Size(52, 17);
            this.checkMujer.TabIndex = 13;
            this.checkMujer.Text = "Mujer";
            this.checkMujer.UseVisualStyleBackColor = true;
            // 
            // checkHombre
            // 
            this.checkHombre.AutoSize = true;
            this.checkHombre.Location = new System.Drawing.Point(97, 112);
            this.checkHombre.Name = "checkHombre";
            this.checkHombre.Size = new System.Drawing.Size(63, 17);
            this.checkHombre.TabIndex = 12;
            this.checkHombre.Text = "Hombre";
            this.checkHombre.UseVisualStyleBackColor = true;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(20, 161);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(53, 20);
            this.btnFoto.TabIndex = 11;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(17, 113);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(31, 13);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(17, 142);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(14, 58);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(44, 13);
            this.lblApe.TabIndex = 3;
            this.lblApe.Text = "Apellido";
            // 
            // lblFec
            // 
            this.lblFec.AutoSize = true;
            this.lblFec.Location = new System.Drawing.Point(14, 86);
            this.lblFec.Name = "lblFec";
            this.lblFec.Size = new System.Drawing.Size(106, 13);
            this.lblFec.TabIndex = 4;
            this.lblFec.Text = "Fecha de nacimiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(322, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 247);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtg1
            // 
            this.dtg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtg1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tAPE,
            this.tNOM,
            this.tFEC,
            this.tSEX,
            this.tDEL,
            this.tSAL,
            this.tFOT,
            this.tRUT});
            this.dtg1.Location = new System.Drawing.Point(28, 280);
            this.dtg1.Name = "dtg1";
            this.dtg1.Size = new System.Drawing.Size(513, 118);
            this.dtg1.TabIndex = 2;
            this.dtg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // 
            // tFEC
            // 
            this.tFEC.FillWeight = 56.62392F;
            this.tFEC.HeaderText = "Fecha de nacimiento";
            this.tFEC.Name = "tFEC";
            // 
            // tSEX
            // 
            this.tSEX.FillWeight = 56.62392F;
            this.tSEX.HeaderText = "Sexo";
            this.tSEX.Name = "tSEX";
            // 
            // tDEL
            // 
            this.tDEL.FillWeight = 56.62392F;
            this.tDEL.HeaderText = "Eliminar";
            this.tDEL.Name = "tDEL";
            // 
            // tSAL
            // 
            this.tSAL.FillWeight = 56.62392F;
            this.tSAL.HeaderText = "Saldo";
            this.tSAL.Name = "tSAL";
            // 
            // tFOT
            // 
            this.tFOT.FillWeight = 56.62392F;
            this.tFOT.HeaderText = "Foto";
            this.tFOT.Name = "tFOT";
            // 
            // tRUT
            // 
            this.tRUT.FillWeight = 56.62392F;
            this.tRUT.HeaderText = "Ruta";
            this.tRUT.Name = "tRUT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 411);
            this.Controls.Add(this.dtg1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Formulario con DataGrid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblFec;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.CheckBox checkMujer;
        private System.Windows.Forms.CheckBox checkHombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn tFEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tFOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRUT;
    }
}

