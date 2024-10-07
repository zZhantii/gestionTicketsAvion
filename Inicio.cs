using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vuelos
{
    public partial class Inicio : Form
    {
        //Creamos una Lista para guardar todos los tickets de avion disponibles en la base de datos
        private List<Vuelo> mVuelos;
        private VuelosConsultas mVuelosConsultas;
        private Vuelo mVuelo;
        public Inicio()
        {
            InitializeComponent();
            mVuelos = new List<Vuelo>();
            mVuelosConsultas = new VuelosConsultas();
            mVuelo = new Vuelo();
            //Constructor
            cargarVuelos();
        }

        //Mostrar y Buscar Datos
        private void cargarVuelos(string filtro = "")
        {
            //Limpia la tabla
            dgvVuelos.Rows.Clear();
            //Actualiza la tabla
            dgvVuelos.Refresh();
            //Limpia la lista
            mVuelos.Clear();
            //Llenamos la tabla con datos
            mVuelos = mVuelosConsultas.getVuelos(filtro);

            //agregamos la informacion a la tabla
            for (int i = 0; i < mVuelos.Count(); i++)
            {
                dgvVuelos.RowTemplate.Height = 50;
                dgvVuelos.Rows.Add(
                    mVuelos[i].Vuelo_ID,
                    mVuelos[i].Nombre,
                    mVuelos[i].Apellido,
                    mVuelos[i].Origen,
                    mVuelos[i].Destino,
                    mVuelos[i].Asiento,
                    mVuelos[i].Fila,
                    mVuelos[i].Fecha_Ida,
                    mVuelos[i].Fecha_Vuelta
                    );
            }
        }
     
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            cargarVuelos(txtNombre.Text.Trim());
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            cargarVuelos(txtApellido.Text.Trim());
        }

        private void txtOrigen_TextChanged(object sender, EventArgs e)
        {
            cargarVuelos(txtOrigen.Text.Trim());
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            cargarVuelos(txtDestino.Text.Trim());
        }

        //Crear datos
        //Comprueba los campos
        private DateTime fecha = DateTime.MinValue;
        private bool datosCorrectos()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo imcompleto, añade un nombre");
                return false;
            }
            else if (txtApellido.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo imcompleto, añade un apellido");
                return false;
            }
            else if (txtOrigen.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo imcompleto, añade un origen");
                return false;
            }
            else if (txtDestino.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo imcompleto, añade un destino");
                return false;
            }



            return true;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            cargarDatosVuelo();
            //Me da error en el mVuelo descubrir el porque
            if (mVuelosConsultas.agregarVuelos(mVuelo))
            {
                MessageBox.Show("Vuelo agregado correctamente");
                cargarVuelos();
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtOrigen.Text = "";
            txtDestino.Text = "";
            txtVuelo_ID.Text = "";
        }

        public void cargarDatosVuelo()
        {
            mVuelo.Vuelo_ID = getVueloIfExist();
            mVuelo.Nombre = txtNombre.Text.Trim();
            mVuelo.Apellido = txtApellido.Text.Trim();
            mVuelo.Origen = txtOrigen.Text.Trim();
            mVuelo.Destino = txtDestino.Text.Trim();
        }

        private int getVueloIfExist()
        {
            if (txtVuelo_ID.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtVuelo_ID.Text.Trim(), out int vuelo))
                {
                    return vuelo;
                }
                else return -1;
            }
            else return -1;
        }



        //Update
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            cargarDatosVuelo();
            //Me da error en el mVuelo descubrir el porque
            if (mVuelosConsultas.modificarVuelos(mVuelo))
            {
                MessageBox.Show("Vuelo modificado correctamente");
                cargarVuelos();
                LimpiarCampos();
            }
        }

        //Delete
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (getVueloIfExist() == -1)
            {
                return;
            }
            cargarDatosVuelo();

            if (MessageBox.Show("Seguro que quieres eliminar el vuelo?", "Eliminar vuelo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatosVuelo();

                if (mVuelosConsultas.eliminarProducto(mVuelo))
                {
                    MessageBox.Show("Vuelo eliminado correctamente");
                    cargarVuelos();
                    LimpiarCampos();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvVuelos.Rows[e.RowIndex];
            txtVuelo_ID.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
            txtApellido.Text = Convert.ToString(fila.Cells["Apellido"].Value);
            txtOrigen.Text = Convert.ToString(fila.Cells["Origen"].Value);
            txtDestino.Text = Convert.ToString(fila.Cells["Destino"].Value);
            dtpFecha_Ida.Value = Convert.ToDateTime(fila.Cells[7].Value);
            dtpFecha_Ida.Value = Convert.ToDateTime(fila.Cells[8].Value);
        }
    }
}
