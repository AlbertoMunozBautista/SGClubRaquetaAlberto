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
    public partial class FrmAdministrarSocios : Form
    {
        public FrmAdministrarSocios()
        {
            InitializeComponent();
        }

        /**
         * Botón insertar
         */
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //si el campo dni tiene texto, recogemos todos los datos de los text box y hacemos un insert
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                if (!txtDni.Text.Equals(string.Empty))
                {
                    //creamos el objeto socio
                    socios objSocio = new socios();

                    objSocio.DNI = txtDni.Text;
                    objSocio.nombre = txtNombre.Text;
                    objSocio.apellidos = txtApellidos.Text;
                    objSocio.telefono = txtTelefono.Text;
                    objSocio.domicilio = txtDomicilio.Text;
                    objSocio.cuentaCorriente = txtCuenta.Text;
                    objSocio.email = txtEmail.Text;

                    //se añade el objeto a la tabla, para incluirlo como nuevo
                    objBD.socios.Add(objSocio);

                    //se guardan los cambios
                    objBD.SaveChanges();
                    MessageBox.Show("Socio insertado correctamente");

                    //rellenamos el data grid y limpiamos los textbox
                    mostrarSocios();
                    limpiarDatos();

                } else
                {
                    MessageBox.Show("Campo DNI vacío");
                }
            }
         
        }

        /**
         * Botón modificar
         */
        private void btnModificar_Click(object sender, EventArgs e)
        {

            //hacemos uns consulta de linq a la base de datos por el campo dni
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                //recuperamos el objeto de la bd, filtrando por el campo dni
                socios objSocio = objBD.socios.Find(txtDni.Text);
                if (objSocio != null)
                {
                    objSocio.DNI = txtDni.Text;
                    objSocio.nombre = txtNombre.Text;
                    objSocio.apellidos = txtApellidos.Text;
                    objSocio.telefono = txtTelefono.Text;
                    objSocio.domicilio = txtDomicilio.Text;
                    objSocio.cuentaCorriente = txtCuenta.Text;
                    objSocio.email = txtEmail.Text;

                    //se guardan los cambios
                    objBD.SaveChanges();
                    MessageBox.Show("Socio modificado correctamente");

                    //limpiamos los textbox y modificamos el datagrid
                    mostrarSocios();
                    limpiarDatos();

                }
                else
                {
                    MessageBox.Show("No se ha encontrado el socio");
                }
            }
        }


        /**
         * Botón eliminar
         */
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //hacemos uns consulta de linq a la base de datos por el campo dni
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                //recuperamos el objeto de la bd, filtrando por el campo dni
                socios objSocio = objBD.socios.Find(txtDni.Text);
                if (objSocio != null)
                {
                    //hacemos una consulta para ver si este socio tiene reservas activas
                    var qReservaSocio = from r in objBD.reservas
                                        where objSocio.DNI == r.socio
                                        select new
                                        {
                                            r.idReserva
                                        };

                    var listaReservas = qReservaSocio.ToList();

                    //si tiene reservas activas no se puede eliminar
                    if (listaReservas.Count > 0)
                    {
                        MessageBox.Show("No se puede eliminar al socio porque tiene reservas hechas");
                    //si no, se elimina
                    } else
                    {
                        //se elimina el objeto
                        objBD.socios.Remove(objSocio);

                        //se guardan los cambios
                        objBD.SaveChanges();
                        MessageBox.Show("Socio modificado correctamente");

                        mostrarSocios();
                        limpiarDatos();
                    }

                }
                else
                {
                    MessageBox.Show("No se ha encontrado el socio");
                }
            }
        }

        /**
         * Todos los textbox a cadena vacía
         */
        private void limpiarDatos()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDomicilio.Text = "";
            txtCuenta.Text = "";
            txtEmail.Text = "";
        }

        /**
         * Botón mostrar todos los socios
         */
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            //llamamos al método mostrar socios
            mostrarSocios();
        }

        /**
         * En este método hacemos una select * a la tabla socio donde ordenamos por apellidos y nombre
         */
        private void mostrarSocios()
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                var qCategorias = from s in objBD.socios
                                  orderby s.apellidos, s.nombre
                                  select new { 
                                      s.DNI, 
                                      s.nombre,
                                      s.apellidos,
                                      s.telefono,
                                      s.email
                                  };

                var listaCat = qCategorias.ToList();

                dgvSocios.DataSource = listaCat;

            }
        }
    }
}
