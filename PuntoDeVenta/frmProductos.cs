using PuntoDeVenta.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class frmProductos : Form
    {
        Productos db = new Productos();

        private Productos producto;
        ConexionSQLServer sqlCon;

        public frmProductos()
        {
            InitializeComponent();

            Productos db = new Productos();

            List<Productos> lista = db.ListaProductos();

            dgvProductos.DataSource = lista;

            //DataGridViewButtonColumn botonModificar = new DataGridViewButtonColumn();
            //botonModificar.Name = "Modificar";
            //botonModificar.HeaderText = "Modificar";
            //botonModificar.Text = "Modificar";
            //botonModificar.UseColumnTextForButtonValue = true;

            //dgvProductos.Columns.Add(botonModificar);

            // Inicializa el servicio con la cadena de conexión a tu base de datos
            string connectionString = "Data Source=.;Initial Catalog=PuntoDeVenta2;Integrated Security=True;"; // Reemplaza con tu cadena de conexión
            producto = new Productos(connectionString);


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblID.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();  // ID del producto
                txt_Nombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();  // Nombre del producto
                txt_CodigoBarra.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString(); // Código de barra
                txt_PrecioCompra.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();  // Precio de compra
                txt_PrecioVenta.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();    // Precio de venta
                txt_Existencia.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();     // Existencia
                txt_StockMinimo.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();    // Stock mínimo
                txt_ProveedorID.Text = dgvProductos.CurrentRow.Cells[7].Value.ToString();    // ProveedorID
                txt_BodegaID.Text = dgvProductos.CurrentRow.Cells[8].Value.ToString();       // BodegaID
                cb_NombreProveedor.SelectedValue = txt_ProveedorID.Text;  // Seleccionar Proveedor en el ComboBox basado en el ID
                cb_NombreBodega.SelectedValue = txt_BodegaID.Text;       // Seleccionar Bodega en el ComboBox basado en el ID

                cbIVA.Text = dgvProductos.CurrentRow.Cells[9].Value.ToString() + "%";  // IVA
                chkEstado.Checked = Convert.ToBoolean(dgvProductos.CurrentRow.Cells[10].Value); // Estado
                chkEstado.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //txt_ProveedorID.Text = dgvProductos.CurrentRow.Cells[7].Value.ToString();    // ProveedorID
        //txt_BodegaID.Text = dgvProductos.CurrentRow.Cells[8].Value.ToString();       // BodegaID
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se valida si hay campos vacíos antes de continuar
                if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                    string.IsNullOrWhiteSpace(txt_CodigoBarra.Text) ||
                    string.IsNullOrWhiteSpace(txt_PrecioCompra.Text) ||
                    string.IsNullOrWhiteSpace(txt_PrecioVenta.Text) ||
                    string.IsNullOrWhiteSpace(txt_Existencia.Text) ||
                    string.IsNullOrWhiteSpace(txt_StockMinimo.Text) ||
                    cb_NombreProveedor.SelectedIndex == -1 ||   // Validación para el proveedor
                    cb_NombreBodega.SelectedIndex == -1 ||      // Validación para la bodega
                    cbIVA.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, verifica que todos los campos estén correctos.", "Campos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres agregar este producto?", "Confirmar adición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        sqlCon = new ConexionSQLServer();
                        sqlCon.ejecutarSP_InsertarProducto("InsertarProducto",
                            txt_Nombre.Text,
                            txt_CodigoBarra.Text,
                            Convert.ToDecimal(txt_PrecioCompra.Text),
                            Convert.ToDecimal(txt_PrecioVenta.Text),
                            Convert.ToInt32(txt_Existencia.Text),
                            Convert.ToInt32(txt_StockMinimo.Text),
                            cb_NombreProveedor.SelectedValue.ToString(),    // Obtener el valor seleccionado del proveedor
                            cb_NombreBodega.SelectedValue.ToString(),       // Obtener el valor seleccionado de la bodega
                            chbPreCompra.Checked ? dtInicio.Value : null,
                            chbPreCompra.Checked ? dtFin.Value : null,
                            Convert.ToChar(cbIVA.SelectedValue));

                        MessageBox.Show("Se ha ingresado un nuevo producto correctamente.");
                        dgvProductos.DataSource = db.ListaProductos();
                        LimpiarCamposProducto();
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
                // Se valida si hay campos vacíos antes de continuar
                if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                    string.IsNullOrWhiteSpace(txt_CodigoBarra.Text) ||
                    string.IsNullOrWhiteSpace(txt_PrecioCompra.Text) ||
                    string.IsNullOrWhiteSpace(txt_PrecioVenta.Text) ||
                    string.IsNullOrWhiteSpace(txt_Existencia.Text) ||
                    string.IsNullOrWhiteSpace(txt_StockMinimo.Text) ||
                    cb_NombreProveedor.SelectedIndex == -1 ||   // Validación para el proveedor usando ComboBox
                    cb_NombreBodega.SelectedIndex == -1 ||      // Validación para la bodega usando ComboBox
                    cbIVA.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, verifica que todos los campos estén correctos.", "Campos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Obtener la cantidad de existencia actual y la nueva cantidad
                    int cantidadExistente = Convert.ToInt32(dgvProductos.CurrentRow.Cells[5].Value); // Columna de existencias actual
                    int nuevaCantidad = Convert.ToInt32(txt_Existencia.Text); // Nueva cantidad ingresada por el usuario

                    // Verificar si la nueva cantidad es menor que la existente
                    if (nuevaCantidad < cantidadExistente)
                    {
                        MessageBox.Show("No puedes ingresar una cantidad menor de la ya establecida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Confirmar la edición
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres editar este producto?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        sqlCon = new ConexionSQLServer();
                        sqlCon.ejecutarSP_ActualizarProducto("EditarProducto", lblID.Text, txt_Nombre.Text, txt_CodigoBarra.Text,
                            Convert.ToDecimal(txt_PrecioCompra.Text), Convert.ToDecimal(txt_PrecioVenta.Text), nuevaCantidad,
                            Convert.ToInt32(txt_StockMinimo.Text),
                            cb_NombreProveedor.SelectedValue.ToString(),    // Obtener el valor seleccionado del proveedor
                            cb_NombreBodega.SelectedValue.ToString(),       // Obtener el valor seleccionado de la bodega
                            Convert.ToChar(cbIVA.SelectedValue), chkEstado.Checked);

                        MessageBox.Show("Se ha actualizado el producto correctamente.");
                        dgvProductos.DataSource = db.ListaProductos();
                        LimpiarCamposProducto();
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
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    sqlCon = new ConexionSQLServer();
                    sqlCon.ejecutarSP_EliminarProducto("EliminarProducto", lblID.Text);
                    MessageBox.Show("Se ha eliminado el producto correctamente.");
                    dgvProductos.DataSource = db.ListaProductos();
                    LimpiarCamposProducto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarCamposProducto()
        {
            lblID.Text = "";
            txt_Nombre.Text = "";
            txt_CodigoBarra.Text = "";
            txt_PrecioCompra.Text = "";
            txt_PrecioVenta.Text = "";
            txt_Existencia.Text = "";
            txt_StockMinimo.Text = "";
            txt_ProveedorID.Text = "";
            txt_BodegaID.Text = "";
            cb_NombreProveedor.SelectedIndex = -1;  // Limpiar ComboBox Proveedor
            cb_NombreBodega.SelectedIndex = -1;     // Limpiar ComboBox Bodega
            cbIVA.SelectedIndex = -1;
            chkEstado.Visible = false;
        }



        //private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        //{
        //    ConexionSQLServer conexionSQL = new ConexionSQLServer();

        //    DataTable resultados = conexionSQL.BuscarEnTabla("Productos", "ID", "Nombre", txtBuscarProducto.Text);

        //    dgvProductos.DataSource = resultados;
        //}

        private void chbPreCompra_CheckedChanged(object sender, EventArgs e)
        {
            dtInicio.Enabled = chbPreCompra.Checked;
            dtFin.Enabled = chbPreCompra.Checked;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            sqlCon = new ConexionSQLServer();
            cbIVA.DataSource = sqlCon.DatosQuery("select CodIVA,convert(Varchar(20),Porcentaje)+'%' as P  from tbIVA");
            cbIVA.ValueMember = "CodIVA";
            cbIVA.DisplayMember = "P";
            cbIVA.SelectedIndex = -1;

            // Cargar proveedores en cb_NombreProveedor
            cb_NombreProveedor.DataSource = sqlCon.DatosQuery("SELECT ID, Nombre FROM Proveedores");
            cb_NombreProveedor.ValueMember = "ID";   // Valor interno
            cb_NombreProveedor.DisplayMember = "Nombre";  // Nombre visible en el ComboBox
            cb_NombreProveedor.SelectedIndex = -1;  // No seleccionar ninguno por defecto

            // Cargar bodegas en cb_NombreBodega
            cb_NombreBodega.DataSource = sqlCon.DatosQuery("SELECT ID, Nombre FROM Bodega");
            cb_NombreBodega.ValueMember = "ID";   // Valor interno
            cb_NombreBodega.DisplayMember = "Nombre";  // Nombre visible en el ComboBox
            cb_NombreBodega.SelectedIndex = -1;  // No seleccionar ninguno por defecto

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
