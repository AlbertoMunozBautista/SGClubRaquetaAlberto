using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaAlberto
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /**
         * Cuando hacemos click en el menú salir nos salimos de la aplicación
         */
        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Cuando hacemos click en el menú socios nos abre un formulario para gestionar los socios
         */
        private void menuSocios_Click(object sender, EventArgs e)
        {
            FrmAdministrarSocios frmAdministrarSocios = new FrmAdministrarSocios();
            frmAdministrarSocios.ShowDialog();
        }


        /**
         * Cuando hacemos click en el menú pistas nos abre un formulario para gestionar las pistas
         */
        private void menuPistas_Click(object sender, EventArgs e)
        {
            FrmAdministrarPistas frmAdministrarPistas = new FrmAdministrarPistas();
            frmAdministrarPistas.ShowDialog();
        }

        /**
         * Cuando hacemos click en el menú reservas cargamos dentro del formulario principal el formulario de reservas
         */
        private void menuReservas_Click(object sender, EventArgs e)
        {
            FrmReservas frmReservas = new FrmReservas();
            frmReservas.MdiParent = this;
            frmReservas.Dock = DockStyle.Fill;
            frmReservas.Show();
        }
    }
}
