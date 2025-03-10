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
    public partial class frmPreCompraRealizadas : Form
    {
        private frmPrincipal frm;
        public frmPreCompraRealizadas(frmPrincipal existefrm)
        {
            InitializeComponent();
            frm = existefrm;
        }

        private void btnPreCompra_Click(object sender, EventArgs e)
        {
            frm.IniciarPreCompra();
        }

        private void frmPreCompraRealizadas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPreCompras();
                //pnPrecompra
                pnPreCompra.Size = new Size(420, 400);
                pnPreCompra.Left = (this.Size.Width - pnPreCompra.Width) / 2;
                pnPreCompra.Top = (this.Size.Height - pnPreCompra.Height) / 2;
                pnPreCompra.Visible = false;

                //pnPagos
                pnPagos.Size = new Size(800, 400);
                pnPagos.Left = (this.Size.Width - pnPagos.Width) / 2;
                pnPagos.Top = (this.Size.Height - pnPagos.Height) / 2;
                pnPagos.Visible = false;

                //dgvPagos
                dgvPagos.Size = new Size(780, 200);
                dgvPagos.Left = (pnPagos.Size.Width - dgvPagos.Width) / 2;

                Caja db = new Caja();
                List<Caja> listaingreso = db.ListaCajaIngreso();

                cbCaja.DataSource = listaingreso;
                cbCaja.DisplayMember = "Descripcion";
                cbCaja.ValueMember = "ID";
                cbCaja.SelectedIndex = 0;

                cbTipoPago.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        public void CargarPreCompras()
        {
            // Cadena de conexión corregida
            string connectionString = "Server=localhost;Database=PuntoDeVenta2;Integrated Security=True;";

            // Consulta SQL para seleccionar productos que no están en el rango de fechas
            string query = @"
                select p.ID, pd.Nombre as Producto, c.Nombre as Cliente, p.fechaPrecompra, p.totalPrecompra, p.totalPrecompra - sum(pp.montoPago) as saldoPendiente, 
                CASE 
                    WHEN p.totalPrecompra -  sum(pp.montoPago) > 0 THEN 'Pendiente'
                    ELSE 'Completado'
                END as EstadoPago
                from PreCompra p 
                inner join PagosPrecompra pp on p.ID=pp.PrecompraID 
                inner join Productos pd on pd.ID=p.ProductoID 
	            inner join Clientes c on c.ID=p.ClienteID
                group by p.ID, pd.Nombre, c.Nombre,p.fechaPrecompra, p.totalPrecompra";

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

                    // Agregar boton de accion
                    DataGridViewButtonColumn btnPagar = new DataGridViewButtonColumn();
                    btnPagar.Name = "Accion";
                    btnPagar.HeaderText = "Acción";
                    btnPagar.Text = "Pagar";
                    btnPagar.UseColumnTextForButtonValue = true;
                    dgvPreCompra.Columns.Add(btnPagar);

                    // Agregar boton de accion
                    DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                    btnVer.Name = "Ver";
                    btnVer.HeaderText = "Ver";
                    btnVer.Text = "Ver Pagos";
                    btnVer.UseColumnTextForButtonValue = true;
                    dgvPreCompra.Columns.Add(btnVer);

                    dgvPreCompra.CellFormatting += (s, e) =>
                    {
                        if (e.ColumnIndex == dgvPreCompra.Columns["Accion"].Index)
                        {
                            string estadoPago = dgvPreCompra.Rows[e.RowIndex].Cells["EstadoPago"].Value.ToString();
                            if (estadoPago == "Completado")
                            {
                                e.Value = "Completado";
                                e.CellStyle.BackColor = Color.Green;
                                e.CellStyle.ForeColor = Color.Black;
                            }
                            else
                            {
                                e.Value = "Pagar";
                                e.CellStyle.BackColor = Color.Red;
                                e.CellStyle.ForeColor = Color.White;
                            }
                        }
                    };

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos: " + ex.Message);
                }
            }
        }

        public void CargarPagosPreCompras(int PreCompraID)
        {
            // Cadena de conexión corregida
            string connectionString = "Server=localhost;Database=PuntoDeVenta2;Integrated Security=True;";

            // Consulta SQL para seleccionar productos que no están en el rango de fechas
            string query = "select * from PagosPrecompra where PrecompraID = " + PreCompraID;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar los datos al DataGridView
                    dgvPagos.DataSource = dataTable;



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los productos: " + ex.Message);
                }
            }
        }

        int idPreCompra = 0;

        private void dgvPreCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvPreCompra.Columns[e.ColumnIndex].Name == "Accion" && dgvPreCompra.Rows[e.RowIndex].Cells["EstadoPago"].Value.ToString() == "Pendiente")
                {
                    pnPreCompra.Visible = true;
                    dgvPreCompra.Enabled = false;
                    idPreCompra = (int)dgvPreCompra.Rows[e.RowIndex].Cells["ID"].Value;
                    lbCliente.Text = dgvPreCompra.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                    lbProducto.Text = dgvPreCompra.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                    lbTotal.Text = dgvPreCompra.Rows[e.RowIndex].Cells["saldoPendiente"].Value.ToString();
                    lbRestante.Text = dgvPreCompra.Rows[e.RowIndex].Cells["saldoPendiente"].Value.ToString();
                }
                else if (dgvPreCompra.Columns[e.ColumnIndex].Name == "Ver")
                {
                    pnPagos.Visible = true;
                    dgvPreCompra.Enabled = false;
                    lbPagoCliente.Text = dgvPreCompra.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                    lbPagoProducto.Text = dgvPreCompra.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                    CargarPagosPreCompras((int)dgvPreCompra.Rows[e.RowIndex].Cells["ID"].Value);
                }
            }
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

        private void txtAnticipo_TextChanged(object sender, EventArgs e)
        {
            string txtActual = txtAnticipo.Text;
            if (txtActual != "")
            {
                if (txtActual.EndsWith(","))
                {
                    lbRestante.Text = ((decimal.Parse(lbTotal.Text)) - (decimal.Parse(txtActual + "00"))).ToString("N2");
                }
                else
                {
                    lbRestante.Text = ((decimal.Parse(lbTotal.Text)) - (decimal.Parse(txtActual))).ToString("N2");
                }
            }
            else
            {
                lbRestante.Text = lbTotal.Text;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnPreCompra.Visible = false;
            dgvPreCompra.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtAnticipo.Text != "")
            {
                ConexionSQLServer sqlCon;
                sqlCon = new ConexionSQLServer();
                sqlCon.EjecutarSP_GuardarPagosPrecompra(idPreCompra, (int)cbCaja.SelectedValue, decimal.Parse(txtAnticipo.Text), cbTipoPago.Text);
                pnPreCompra.Visible = false;
                dgvPreCompra.Enabled = true;
                MessageBox.Show("Se ha realizado el pago correctamente.");
            }
            else
            {
                MessageBox.Show("Llene los campos necesarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarPagos_Click(object sender, EventArgs e)
        {
            pnPagos.Visible = false;
            dgvPreCompra.Enabled = true;
        }

        private void pnPagos_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(45, 84, 99);
            int borderWidth = 1;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.pnPagos.Width - 1, this.pnPagos.Height - 1));
            }
        }

        private void dgvPreCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
