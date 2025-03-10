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
    public partial class frmPromocion : Form
    {
        public frmPromocion()
        {
            InitializeComponent();
            LimpiarCampos(); sqlCon = new ConexionSQLServer();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ConexionSQLServer sqlCon;
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
                        txtNombreProducto.Text = productoSeleccionado.Nombre;

                    }
                }
            }
        }
        public frmListaClientes listaClientes;
        private void btn_BuscarClientePromo_Click(object sender, EventArgs e)
        {
            frmListaClientes listaClientes = new frmListaClientes();
            if (listaClientes.ShowDialog() == DialogResult.OK)
            {
                // Código para manejar el cliente seleccionado
                var cliente = listaClientes.ClienteSeleccionado;
                // Hacer algo con el cliente
            }
        }

        private void LimpiarCampos()
        {
            // Limpiar campos para el registro de combos
            txt_RegistrarDescripcionCombo.Clear();
            txt_RegistrarDescuentoCombo.Clear();
            dtp_FechaInicioCombo.Value = DateTime.Now;
            dtp_FechaFinalProducto.Value = DateTime.Now;

            // Limpiar campos para el registro de promociones
            txt_RegistrarDescripcionPromo.Clear();
            txt_RegistrarDescuentoPromo.Clear();
            dtp_FechaInicioPromo.Value = DateTime.Now;
            dtp_FechaFinalPromo.Value = DateTime.Now;

            // Resetear ComboBox y DataGridView
            cb_Categoria.SelectedIndex = -1;
            //dgv_Mostrar.DataSource = null;

            // Desmarcar todos los radio buttons


            rb_Clientes.Checked = false;
            rb_Categorias.Checked = false;
        }

        private void rb_MostrarCombo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_RegistrarCombo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Promociones_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_BuscarClientePromo_Click_1(object sender, EventArgs e)
        {

        }
        private bool ProductoYaAgregado(int idProducto)
        {
            foreach (DataGridViewRow fila in dgvCombos.Rows)
            {
                if (Convert.ToInt32(fila.Cells["DCIDProducto"].Value) == idProducto)
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_AgregarProductoCombo_Click(object sender, EventArgs e)
        {

            if (productoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Ingrese la cantidad");
                return;
            }
            if (productoSeleccionado.Existencia < int.Parse(txtCantidad.Text))
            {
                MessageBox.Show("No hay suficiente stock");
                return;
            }
            if (ProductoYaAgregado(productoSeleccionado.ID))
            {
                MessageBox.Show("El producto ya fue agregado");
                return;
            }

            int nuevaFilaIndex = dgvCombos.Rows.Add(
                          productoSeleccionado.ID,
                          productoSeleccionado.Nombre,
                          txtCantidad.Text,
                          productoSeleccionado.PrecioVenta,
                          productoSeleccionado.IVA

                       );

            DataGridViewButtonCell botonCelda = (DataGridViewButtonCell)dgvCombos.Rows[nuevaFilaIndex].Cells[dgvCombos.Columns.Count - 1];
            botonCelda.Value = "Quitar";

            dgvCombos.ClearSelection();
            dgvCombos.Rows[nuevaFilaIndex].Selected = true;
            dgvCombos.CurrentCell = dgvCombos.Rows[nuevaFilaIndex].Cells[0];

            txtNombreProducto.Clear();
            txtCantidad.Clear();
            txt_RegistrarDescuentoCombo.Clear();
            productoSeleccionado = null;

            CalcularTotales();
            txt_RegistrarDescuentoCombo_TextChanged(sender, e);

        }
        decimal totalCombo = 0;
        private void CalcularTotales()
        {
            decimal subtotal = 0;
            decimal totalIVA = 0;

            foreach (DataGridViewRow fila in dgvCombos.Rows)
            {
                decimal precioVenta = Convert.ToDecimal(fila.Cells["DCPrecio"].Value);
                int cantidad = Convert.ToInt32(fila.Cells["DCCantidad"].Value);
                decimal porcentajeIVA = Convert.ToDecimal(fila.Cells["DCIVA"].Value) / 100;

                // Sumar al subtotal
                subtotal += precioVenta * cantidad;

                // Calcular y sumar el IVA de este producto
                totalIVA += (precioVenta * cantidad) * porcentajeIVA;
            }

            // El total es la suma del subtotal y del IVA
            totalCombo = (subtotal + totalIVA);

            // Mostramos los valores en los TextBox correspondientes
            txtTotalCombo.Text = totalCombo.ToString("N2");  // Subtotal con IVA y descuento

        }

        private void frmPromocion_Load(object sender, EventArgs e)
        {       
            dtp_FechaInicioCombo.Value = DateTime.Now;
            dtp_FechaFinalProducto.Value = DateTime.Now.AddDays(7);
            CargarCombos();
        }

        private void CargarCombos()
        {
            // Cargar los datos de la tabla Combo en el DataGridView
            dgvTodo.DataSource = sqlCon.DatosQuery("select * from Combo");
            dgvTodo.Refresh(); // Refrescar el DataGridView
        }

        private void txt_RegistrarDescuentoCombo_TextChanged(object sender, EventArgs e)
        {
            decimal descuentoCombo = 0;
            if (string.IsNullOrEmpty(txtTotalCombo.Text))
            {
                return;
            }
            if (!string.IsNullOrEmpty(txt_RegistrarDescuentoCombo.Text))
            {
                descuentoCombo = decimal.Parse(txt_RegistrarDescuentoCombo.Text) / 100;
                txtTotalCombo.Text = (totalCombo * (1 - descuentoCombo)).ToString("N2");
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_RegistrarDescripcionCombo.Text))
            {
                MessageBox.Show("Ingrese la descripcion del combo");
                return;
            }
            if (string.IsNullOrEmpty(txt_RegistrarDescuentoCombo.Text))
            {
                MessageBox.Show("Ingrese un descuento para el combo");
                return;
            }
            if (dtp_FechaInicioCombo.Value > dtp_FechaFinalProducto.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha final");
                return;
            }
            if (dgvCombos.Rows.Count == 0)
            {
                MessageBox.Show("Agregue productos al combo");
                return;
            }


            Promocion promo = new Promocion();
            if (promo.RegistrarCombo(txt_RegistrarDescripcionCombo.Text, Convert.ToDecimal(txt_RegistrarDescuentoCombo.Text), Convert.ToDecimal(txtTotalCombo.Text), dtp_FechaInicioCombo.Value, dtp_FechaFinalProducto.Value, dgvCombos))
            {
                MessageBox.Show("Se registro el combo correctamente!");
                LimpiarCamposCombo();
                CargarCombos();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el combo");
            }
        }
        private void LimpiarCamposCombo()
        {
            productoSeleccionado = null;
            txtNombreProducto.Clear();
            txt_RegistrarDescripcionCombo.Clear();
            txt_RegistrarDescuentoCombo.Clear();
            txtCantidad.Clear();
            dgvCombos.Rows.Clear();
            dgvCombos.Refresh();
        }
        private void txt_RegistrarDescuentoCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evitar que se ingrese cualquier otro carácter
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evitar que se ingrese cualquier otro carácter
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
            dgvTodo.DataSource = sqlCon.DatosQuery($"select * from Combo where Descripcion like '%'+'{txtBuscar.Text}'+'%'");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltroFechas_Click(object sender, EventArgs e)
        {
            if (dtp_FechaInicioCombo.Value<dtp_FechaFinalProducto.Value)
            {
                dgvTodo.DataSource = sqlCon.DatosQuery($"select * from Combo \r\nwhere FechaInicio>='{dtpFiltroInicio.Value}' and '{dtpFiltroFinal.Value}'>=FechaFin");
            }
        }
    }
}
