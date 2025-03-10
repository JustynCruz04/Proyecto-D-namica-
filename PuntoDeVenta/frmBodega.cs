using PuntoDeVenta.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PuntoDeVenta
{
    public partial class frmBodega : Form
    {
        Bodega db = new Bodega();

        private Bodega bodega;
        ConexionSQLServer sqlCon;

        public frmBodega()
        {
            InitializeComponent();

            Bodega db = new Bodega();

            List<Bodega> lista = db.ListaBodega();

            dgvBodega.DataSource = lista;

            //DataGridViewButtonColumn botonModificar = new DataGridViewButtonColumn();
            //botonModificar.Name = "Modificar";
            //botonModificar.HeaderText = "Modificar";
            //botonModificar.Text = "Modificar";
            //botonModificar.UseColumnTextForButtonValue = true;

            //dgvBodega.Columns.Add(botonModificar);

            // Inicializa el servicio con la cadena de conexión a tu base de datos
            string connectionString = "Data Source=.;Initial Catalog=PuntoDeVenta2;Integrated Security=True;"; // Reemplaza con tu cadena de conexión
            bodega = new Bodega(connectionString);


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se valida si hay campos vacíos antes de continuar
                if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                    string.IsNullOrWhiteSpace(txt_Ubicacion.Text) ||
                    string.IsNullOrWhiteSpace(txt_EmpleadoID.Text))
                {
                    MessageBox.Show("Por favor, Verifica que todos los campos estén correctos.", "Campos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres agregar esta bodega?", "Confirmar adición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        sqlCon = new ConexionSQLServer();
                        sqlCon.ejecutarSP_InsertarBodega("InsertarBodega", txt_Nombre.Text, txt_Ubicacion.Text, txt_EmpleadoID.Text);
                        MessageBox.Show("Se ha ingresado nueva bodega correctamente.");
                        dgvBodega.DataSource = db.ListaBodega();
                        LimpiarCamposBodega();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se valida si hay campos vacíos antes de continuar
                if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                    string.IsNullOrWhiteSpace(txt_Ubicacion.Text) ||
                    string.IsNullOrWhiteSpace(txt_EmpleadoID.Text))
                {
                    MessageBox.Show("Por favor, Verifica que todos los campos estén correctos.", "Campos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres editar esta bodega?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        sqlCon = new ConexionSQLServer();
                        sqlCon.ejecutarSP_ActualizarBodega("EditarBodega", lblID.Text, txt_Nombre.Text, txt_Ubicacion.Text, txt_EmpleadoID.Text);
                        MessageBox.Show("Se ha actualizado la bodega correctamente.");
                    }
                }

                dgvBodega.DataSource = db.ListaBodega();
                LimpiarCamposBodega();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar esta bodega?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    sqlCon = new ConexionSQLServer();
                    sqlCon.ejecutarSP_EliminarBodega("EliminarBodega", lblID.Text);
                    MessageBox.Show("Se ha eliminado la bodega correctamente.");
                }

                dgvBodega.DataSource = db.ListaBodega();
                LimpiarCamposBodega();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarCamposBodega()
        {
            lblID.Text = "";
            txt_Nombre.Text = "";
            txt_Ubicacion.Text = "";
            txt_EmpleadoID.Text = "";
        }

        private void dgvBodegas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblID.Text = dgvBodega.CurrentRow.Cells[0].Value.ToString();
                txt_Nombre.Text = dgvBodega.CurrentRow.Cells[1].Value.ToString();
                txt_Ubicacion.Text = dgvBodega.CurrentRow.Cells[2].Value.ToString();
                txt_EmpleadoID.Text = dgvBodega.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarBodega_TextChanged(object sender, EventArgs e)
        {
            ConexionSQLServer conexionSQL = new ConexionSQLServer();

            DataTable resultados = conexionSQL.BuscarEnTabla("Bodega", "ID", "Nombre", txtBuscarBodega.Text);

            dgvBodega.DataSource = resultados;
        }
    }
}
