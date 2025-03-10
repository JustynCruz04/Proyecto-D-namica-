using PuntoDeVenta.clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class frmListaClientes : Form
    {
        // Constructor
        public frmListaClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                string connectionString = "Data Source=.;Initial Catalog=PuntoDeVenta2;Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT ID, Cedula, Telefono, Nombre, NombreReferencia, TelefonoReferencia FROM Clientes \r\nwhere ID>2";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvClientes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BuscarCliente cliente = new BuscarCliente
                {
                    ID = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["ID"].Value),
                    Cedula = dgvClientes.Rows[e.RowIndex].Cells["Cedula"].Value.ToString(),
                    Telefono = dgvClientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString(),
                    Nombre = dgvClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(),
                    NombreReferencia = dgvClientes.Rows[e.RowIndex].Cells["NombreReferencia"].Value.ToString(),
                    TelefonoReferencia = dgvClientes.Rows[e.RowIndex].Cells["TelefonoReferencia"].Value.ToString()
                };
                ClienteSeleccionado = cliente;

                this.Close();
            }
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.ClearSelection();
        }

        public BuscarCliente ClienteSeleccionado { get; set; }
    }
}
