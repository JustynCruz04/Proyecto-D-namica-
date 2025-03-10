using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoDeVenta.clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PuntoDeVenta
{
    public partial class frmClientes : Form
    {
        Cliente db = new Cliente();

        private Cliente cliente;
        ConexionSQLServer sqlCon;

        public frmClientes()
        {
            InitializeComponent();

            Cliente db = new Cliente();

            List<Cliente> clientes = db.ListaClientes();

            dgvClientes.DataSource = clientes;

            //DataGridViewButtonColumn botonModificar = new DataGridViewButtonColumn();
            //botonModificar.Name = "Modificar";
            //botonModificar.HeaderText = "Modificar";
            //botonModificar.Text = "Modificar";
            //botonModificar.UseColumnTextForButtonValue = true;

            //dgvClientes.Columns.Add(botonModificar);

            // Inicializa el servicio con la cadena de conexión a tu base de datos
            string connectionString = "Data Source=.;Initial Catalog=PuntoDeVenta2;Integrated Security=True;"; // Reemplaza con tu cadena de conexión
            cliente = new Cliente(connectionString);
            //LlenarDataGridViewConClientes();

        }

        private void LlenarDataGridViewConClientes()
        {
            try
            {
                // Reutilizar el método DatosQuery para obtener los datos de los clientes
                string query = "SELECT ID, Cedula, Telefono, Nombre, NombreReferencia, TelefonoReferencia FROM Clientes WHERE ID > 2";
                ConexionSQLServer conexionSQL = new ConexionSQLServer();

                // Llenar el DataGridView con los resultados de la consulta
                dgvClientes.DataSource = conexionSQL.DatosQuery(query);

                // Limpiar la selección del DataGridView
                dgvClientes.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de clientes: " + ex.Message);
            }
        }


        private void LimpiarCampos()
        {
            lblID.Text = "";
            txt_cedula.Text = "";
            txt_Telefono.Text = ""; 
            txt_nombre.Text = "";
            txt_nombRef.Text = "";  
            txt_telefRef.Text = ""; 
        }


        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txt_nombreCliente.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblID.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString(); // ID
                txt_cedula.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString(); // Cedula
                txt_Telefono.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString(); // Telefono
                txt_nombre.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString(); // Nombre
                txt_nombRef.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString(); // NombreReferencia
                txt_telefRef.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString(); // TelefonoReferencia



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
                // Se valida si hay campos vacíos antes de continuar
                if (string.IsNullOrWhiteSpace(txt_cedula.Text) ||
                string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_nombRef.Text) ||
                string.IsNullOrWhiteSpace(txt_telefRef.Text) ||
                string.IsNullOrWhiteSpace(txt_Telefono.Text)
                )
                {
                    MessageBox.Show("Por favor, Verifica que todos los campos esten correctos.", "Campos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txt_cedula.Text.Length != 10) // Verificar que la cédula tenga 10 caracteres
                {
                    MessageBox.Show("La cédula debe tener exactamente 10 caracteres.", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres editar estos datos?", "Confirmar adición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        sqlCon = new ConexionSQLServer();
                        sqlCon.ejecutarSP_Actualizar_ClIENTE("EditarCliente", lblID.Text, txt_cedula.Text, txt_Telefono.Text, txt_nombre.Text, txt_nombRef.Text, txt_telefRef.Text);
                        MessageBox.Show("Se ha actualizado cliente correctamente.");
                    }
                }

                dgvClientes.DataSource = db.ListaClientes();
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se valida si hay campos vacíos antes de continuar
                if (string.IsNullOrWhiteSpace(txt_cedula.Text) ||
                string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_nombRef.Text) ||
                string.IsNullOrWhiteSpace(txt_telefRef.Text) ||
                string.IsNullOrWhiteSpace(txt_Telefono.Text)
                )
                {
                    MessageBox.Show("Por favor, Verifica que todos los campos esten correctos.", "Campos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txt_cedula.Text.Length != 10) // Verificar que la cédula tenga 10 caracteres
                {
                    MessageBox.Show("La cédula debe tener exactamente 10 caracteres.", "Cédula inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres agregar estos datos?", "Confirmar adición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        sqlCon = new ConexionSQLServer();
                        sqlCon.ejecutarSP_InsertarCLIENTE("InsertarCliente", txt_cedula.Text, txt_Telefono.Text, txt_nombre.Text, txt_nombRef.Text, txt_telefRef.Text);
                        MessageBox.Show("Se ha ingresado nuevo cliente correctamente.");
                        dgvClientes.DataSource = db.ListaClientes();
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres editar estos datos?", "Confirmar adición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    sqlCon = new ConexionSQLServer();
                    sqlCon.ejecutarSP_Eliminar_ClIENTE("EliminarCliente", lblID.Text);
                    MessageBox.Show("Se ha Eliminado el cliente correctamente.");
                }

                dgvClientes.DataSource = db.ListaClientes();
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_numerocliente1_Click(object sender, EventArgs e)
        {
            string nombreCliente = txt_nombreCliente.Text;
            DataTable ventasTabla = cliente.ObtenerVentaPorCliente(nombreCliente);
            dgv_ventascliente.DataSource = ventasTabla;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            ConexionSQLServer conexionSQL = new ConexionSQLServer();
 
            DataTable resultados = conexionSQL.BuscarEnTabla("Clientes", "ID", "Nombre", txtBuscarCliente.Text);

            dgvClientes.DataSource = resultados;

        }
    }
}