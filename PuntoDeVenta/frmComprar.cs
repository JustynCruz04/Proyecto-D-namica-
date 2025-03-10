using PuntoDeVenta.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class frmComprar : Form
    {
        public frmComprar()
        {
            InitializeComponent();

            Compras db = new Compras();
            this.Load += new System.EventHandler(this.frmComprar_Load);
            List<Compras> lista = db.ListaCompras();

            dgvCompras.DataSource = lista;

        }

        private void frmComprar_Load(object sender, EventArgs e)
        {
            // Aquí puedes configurar los TextBox como de solo lectura
            //txtProductoID.ReadOnly = true;
            //txtPrecio.ReadOnly = true;
            //txtProveedor.ReadOnly = true;
            //txtFecha.ReadOnly = true;

            // Dejar txtCantidades editable
            txtCantidades.ReadOnly = false;
        }


        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCompras.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox utilizando índices de columnas
                txtProductoID.Text = row.Cells[0].Value?.ToString(); // Suponiendo que la columna ID es la primera
                txtProveedor.Text = row.Cells[1].Value?.ToString(); // NombreProveedor
                txtPrecio.Text = row.Cells[4].Value?.ToString(); // Total
                txtFecha.Text = row.Cells[3].Value?.ToString(); // Fecha
                                                                // Agrega más celdas según tu diseño
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos necesarios no estén vacíos
                if (string.IsNullOrEmpty(txtProductoID.Text) || string.IsNullOrEmpty(txtCantidades.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtProveedor.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar.");
                    return;
                }

                // Validar que los campos tengan el formato correcto
                if (!int.TryParse(txtProductoID.Text, out int productoID))
                {
                    MessageBox.Show("El ProductoID debe ser un número válido.");
                    return;
                }

                if (!int.TryParse(txtCantidades.Text, out int cantidad))
                {
                    MessageBox.Show("La cantidad debe ser un número entero válido.");
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("El precio debe ser un número decimal válido.");
                    return;
                }

                // Validar si el ProductoID existe en la tabla Productos
                using (SqlConnection connection = ConexionSQLServer.abrirConexion())
                {
                    string queryProducto = "SELECT COUNT(*) FROM Productos WHERE ID = @ProductoID";
                    using (SqlCommand cmdProducto = new SqlCommand(queryProducto, connection))
                    {
                        cmdProducto.Parameters.AddWithValue("@ProductoID", productoID);
                        int productoExiste = Convert.ToInt32(cmdProducto.ExecuteScalar());

                        if (productoExiste == 0)
                        {
                            MessageBox.Show("El ProductoID ingresado no existe.");
                            return;
                        }
                    }
                }

                // Buscar el ProveedorID basado en el nombre del proveedor
                int proveedorID = 0;
                using (SqlConnection connection = ConexionSQLServer.abrirConexion())
                {
                    // Asegúrate de usar el nombre correcto de la columna que contiene el nombre del proveedor en la tabla Proveedores
                    string queryProveedor = "SELECT ID FROM Proveedores WHERE Nombre = @Nombre";
                    using (SqlCommand cmdProveedor = new SqlCommand(queryProveedor, connection))
                    {
                        cmdProveedor.Parameters.AddWithValue("@Nombre", txtProveedor.Text);
                        object result = cmdProveedor.ExecuteScalar();

                        if (result != null)
                        {
                            proveedorID = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el Proveedor. Por favor, ingrese un nombre válido.");
                            return;
                        }
                    }
                }

                // Capturar la fecha
                if (!DateTime.TryParse(txtFecha.Text, out DateTime fecha))
                {
                    MessageBox.Show("Por favor, ingrese una fecha válida.");
                    return;
                }

                // Calcular el total de la compra
                decimal total = cantidad * precio;
                int empleadoID = 1; // Ajusta este valor según sea necesario??????

                // Usar la clase de conexión para abrir la conexión y ejecutar las consultas
                using (SqlConnection connection = ConexionSQLServer.abrirConexion())
                {
                    // Comando SQL para insertar en la tabla Compras
                    string queryCompras = "INSERT INTO Compras (ProveedorID, Fecha, Total, EmpleadoID) VALUES (@ProveedorID, @Fecha, @Total, @EmpleadoID)";
                    using (SqlCommand cmdCompras = new SqlCommand(queryCompras, connection))
                    {
                        cmdCompras.Parameters.AddWithValue("@ProveedorID", proveedorID);
                        cmdCompras.Parameters.AddWithValue("@Fecha", fecha);
                        cmdCompras.Parameters.AddWithValue("@Total", total);
                        cmdCompras.Parameters.AddWithValue("@EmpleadoID", empleadoID);

                        cmdCompras.ExecuteNonQuery();
                    }

                    // Obtener el ID de la compra recién creada
                    string queryCompraID = "SELECT MAX(ID) FROM Compras";
                    int compraID = Convert.ToInt32(new SqlCommand(queryCompraID, connection).ExecuteScalar());

                    // Comando SQL para insertar en DetalleCompra
                    string queryDetalleCompra = "INSERT INTO DetalleCompra (CompraID, ProductoID, Cantidad, Precio) VALUES (@CompraID, @ProductoID, @Cantidad, @Precio)";
                    using (SqlCommand cmdDetalleCompra = new SqlCommand(queryDetalleCompra, connection))
                    {
                        cmdDetalleCompra.Parameters.AddWithValue("@CompraID", compraID);
                        cmdDetalleCompra.Parameters.AddWithValue("@ProductoID", productoID);
                        cmdDetalleCompra.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmdDetalleCompra.Parameters.AddWithValue("@Precio", precio);

                        cmdDetalleCompra.ExecuteNonQuery();
                    }

                    MessageBox.Show("Compra agregada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la compra: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarProductos()
        {
            // Cambiar Productos a Compras si la clase es diferente
            dgvCompras.DataSource = new Compras().ListaCompras(); // Asumimos que Compras tiene el método ListaCompras()
        }

        private void LimpiarCampos()
        {
            // Limpiar todos los campos
            txtProductoID.Clear();
            txtProveedor.Clear();
            txtPrecio.Clear();
            txtCantidades.Clear();
            txtFecha.Clear();
        }

        private void txtProductoID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
