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
    public partial class frmProveedor : Form
    {
        Proveedor db = new Proveedor();

        private Proveedor proveedor;

        ConexionSQLServer sqlCon;

        public frmProveedor()
        {
            InitializeComponent();

            Proveedor db = new Proveedor();

            List<Proveedor> clientes = db.ListaProveedorees();

            dgvProveedores.DataSource = clientes;

            //DataGridViewButtonColumn botonModificar = new DataGridViewButtonColumn();
            //botonModificar.Name = "Modificar";
            //botonModificar.HeaderText = "Modificar";
            //botonModificar.Text = "Modificar";
            //botonModificar.UseColumnTextForButtonValue = true;

            //dgvProveedores.Columns.Add(botonModificar);

            string connectionString = "Data Source=.;Initial Catalog=PuntoDeVenta2;Integrated Security=True;"; // Reemplaza con tu cadena de conexión
            proveedor = new Proveedor(connectionString);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay campos vacíos antes de continuar
                if (string.IsNullOrWhiteSpace(txt_nombreProveedor.Text) ||
                string.IsNullOrWhiteSpace(txt_TelefonoProveedor.Text) ||
                string.IsNullOrWhiteSpace(txt_direccionProveedor.Text))
                {
                    MessageBox.Show("Por favor, verifica que todos los campos estén correctos.", "Campos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres agregar estos datos?", "Confirmar adición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        sqlCon = new ConexionSQLServer();
                        sqlCon.ejecutarSP_InsertarProveedor("InsertarProveedor", txt_nombreProveedor.Text, txt_TelefonoProveedor.Text, txt_direccionProveedor.Text);
                        MessageBox.Show("Se ha ingresado nuevo proveedor correctamente.");
                        dgvProveedores.DataSource = db.ListaProveedorees();
                        LimpiarCamposProveedor();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay campos vacíos antes de continuar
                if (string.IsNullOrWhiteSpace(txt_nombreProveedor.Text) ||
                string.IsNullOrWhiteSpace(txt_TelefonoProveedor.Text) ||
                string.IsNullOrWhiteSpace(txt_direccionProveedor.Text))
                {
                    MessageBox.Show("Por favor, verifica que todos los campos estén correctos.", "Campos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres editar estos datos?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        sqlCon = new ConexionSQLServer();
                        sqlCon.ejecutarSP_ActualizarProveedor("EditarProveedor", lblIDProveedor.Text, txt_nombreProveedor.Text, txt_TelefonoProveedor.Text, txt_direccionProveedor.Text);
                        MessageBox.Show("Se ha actualizado el proveedor correctamente.");
                        dgvProveedores.DataSource = db.ListaProveedorees();
                        LimpiarCamposProveedor();
                    }
                }
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
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar estos datos?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    sqlCon = new ConexionSQLServer();
                    sqlCon.ejecutarSP_EliminarProveedor("EliminarProveedor", lblIDProveedor.Text);
                    MessageBox.Show("Se ha eliminado el proveedor correctamente.");
                    dgvProveedores.DataSource = db.ListaProveedorees();
                    LimpiarCamposProveedor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblIDProveedor.Text = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
                txt_nombreProveedor.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
                txt_TelefonoProveedor.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
                txt_direccionProveedor.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCamposProveedor()
        {
            lblIDProveedor.Text = "";
            txt_nombreProveedor.Text = "";
            txt_TelefonoProveedor.Text = "";
            txt_direccionProveedor.Text = "";
        }

        private void txt_nombreProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            ConexionSQLServer conexionSQL = new ConexionSQLServer();

            DataTable resultados = conexionSQL.BuscarEnTabla("Proveedores", "ID", "Nombre", txtBuscarProveedor.Text);

            dgvProveedores.DataSource = resultados;
        }
    }
}
