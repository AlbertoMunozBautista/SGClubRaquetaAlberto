
namespace SGClubRaquetaAlberto
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSocios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPistas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdministrar,
            this.menuReservas,
            this.menuInformes,
            this.menuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAdministrar
            // 
            this.menuAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSocios,
            this.menuPistas});
            this.menuAdministrar.Name = "menuAdministrar";
            this.menuAdministrar.Size = new System.Drawing.Size(120, 24);
            this.menuAdministrar.Text = "ADMINISTRAR";
            // 
            // menuSocios
            // 
            this.menuSocios.Name = "menuSocios";
            this.menuSocios.Size = new System.Drawing.Size(135, 26);
            this.menuSocios.Text = "Socios";
            this.menuSocios.Click += new System.EventHandler(this.menuSocios_Click);
            // 
            // menuPistas
            // 
            this.menuPistas.Name = "menuPistas";
            this.menuPistas.Size = new System.Drawing.Size(135, 26);
            this.menuPistas.Text = "Pistas";
            this.menuPistas.Click += new System.EventHandler(this.menuPistas_Click);
            // 
            // menuReservas
            // 
            this.menuReservas.Name = "menuReservas";
            this.menuReservas.Size = new System.Drawing.Size(91, 24);
            this.menuReservas.Text = "RESERVAS";
            this.menuReservas.Click += new System.EventHandler(this.menuReservas_Click);
            // 
            // menuInformes
            // 
            this.menuInformes.Name = "menuInformes";
            this.menuInformes.Size = new System.Drawing.Size(94, 24);
            this.menuInformes.Text = "INFORMES";
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(61, 24);
            this.menuSalir.Text = "SALIR";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 671);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuReservas;
        private System.Windows.Forms.ToolStripMenuItem menuInformes;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem menuAdministrar;
        private System.Windows.Forms.ToolStripMenuItem menuSocios;
        private System.Windows.Forms.ToolStripMenuItem menuPistas;
    }
}

