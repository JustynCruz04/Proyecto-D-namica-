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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PuntoDeVenta
{
    public partial class frmVender : Form
    {
        public frmVender()
        {
            InitializeComponent();

            Productos db = new Productos();
            this.Load += new System.EventHandler(this.frmVender_Load);
            List<Productos.ProductosVenta> lista = db.ListaProductosVenta();

            pnApartado.Size = new Size(400, 550);
            pnApartado.Left = (this.Size.Width - pnApartado.Width) / 2;
            pnApartado.Top = (this.Size.Height - pnApartado.Height) / 2;
            pnApartado.Visible = false;


        }

        public void Apartar()
        {
            pnApartado.Visible = false;
        }
        int idEmpleado = 1;
        private void frmVender_Load(object sender, EventArgs e)
        {
            txtNombreVentas.ReadOnly = true;
            txtIdentificacionVentas.ReadOnly = true;
            txtDescripcionProducto.ReadOnly = true;
            txtPrecioUnitario.ReadOnly = true;
            txtStock.ReadOnly = true;
            txtSubtotal.ReadOnly = true;
            txtTotal.ReadOnly = true;
            dgvDetalledeventas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalledeventas.MultiSelect = false; // Permite seleccionar solo una fila a la vez
        }
        int idCliente;
        public frmListaClientes listaClientes;
        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            listaClientes = new frmListaClientes();
            listaClientes.ShowDialog();
            if (listaClientes.ClienteSeleccionado != null)
            {
                txtNombreVentas.Text = listaClientes.ClienteSeleccionado.Nombre;
                txtIdentificacionVentas.Text = listaClientes.ClienteSeleccionado.Cedula;
                idCliente = listaClientes.ClienteSeleccionado.ID;
                verifi = false;
                checkBox1.Checked = false;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        bool verifi = true;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtNombreVentas.Text = "Consumidor Final";
                txtIdentificacionVentas.Text = "9999999999";
                txtNombreVentas.Enabled = false;
                txtIdentificacionVentas.Enabled = false;
                idCliente = 2;
            }
            else if(verifi)
            {
                txtNombreVentas.Text = "";
                txtIdentificacionVentas.Text = "";
                txtNombreVentas.Enabled = true;
                txtIdentificacionVentas.Enabled = true;
                verifi = false;
            }
           
        }

        private void txtNombreVentas_TextChanged(object sender, EventArgs e)
        {

        }
        public Productos productoSeleccionado;
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

            using (frmBuscarProducto buscarProductoForm = new frmBuscarProducto())
            {
                if (buscarProductoForm.ShowDialog() == DialogResult.OK)
                {
                    productoSeleccionado = buscarProductoForm.ProductoSeleccionado;

                    if (productoSeleccionado != null)
                    {
                        txtDescripcionProducto.Text = productoSeleccionado.Nombre;
                        txtPrecioUnitario.Text = productoSeleccionado.PrecioVenta.ToString();
                        txtStock.Text = productoSeleccionado.Existencia.ToString();
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarProductoVenta_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetalleVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado != null)
            {
                int cantidadSeleccionada;
                if (int.TryParse(txtCantidadProducto.Text, out cantidadSeleccionada) && cantidadSeleccionada > 0)
                {
                    if (cantidadSeleccionada <= productoSeleccionado.Existencia)
                    {
                        dgvDetalledeventas.Rows.Add(
                            productoSeleccionado.ID,
                            productoSeleccionado.Nombre,
                            productoSeleccionado.CodigoBarra,
                            productoSeleccionado.PrecioVenta,
                            cantidadSeleccionada,
                            productoSeleccionado.Existencia,
                            productoSeleccionado.IVA
                        );

                        int nuevaFilaIndex = dgvDetalledeventas.Rows.Count - 1;
                        dgvDetalledeventas.ClearSelection();
                        dgvDetalledeventas.Rows[nuevaFilaIndex].Selected = true;
                        dgvDetalledeventas.CurrentCell = dgvDetalledeventas.Rows[nuevaFilaIndex].Cells[0];

                        CalcularTotales();

                        btnApartar.Enabled = true;

                        txtDescripcionProducto.Clear();
                        txtPrecioUnitario.Clear();
                        txtStock.Clear();
                        txtCantidadProducto.Clear();

                        productoSeleccionado = null;


                    }
                    else
                    {
                        MessageBox.Show($"No puedes vender más de {productoSeleccionado.Existencia} unidades de este producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingresa una cantidad válida mayor a 0 antes de agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalcularTotales()
        {
            decimal subtotal = 0;
            decimal totalIVA = 0;

            foreach (DataGridViewRow fila in dgvDetalledeventas.Rows)
            {
                decimal precioVenta = Convert.ToDecimal(fila.Cells["PrecioVenta"].Value);
                int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                decimal porcentajeIVA = Convert.ToDecimal(fila.Cells["IVA"].Value) / 100;

                // Sumar al subtotal
                subtotal += precioVenta * cantidad;

                // Calcular y sumar el IVA de este producto
                totalIVA += (precioVenta * cantidad) * porcentajeIVA;
            }

            // El total es la suma del subtotal y del IVA
            decimal total = subtotal + totalIVA;

            // Mostramos los valores en los TextBox correspondientes
            txtSubtotal.Text = subtotal.ToString("N2");  // Subtotal sin IVA
            txtTotal.Text = total.ToString("N2");  // Total con IVA
        }


        private void numIVA_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void dgvDetalledeventas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
        }

        private void btnDecrementar_Click(object sender, EventArgs e)
        {
        }


        private void dgvDetalledeventas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetalledeventas.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvDetalledeventas.SelectedRows[0];
                int cantidadActual = Convert.ToInt32(filaSeleccionada.Cells["Cantidad"].Value);
                txtCantidadProducto.Text = cantidadActual.ToString();
            }
        }

        private void numIVA_ValueChanged_1(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void numIVA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalcularTotales();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalledeventas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDetalledeventas.SelectedRows)
                {
                    dgvDetalledeventas.Rows.Remove(row);
                }

                CalcularTotales();

                dgvDetalledeventas.ClearSelection();

                if (dgvDetalledeventas.Rows.Count > 0)
                {
                    dgvDetalledeventas.Rows[0].Selected = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para quitar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvDetalledeventas.Rows.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
            txtNombreVentas.Clear();
            txtIdentificacionVentas.Clear();
            txtDescripcionProducto.Clear();
            txtPrecioUnitario.Clear();
            txtStock.Clear();
            txtCantidadProducto.Clear();
            productoSeleccionado = null;
        }
        decimal Iva = decimal.Zero;

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetalledeventas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay productos para vender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (decimal.Parse(txtTotal.Text) == 0)
                {
                    MessageBox.Show("El total de la venta no puede ser 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtNombreVentas.Text) && !checkBox1.Checked)
                {
                    MessageBox.Show("Debe seleccionar un cliente o marcar la opción de Consumidor final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                decimal total = Convert.ToDecimal(txtTotal.Text);
                decimal subtotal = decimal.Parse(txtSubtotal.Text);

                ConexionSQLServer con = new ConexionSQLServer();
                bool resultado = con.RegistrarVentaConDetalles(idCliente, total, idEmpleado, dgvDetalledeventas, out idFactura);










                // Imprimir la factura
                ImprimirFactura(); // Método ya existente

                // Limpiar el formulario después de la venta y la impresión
                btnCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int GuardarVentaCompleta()
        {
            int ventaID = 0;
            try
            {
                ConexionSQLServer conexionSQL = new ConexionSQLServer();
                conexionSQL.abrirConexion1();
                SqlTransaction transaction = conexionSQL.conexion.BeginTransaction();
                try
                {
                    SqlCommand cmdVenta = new SqlCommand("sp_GuardarVenta", conexionSQL.conexion, transaction);
                    cmdVenta.CommandType = CommandType.StoredProcedure;
                    cmdVenta.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    if (checkBox1.Checked)
                    {
                        cmdVenta.Parameters.AddWithValue("@ClienteID", DBNull.Value);
                    }
                    else
                    {
                        cmdVenta.Parameters.AddWithValue("@ClienteID", listaClientes.ClienteSeleccionado.ID);
                    }
                    cmdVenta.Parameters.AddWithValue("@Total", decimal.Parse(txtTotal.Text));
                    cmdVenta.Parameters.AddWithValue("@EmpleadoID", 1);
                    SqlParameter paramVentaID = new SqlParameter("@VentaID", SqlDbType.Int);
                    paramVentaID.Direction = ParameterDirection.Output;
                    cmdVenta.Parameters.Add(paramVentaID);
                    cmdVenta.ExecuteNonQuery();
                    ventaID = Convert.ToInt32(paramVentaID.Value);
                    foreach (DataGridViewRow row in dgvDetalledeventas.Rows)
                    {
                        int productoID = Convert.ToInt32(row.Cells["ID"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        SqlCommand cmdDetalle = new SqlCommand("sp_GuardarDetalleVenta", conexionSQL.conexion, transaction);
                        cmdDetalle.CommandType = CommandType.StoredProcedure;
                        cmdDetalle.Parameters.AddWithValue("@VentaID", ventaID);
                        cmdDetalle.Parameters.AddWithValue("@ProductoID", productoID);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmdDetalle.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al guardar la venta y sus detalles: " + ex.Message);
                }
                finally
                {
                    conexionSQL.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la transacción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ventaID;
        }
        private int ObtenerClienteID()
        {
            return 1;
        }

        private void dgvDetalledeventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvDetalledeventas.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnApartar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombreVentas.Text) && dgvDetalledeventas.Rows.Count >0)
                {
                    frmApartar frm = new frmApartar(this);

                    frm.TopLevel = false;

                    pnApartado.Controls.Clear();

                    pnApartado.Controls.Add(frm);

                    frm.Dock = DockStyle.Fill;

                    frm.Show();

                    pnApartado.Visible = true;
                }
                else
                {

                    MessageBox.Show("Debe seleccionar un cliente y/o producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           



        }
        private void ActualizarStock(int productoID, int cantidadVendida)
        {
            try
            {
                ConexionSQLServer conexionSQL = new ConexionSQLServer();
                conexionSQL.abrirConexion1();
                string query = "UPDATE Productos SET Existencia = Existencia - @CantidadVendida WHERE ID = @ProductoID";

                SqlCommand cmd = new SqlCommand(query, conexionSQL.conexion);
                cmd.Parameters.AddWithValue("@CantidadVendida", cantidadVendida);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                cmd.ExecuteNonQuery();
                conexionSQL.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirFactura()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1; // Objeto PrintDocument ya inicializado

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print(); // Llama al evento PrintPage y genera la factura
            }
        }
        int idFactura;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Definir fuentes y colores
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font regularFont = new Font("Arial", 10, FontStyle.Regular);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);

            Brush brush = Brushes.Black;
            float yPos = 100;
            int leftMargin = e.MarginBounds.Left;
            int rightMargin = e.MarginBounds.Right;
            int centerMargin = (rightMargin + leftMargin) / 2;

            // --- ENCABEZADO ---
            e.Graphics.DrawString("Factura", headerFont, brush, centerMargin - 50, yPos);
            yPos += 30;
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToShortDateString(), regularFont, brush, leftMargin, yPos);
            yPos += 20;
            e.Graphics.DrawString("Número de Factura: 000"+idFactura, regularFont, brush, leftMargin, yPos);
            yPos += 40;

            // --- DATOS DEL CLIENTE ---
            e.Graphics.DrawString("Cliente: " + txtNombreVentas.Text, regularFont, brush, leftMargin, yPos);
            yPos += 20;
            e.Graphics.DrawString("ID Cliente: " + txtIdentificacionVentas.Text, regularFont, brush, leftMargin, yPos);
            yPos += 40;

            // --- DETALLE DE PRODUCTOS (Encabezado de la tabla) ---
            e.Graphics.DrawString("ID Producto", boldFont, brush, leftMargin, yPos);
            e.Graphics.DrawString("Descripción", boldFont, brush, leftMargin + 100, yPos);
            e.Graphics.DrawString("Cantidad", boldFont, brush, leftMargin + 300, yPos);
            e.Graphics.DrawString("Precio Unitario", boldFont, brush, leftMargin + 400, yPos);
            e.Graphics.DrawString("Subtotal", boldFont, brush, leftMargin + 520, yPos);
            e.Graphics.DrawString("IVA", boldFont, brush, leftMargin + 620, yPos);
            yPos += 20;

            // --- DETALLES DE VENTAS (Contenido de la tabla) ---
            foreach (DataGridViewRow row in dgvDetalledeventas.Rows)
            {
                e.Graphics.DrawString(row.Cells["ID"].Value.ToString(), regularFont, brush, leftMargin, yPos);
                e.Graphics.DrawString(row.Cells["Nombre"].Value.ToString(), regularFont, brush, leftMargin + 100, yPos);
                e.Graphics.DrawString(row.Cells["Cantidad"].Value.ToString(), regularFont, brush, leftMargin + 300, yPos);
                e.Graphics.DrawString(Convert.ToDecimal(row.Cells["PrecioVenta"].Value).ToString("N2"), regularFont, brush, leftMargin + 400, yPos);
                e.Graphics.DrawString((Convert.ToDecimal(row.Cells["PrecioVenta"].Value) * Convert.ToInt32(row.Cells["Cantidad"].Value)).ToString("N2"), regularFont, brush, leftMargin + 520, yPos);
                e.Graphics.DrawString(Convert.ToDecimal(row.Cells["IVA"].Value).ToString("N2"), regularFont, brush, leftMargin + 620, yPos);
                yPos += 20;
            }

            yPos += 40;
            e.Graphics.DrawString("Subtotal: " + txtSubtotal.Text, boldFont, brush, rightMargin - 200, yPos);
            yPos += 20;
            e.Graphics.DrawString("Total: " + txtTotal.Text, boldFont, brush, rightMargin - 200, yPos);
        }
        private void GuardarFactura()
        {
            try
            {
                ConexionSQLServer conexionSQL = new ConexionSQLServer();
                conexionSQL.abrirConexion1();

                // Cambia ClienteID de int a long
                long clienteID = long.Parse(txtIdentificacionVentas.Text);

                // Calcula el IVA y el total
                decimal subtotal = decimal.Parse(txtSubtotal.Text);
                decimal iva = subtotal * 0.15m;  // Calcula el IVA (15% del subtotal)
                decimal total = subtotal + iva;  // Total = subtotal + IVA

                // Consulta para insertar la factura
                string query = "INSERT INTO RegistroFactura (Fecha, ClienteID, Subtotal, IVA, Total) " +
                               "VALUES (@Fecha, @ClienteID, @Subtotal, @IVA, @Total)";

                SqlCommand cmd = new SqlCommand(query, conexionSQL.conexion);

                // Agregar los parámetros
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);  // ClienteID es long
                cmd.Parameters.AddWithValue("@Subtotal", subtotal);
                cmd.Parameters.AddWithValue("@IVA", iva);
                cmd.Parameters.AddWithValue("@Total", total);

                // Ejecutar la inserción
                cmd.ExecuteNonQuery();

                conexionSQL.cerrarConexion();

                MessageBox.Show("Factura guardada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la factura: " + ex.Message);
            }

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
