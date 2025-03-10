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
    public partial class frmBuscarProducto : Form
    {
        public frmBuscarProducto()
        {
            InitializeComponent();
        }
        public Productos ProductoSeleccionado { get; set; }
        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ProductoSeleccionado = new Productos
                {
                    ID = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["ID"].Value),
                    Nombre = dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(),
                    CodigoBarra = dgvProductos.Rows[e.RowIndex].Cells["CodigoBarra"].Value.ToString(),
                    PrecioCompra = Convert.ToDecimal(dgvProductos.Rows[e.RowIndex].Cells["PrecioCompra"].Value),
                    PrecioVenta = Convert.ToDecimal(dgvProductos.Rows[e.RowIndex].Cells["PrecioVenta"].Value),
                    Existencia = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Existencia"].Value),
                    StookMinimo = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["StockMinimo"].Value),
                    ProveedorID = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["ProveedorID"].Value),
                    BodegaID = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["BodegaID"].Value),
                    IVA = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["IVA"].Value)
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        public void CargarProductos()
        {
            // Cadena de conexión corregida
            string connectionString = "Server=localhost;Database=PuntoDeVenta2;Integrated Security=True;";

            // Consulta SQL para seleccionar solo productos disponibles y que no están en el rango de fechas
            string query = @"SELECT ID, Nombre, CodigoBarra, PrecioCompra, PrecioVenta, Existencia, StockMinimo, ProveedorID, BodegaID, I.Porcentaje as IVA 
                    FROM Productos as P
                    JOIN tbIVA as I ON P.CodIVa = I.CodIVA
                    WHERE Estado = 1 -- Solo productos disponibles
                    AND (inicio_precompra IS NULL OR fin_precompra IS NULL OR GETDATE() < inicio_precompra OR GETDATE() > fin_precompra)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar los datos al DataGridView
                    dgvProductos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos: " + ex.Message);
                }
            }
        }


        public void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }

        }
    }
}
