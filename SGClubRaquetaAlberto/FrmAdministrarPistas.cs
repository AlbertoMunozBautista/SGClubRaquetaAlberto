using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaAlberto
{
    public partial class FrmAdministrarPistas : Form
    {
        public FrmAdministrarPistas()
        {
            InitializeComponent();
        }

        private void pistasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pistasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void FrmAdministrarPistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.dsBD.pistas);

        }

        /**
         * Cuando pulsamos en el botón de eliminar pista
         */
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //si la respuesta del diálogo es sí
            DialogResult resp = new DialogResult();

            resp = MessageBox.Show("Estás seguro de querer eliminar esta pista?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (resp == DialogResult.Yes)
            {
                //Miramos a ver si esta película está prestada
                dsBDTableAdapters.reservasTableAdapter tbReservas = new dsBDTableAdapters.reservasTableAdapter();

                tbReservas.FillByPista(dsBD.reservas, int.Parse(idPistaLabel1.Text));

                if (dsBD.reservas.Count > 0)
                {
                    //Si está alquilada no podemos devolverla
                    MessageBox.Show("No puede eliminarse porque está reservada!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //si no está alquilada va a tomar por culo
                    this.pistasTableAdapter.Delete(int.Parse(idPistaLabel1.Text));
                    MessageBox.Show("La pista ha sido eliminada con éxito!", "Borrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                //Se actualiza todo
                this.pistasTableAdapter.Fill(this.dsBD.pistas);

            }
        }

        /**
         * cuando pulsamos en el botón de nueva foto, cambai la foto del picture box
         */
        private void btnNuevaFoto_Click(object sender, EventArgs e)
        {

            //filtramos el openfile dialog 
            ofdFoto.Filter = "Imágenes(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            //si elegimos la imagen, se cambia
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = new Bitmap(ofdFoto.FileName);
            }
           
        }
    }
}
