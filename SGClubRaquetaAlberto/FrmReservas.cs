using System;
using System.Collections;
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
    public partial class FrmReservas : Form
    {
        //creamos un dsbd para todo el formulario
        dsBD ds = new dsBD();

        //arrays de socios y pistas
        ArrayList listaSocios = new ArrayList();
        ArrayList listaPistas = new ArrayList();

        public FrmReservas()
        {
            InitializeComponent();

            //damos formato al datagrid
            dgvReservas.DataSource = ds.reservas;
            darFormatoDataGrid();
        }

        /**
         * tuneamos el datagrid
         */
        private void darFormatoDataGrid()
        {
            dgvReservas.Columns[0].Visible = false;
            dgvReservas.Columns[4].Visible = false;
            dgvReservas.Columns[6].HeaderText = "Euros";
        }

        /**
         * cuando se carga el formulario, se desativa el botón reservar
         * se pone la fecha mínima del datatime a hoy y
         * se cargan los combos de socios y pistas
         */
        private void FrmReservas_Load(object sender, EventArgs e)
        {
            this.btnReservar.Enabled = false;
            this.dateFecha.MinDate = DateTime.Now;
            cargarSocios();
            cargarPistas();
        }


        /**
         * cargamos el combo de socios
         */
        private void cargarSocios()
        {
            //limpiamos el array para que no se dupliquen los datos
            this.listaSocios.Clear();

            //hacemos un select * a la tabla socios
            dsBDTableAdapters.sociosTableAdapter tbSocios = new dsBDTableAdapters.sociosTableAdapter();

            tbSocios.Fill(ds.socios);

            //guardamos el dni del socio en el array (clave primaria) y los apellidos y el nombre en el combo
            for (int i = 0; i < ds.socios.Count; i++)
            {
                this.comboSocio.Items.Add(ds.socios[i].apellidos.ToString() + ", " + ds.socios[i].nombre.ToString());
                this.listaSocios.Add(ds.socios[i].DNI.ToString());

            }
        }

        /**
         * Cuando seleccionamos un socio
         */
        private void comboSocio_TextChanged(object sender, EventArgs e)
        {
            //si el combo socio no está vacío se hace una consulta a la tabla socios
            //consultando por el dni del socio actual

            if (!comboSocio.Text.Equals(string.Empty))
            {
                dsBDTableAdapters.sociosTableAdapter tbSocios = new dsBDTableAdapters.sociosTableAdapter();

                tbSocios.FillByDNI(ds.socios, (String)listaSocios[comboSocio.SelectedIndex]);

                //se rellenan todos los text box 
                txtDniSocio.Text = ds.socios[0].DNI;
                txtNombreSocio.Text = ds.socios[0].nombre;
                txtDireccionSocio.Text = ds.socios[0].domicilio;
                txtTelefonoSocio.Text = ds.socios[0].telefono;
                txtApellidosSocio.Text = ds.socios[0].apellidos;
                txtCuentaSocio.Text = ds.socios[0].cuentaCorriente;
                txtEmailSocio.Text = ds.socios[0].email;

                //se activa el boton reservar
                btnReservar.Enabled = true;

                //se llena el datagrid
                cargarReservas(ds.socios[0].DNI);
            }

        }

        /**
         * Método recibe un dni y carga las reservas de ese socio en el datagrid
         */
        private void cargarReservas(String dni)
        {

            dsBDTableAdapters.reservasTableAdapter tbReservas = new dsBDTableAdapters.reservasTableAdapter();

            tbReservas.FillBySocio(ds.reservas, dni);
            dgvReservas.DataSource = ds.reservas;

        }

        /**
         * Botón reservar
         */
        private void btnReservar_Click(object sender, EventArgs e)
        {

            //hacemos una consulta a la tabla reservas para ver si el socio seleccionado tiene reservas sin pagar
            dsBDTableAdapters.reservasTableAdapter tbReservas = new dsBDTableAdapters.reservasTableAdapter();

            tbReservas.FillByNoPagadas(ds.reservas, txtDniSocio.Text);

            Boolean reserva = false;
            string horaSeleccionada = "";

            //en caso de que tenga reservas sin pagar no se le permite reservar
            if (ds.reservas.Count > 0)
            {
                MessageBox.Show("Tienes reservas sin pagar");
            }
            //si el socio no es un moroso
            else
            {
                //hacemos uns consulta a la tabla reservas para ver las pistas que hay reservadas ese día
                tbReservas.FillByPistaFecha(ds.reservas, (int)listaPistas[comboPistas.SelectedIndex], dateFecha.Text);

                //si hay pistas reservadas ese día
                if (ds.reservas.Count > 0)
                {
                    int cont = 0;
                    //recorremos todas las reservas
                    for (int i = 0; i < ds.reservas.Count; i++)
                    {
                        //guardamos la hora de cada reserva
                        TimeSpan horaBBDD = ds.reservas[i].hora;
                        horaSeleccionada = numHoras.Value.ToString() + ":" + numMinutos.Value.ToString() + ":00";

                        //la mandamos al método comparar horas que devolverá falso en el caso de que la hora esté libre
                        reserva = compararHoras(horaBBDD, horaSeleccionada);

                        //si la hora no está libre suma 1 el contador
                        if (reserva)
                        {
                            cont++;
                        }

                    }

                    //si el contador es igual a 0, osea, que la hora elegida no coincide con ninguna de las reservas ya almacenadas
                    if (cont == 0)
                    {
                        //preguntamos si quiere reservar la pista
                        DialogResult resp = new DialogResult();
                        resp = MessageBox.Show("Pista libre, seguro que quieres reservarla?", "Reservar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resp == DialogResult.Yes)
                        {
                            //si responde que si hacemos un insert en la tabla reservas 
                            dsBDTableAdapters.reservasTableAdapter tbReservasInsert = new dsBDTableAdapters.reservasTableAdapter();

                            TimeSpan horaTimeSpan = DateTime.Parse(horaSeleccionada).TimeOfDay;

                            tbReservasInsert.Insert(dateFecha.Value, horaTimeSpan, (int)listaPistas[comboPistas.SelectedIndex],
                                txtDniSocio.Text, "No", 28);

                            //cargamos el datagrid
                            cargarReservas(txtDniSocio.Text);

                            //enseñamos el mensaje con la info
                            MessageBox.Show("Pista " + comboPistas.Text + " reservada el día " + this.dateFecha.Value.Day + " del " +
                              this.dateFecha.Value.Month + " a las " + this.numHoras.Value + " horas y " + this.numMinutos.Value + " minutos. Se ruega que pague la pista lo más rápido posible.");

                        } else
                        {
                            //si la respuesta es no, cancelamos la reserva
                            MessageBox.Show("Reserva cancelada.");
                        }
                    }
                    else
                    {
                        //si contador vale diferente de 0 la hora elegida coincide con alguna de las horas previamente almacenadas
                        MessageBox.Show("Pista no disponible a esa hora.");
                    }

                } else
                {
                    //si ese dia no hay reservas podemos reservar en todas las horas, no hace falta consultar
                    DialogResult resp = new DialogResult();
                    resp = MessageBox.Show("Pista libre, seguro que quieres reservarla?", "Reservar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //preguntamos si quiere reservar la pista
                    if (resp == DialogResult.Yes)
                    {
                        //si responde que si hacemos un insert en la tabla reservas
                        dsBDTableAdapters.reservasTableAdapter tbReservasInsert = new dsBDTableAdapters.reservasTableAdapter();
                        horaSeleccionada = numHoras.Value.ToString() + ":" + numMinutos.Value.ToString() + ":00";

                        TimeSpan horaTimeSpan = DateTime.Parse(horaSeleccionada).TimeOfDay;

                        tbReservasInsert.Insert(dateFecha.Value, horaTimeSpan, (int)listaPistas[comboPistas.SelectedIndex],
                            txtDniSocio.Text, "No", 28);

                        //cargamos el datagrid
                        cargarReservas(txtDniSocio.Text);

                        //enseñamos el mensaje con la info
                        MessageBox.Show("Pista " + comboPistas.Text + " reservada el día " + this.dateFecha.Value.Day + " del " +
                          this.dateFecha.Value.Month + " a las " + this.numHoras.Value + " horas y " + this.numMinutos.Value + " minutos. Se ruega que pague la pista lo más rápido posible.");

                    } else
                    {
                        MessageBox.Show("Reserva cancelada.");
                    }

                }
            }
        }


        /**
        * Método que devuelve false si el intervalo entre las horas es más de 1:30 horas y true si lo contrario
        */
        private bool compararHoras(TimeSpan horaBD, string strHoraReserva)
        {
            bool bol_correcto;

            TimeSpan horaReserva = DateTime.Parse(strHoraReserva).TimeOfDay;
            //se calcula el intervalo entre las dos
            TimeSpan intervalo = horaReserva - horaBD;

            if (Math.Abs(intervalo.Hours) < 1)
            {
                bol_correcto = true;
            }
            else if (Math.Abs(intervalo.Hours) >= 2)
            {
                bol_correcto = false;
            }
            else if (Math.Abs(intervalo.Minutes) >= 30)
            {
                //Si solo hay una hora de diferencia en el intervalo
                //se mira que haya 30min o mas de espacio en el intervalo
                bol_correcto = false;
            }
            else
            {
                bol_correcto = true;
            }

            return bol_correcto;
        }

        /**
        * Método que carga el combo pistas
        */
        private void cargarPistas()
        {
            //hacemos un select * a la tabla pistas
            dsBDTableAdapters.pistasTableAdapter tbPistas = new dsBDTableAdapters.pistasTableAdapter();

            tbPistas.Fill(ds.pistas);

            //recorremos todas las pistas, guardamos el idpista en el array y guardamos el nombre en el combo
            for (int i = 0; i < ds.pistas.Count; i++)
            {
                this.comboPistas.Items.Add(ds.pistas[i].nombre.ToString());
                this.listaPistas.Add(ds.pistas[i].idPista);
            }
        }

        /**
        * Cuando seleccionamos una pista
        */
        private void comboPistas_TextChanged(object sender, EventArgs e)
        {
            //hacemos una consulta a la tabla pista por el idpista
            dsBDTableAdapters.pistasTableAdapter tbPistas = new dsBDTableAdapters.pistasTableAdapter();

            tbPistas.FillByIdPista(ds.pistas, (int)listaPistas[comboPistas.SelectedIndex]);

            //ponemos la imagen de la pista en el picture box
            picturePistas.Image = byteArrayToImage(ds.pistas[0].foto);
            
        }

        /**
        * Método que devuelve un Image a partir de un bytearray
        */
        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream ms = new MemoryStream(bytesArr);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        /**
        * Botón pagar
        */
        private void btnPagar_Click(object sender, EventArgs e)
        {
            //guardamos el id de la reserva, que lo vamos a coger de la fila seleccionada en el datagrid
            int idReserva = int.Parse(dgvReservas.SelectedRows[0].Cells[0].Value.ToString());

            //hacemos una consulta por el idreserva a la tabla resrva
            dsBDTableAdapters.reservasTableAdapter tbReservas = new dsBDTableAdapters.reservasTableAdapter();

            //si nos devuelve algo es porque no está pagada, ya que una condición del where es esa
            tbReservas.FillByIdReservaPagado(ds.reservas, idReserva);

            //si nos devuelve algo, hacemos un update y cambiamos el campo pagado a si
            if (ds.reservas.Count > 0)
            {
                tbReservas.UpdateQueryPagadoSi(idReserva);
                cargarReservas(txtDniSocio.Text);
                MessageBox.Show("Pago recibido.");
            } else
            {
                MessageBox.Show("Pista ya pagada");
                cargarReservas(txtDniSocio.Text);
            }
        }

    }
}
