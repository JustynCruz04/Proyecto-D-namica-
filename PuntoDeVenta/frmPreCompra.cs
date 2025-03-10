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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace PuntoDeVenta
{
    public partial class frmPreCompra : Form
    {
        private frmPrincipal frm;
        public frmPreCompra(frmPrincipal existefrm)
        {
            InitializeComponent();
            frm = existefrm;

        }

        public void CargarProductos()
        {
            // Cadena de conexión corregida
            string connectionString = "Server=localhost;Database=PuntoDeVenta2;Integrated Security=True;";

            // Consulta SQL para seleccionar productos que no están en el rango de fechas
            string query = @"SELECT ID, Nombre, PrecioVenta, Existencia, StockMinimo, I.Porcentaje as IVA , inicio_precompra , fin_precompra 
                                FROM Productos as P
                                join tbIVA as I on P.CodIVa=I.CodIVA
                                WHERE (GETDATE() > inicio_precompra OR GETDATE() < fin_precompra)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar los datos al DataGridView
                    dgvPreCompra.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos: " + ex.Message);
                }
            }
        }

        private void frmPreCompra_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar productos en el DataGridView
                CargarProductos();

                // Configuración del panel
                pnPreCompra.Size = new Size(420, 400);
                pnPreCompra.Left = (this.Size.Width - pnPreCompra.Width) / 2;
                pnPreCompra.Top = (this.Size.Height - pnPreCompra.Height) / 2;
                pnPreCompra.Visible = false;

                // Cargar las cajas disponibles
                Caja db = new Caja();
                List<Caja> listaingreso = db.ListaCajaIngreso();

                // Verificar si hay cajas disponibles
                if (listaingreso != null && listaingreso.Count > 0)
                {
                    cbCaja.DataSource = listaingreso;
                    cbCaja.DisplayMember = "Descripcion";
                    cbCaja.ValueMember = "ID";

                    // Verifica si cbCaja tiene elementos antes de asignar el SelectedIndex
                    if (cbCaja.Items.Count > 0)
                    {
                        cbCaja.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron cajas disponibles.");
                }

                // Verificar si cbTipoPago tiene elementos antes de asignar el SelectedIndex
                if (cbTipoPago.Items.Count > 0)
                {
                    cbTipoPago.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }


        public frmListaClientes listaClientes;
        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            listaClientes = new frmListaClientes();
            listaClientes.ShowDialog();
            if (listaClientes.ClienteSeleccionado != null)
            {
                lbCliente.Text = listaClientes.ClienteSeleccionado.Nombre;
                lbCliente.ForeColor = Color.Black;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lbCliente.Text = "Seleccione el cliente";
            lbCliente.ForeColor = Color.Red;
            pnPreCompra.Visible = false;
            dgvPreCompra.Enabled = true;
        }

        private void pnPreCompra_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(45, 84, 99);
            int borderWidth = 1;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.pnPreCompra.Width - 1, this.pnPreCompra.Height - 1));
            }
        }

        int idProducto = 0;

        private void dgvPreCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvPreCompra.Enabled = false;
                pnPreCompra.Visible = true;
                lbProducto.Text = dgvPreCompra.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                lbMonto.Text = dgvPreCompra.Rows[e.RowIndex].Cells["PrecioVenta"].Value.ToString();
                lbRestante.Text = dgvPreCompra.Rows[e.RowIndex].Cells["PrecioVenta"].Value.ToString();
                idProducto = (int)dgvPreCompra.Rows[e.RowIndex].Cells["ID"].Value;
            }
        }

        public void soloDecimal(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && txtAnticipo.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void txtAnticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDecimal(e);
        }

        private void txtAnticipo_TextChanged(object sender, EventArgs e)
        {
            string txtActual = txtAnticipo.Text;
            if (txtActual != "")
            {
                if (txtActual.EndsWith(","))
                {
                    lbRestante.Text = ((decimal.Parse(lbMonto.Text)) - (decimal.Parse(txtActual + "00"))).ToString("N2");
                }
                else
                {
                    lbRestante.Text = ((decimal.Parse(lbMonto.Text)) - (decimal.Parse(txtActual))).ToString("N2");
                }
            }
            else
            {
                lbRestante.Text = lbMonto.Text;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lbCliente.Text != "Seleccione el cliente" && txtAnticipo.Text != "")
            {
                ConexionSQLServer sqlCon;
                sqlCon = new ConexionSQLServer();
                sqlCon.EjecutarSP_GuardarPrecompra(listaClientes.ClienteSeleccionado.ID, idProducto, 1, 1, decimal.Parse(txtAnticipo.Text), decimal.Parse(lbMonto.Text), (int)cbCaja.SelectedValue, cbTipoPago.Text);
                lbCliente.Text = "Seleccione el cliente";
                lbCliente.ForeColor = Color.Red;
                pnPreCompra.Visible = false;
                dgvPreCompra.Enabled = true;
                MessageBox.Show("Se ha realizado la compra correctamente.");
            }
            else
            {
                MessageBox.Show("Llene los campos necesarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPreRealizadas_Click(object sender, EventArgs e)
        {
            frm.IniciarPreCompraRealizadas();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
