
namespace SGClubRaquetaAlberto
{
    partial class FrmReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCuentaSocio = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonoSocio = new System.Windows.Forms.MaskedTextBox();
            this.txtApellidosSocio = new System.Windows.Forms.TextBox();
            this.txtEmailSocio = new System.Windows.Forms.TextBox();
            this.txtDireccionSocio = new System.Windows.Forms.TextBox();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.picturePistas = new System.Windows.Forms.PictureBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.numMinutos = new System.Windows.Forms.NumericUpDown();
            this.numHoras = new System.Windows.Forms.NumericUpDown();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.comboPistas = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboSocio = new System.Windows.Forms.ComboBox();
            this.txtDniSocio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtCuentaSocio);
            this.panel1.Controls.Add(this.txtTelefonoSocio);
            this.panel1.Controls.Add(this.txtApellidosSocio);
            this.panel1.Controls.Add(this.txtEmailSocio);
            this.panel1.Controls.Add(this.txtDireccionSocio);
            this.panel1.Controls.Add(this.txtNombreSocio);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 164);
            this.panel1.TabIndex = 0;
            // 
            // txtCuentaSocio
            // 
            this.txtCuentaSocio.Location = new System.Drawing.Point(529, 67);
            this.txtCuentaSocio.Mask = "ES99-9999-9999-9999-9999";
            this.txtCuentaSocio.Name = "txtCuentaSocio";
            this.txtCuentaSocio.ReadOnly = true;
            this.txtCuentaSocio.Size = new System.Drawing.Size(230, 22);
            this.txtCuentaSocio.TabIndex = 11;
            // 
            // txtTelefonoSocio
            // 
            this.txtTelefonoSocio.Location = new System.Drawing.Point(124, 114);
            this.txtTelefonoSocio.Mask = "999-999-999";
            this.txtTelefonoSocio.Name = "txtTelefonoSocio";
            this.txtTelefonoSocio.ReadOnly = true;
            this.txtTelefonoSocio.Size = new System.Drawing.Size(230, 22);
            this.txtTelefonoSocio.TabIndex = 10;
            // 
            // txtApellidosSocio
            // 
            this.txtApellidosSocio.Location = new System.Drawing.Point(529, 19);
            this.txtApellidosSocio.Name = "txtApellidosSocio";
            this.txtApellidosSocio.ReadOnly = true;
            this.txtApellidosSocio.Size = new System.Drawing.Size(230, 22);
            this.txtApellidosSocio.TabIndex = 9;
            // 
            // txtEmailSocio
            // 
            this.txtEmailSocio.Location = new System.Drawing.Point(529, 114);
            this.txtEmailSocio.Name = "txtEmailSocio";
            this.txtEmailSocio.ReadOnly = true;
            this.txtEmailSocio.Size = new System.Drawing.Size(230, 22);
            this.txtEmailSocio.TabIndex = 8;
            // 
            // txtDireccionSocio
            // 
            this.txtDireccionSocio.Location = new System.Drawing.Point(124, 67);
            this.txtDireccionSocio.Name = "txtDireccionSocio";
            this.txtDireccionSocio.ReadOnly = true;
            this.txtDireccionSocio.Size = new System.Drawing.Size(230, 22);
            this.txtDireccionSocio.TabIndex = 7;
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Location = new System.Drawing.Point(124, 17);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(230, 22);
            this.txtNombreSocio.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CCC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.picturePistas);
            this.panel2.Controls.Add(this.btnReservar);
            this.panel2.Controls.Add(this.numMinutos);
            this.panel2.Controls.Add(this.numHoras);
            this.panel2.Controls.Add(this.dateFecha);
            this.panel2.Controls.Add(this.comboPistas);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 164);
            this.panel2.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(562, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Duración: 1h 30 minutos";
            // 
            // picturePistas
            // 
            this.picturePistas.Location = new System.Drawing.Point(565, 18);
            this.picturePistas.Name = "picturePistas";
            this.picturePistas.Size = new System.Drawing.Size(299, 100);
            this.picturePistas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePistas.TabIndex = 17;
            this.picturePistas.TabStop = false;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(366, 82);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(102, 56);
            this.btnReservar.TabIndex = 16;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // numMinutos
            // 
            this.numMinutos.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numMinutos.Location = new System.Drawing.Point(249, 116);
            this.numMinutos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numMinutos.Name = "numMinutos";
            this.numMinutos.Size = new System.Drawing.Size(53, 22);
            this.numMinutos.TabIndex = 14;
            // 
            // numHoras
            // 
            this.numHoras.Location = new System.Drawing.Point(124, 116);
            this.numHoras.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numHoras.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numHoras.Name = "numHoras";
            this.numHoras.Size = new System.Drawing.Size(53, 22);
            this.numHoras.TabIndex = 13;
            this.numHoras.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // dateFecha
            // 
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(124, 63);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(136, 22);
            this.dateFecha.TabIndex = 12;
            // 
            // comboPistas
            // 
            this.comboPistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPistas.FormattingEnabled = true;
            this.comboPistas.Location = new System.Drawing.Point(124, 18);
            this.comboPistas.Name = "comboPistas";
            this.comboPistas.Size = new System.Drawing.Size(230, 24);
            this.comboPistas.TabIndex = 10;
            this.comboPistas.TextChanged += new System.EventHandler(this.comboPistas_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hora Inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pista:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnPagar);
            this.panel3.Controls.Add(this.dgvReservas);
            this.panel3.Location = new System.Drawing.Point(12, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 233);
            this.panel3.TabIndex = 1;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(396, 175);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(130, 38);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(17, 14);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(914, 155);
            this.dgvReservas.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Elige al socio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(458, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "DNI Socio:";
            // 
            // comboSocio
            // 
            this.comboSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSocio.FormattingEnabled = true;
            this.comboSocio.Location = new System.Drawing.Point(136, 6);
            this.comboSocio.Name = "comboSocio";
            this.comboSocio.Size = new System.Drawing.Size(230, 24);
            this.comboSocio.TabIndex = 8;
            this.comboSocio.TextChanged += new System.EventHandler(this.comboSocio_TextChanged);
            // 
            // txtDniSocio
            // 
            this.txtDniSocio.AutoSize = true;
            this.txtDniSocio.Location = new System.Drawing.Point(538, 9);
            this.txtDniSocio.Name = "txtDniSocio";
            this.txtDniSocio.Size = new System.Drawing.Size(0, 17);
            this.txtDniSocio.TabIndex = 9;
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 631);
            this.Controls.Add(this.txtDniSocio);
            this.Controls.Add(this.comboSocio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReservas";
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox txtCuentaSocio;
        private System.Windows.Forms.MaskedTextBox txtTelefonoSocio;
        private System.Windows.Forms.TextBox txtApellidosSocio;
        private System.Windows.Forms.TextBox txtEmailSocio;
        private System.Windows.Forms.TextBox txtDireccionSocio;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.NumericUpDown numMinutos;
        private System.Windows.Forms.NumericUpDown numHoras;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.ComboBox comboPistas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboSocio;
        private System.Windows.Forms.Label txtDniSocio;
        private System.Windows.Forms.PictureBox picturePistas;
        private System.Windows.Forms.Label label13;
    }
}