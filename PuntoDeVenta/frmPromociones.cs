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
    public partial class frmPromociones : Form
    {
        public frmPromociones()
        {
            InitializeComponent();
            // Llenar el ComboBox con las opciones
            cbTipoPromocion.Items.Add("Clientes");
            cbTipoPromocion.Items.Add("Productos");
            cbTipoPromocion.SelectedIndex = -1;  // Para que no seleccione nada por defecto

        }

        private void cbTipoPromocion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cbTipoPromocion.SelectedItem.ToString();

            // Llamar al método para llenar el DataGridView según la selección del ComboBox
            LlenarDataGridView(seleccion);
        }

        private void LlenarDataGridView(string tipoPromocion)
        {
            ConexionSQLServer conexion = new ConexionSQLServer();
            DataTable dt = new DataTable();

            if (tipoPromocion == "Clientes")
            {
                string consultaClientes = "SELECT Nombre FROM Clientes Where ID > 2";
                dt = conexion.DatosQuery(consultaClientes);
            }
            else if (tipoPromocion == "Productos")
            {
                string consultaProductos = "SELECT Nombre FROM Productos";
                dt = conexion.DatosQuery(consultaProductos);
            }

            dgvTipoPromocion.DataSource = dt;
        }

        private void frmPromociones_Load(object sender, EventArgs e)
        {
            nudDescuento.Minimum = 0;
            nudDescuento.Maximum = 100;
            nudDescuento.Increment = 1; // Elige el incremento que prefieras (1, 5, etc.)
            nudDescuento.Value = 0; // Valor inicial
            LlenarTablaPromociones();

        }
        private void LlenarTablaPromociones()
        {
            ConexionSQLServer conexion = new ConexionSQLServer();
            string consultaPromociones = "SELECT * FROM Promociones";  // Asegúrate que la tabla y columnas existen en la base de datos
            DataTable dt = conexion.DatosQuery(consultaPromociones);
            dgvTablaPromociones.DataSource = dt;

            // Configura las columnas según necesites mostrar
            dgvTablaPromociones.Columns["Descripcion"].HeaderText = "Descripción";
            dgvTablaPromociones.Columns["Descuento"].HeaderText = "Descuento (%)";
            dgvTablaPromociones.Columns["FechaInicio"].HeaderText = "Inicio";
            dgvTablaPromociones.Columns["FechaFin"].HeaderText = "Fin";
            dgvTablaPromociones.Columns["ProductoID"].HeaderText = "Producto ID";  // Suponiendo que quieras mostrar esto
            dgvTablaPromociones.Columns["ClienteID"].HeaderText = "Cliente ID";  // Suponiendo que quieras mostrar esto

            // Ajusta el tamaño de las columnas si es necesario
            dgvTablaPromociones.AutoResizeColumns();
        }


        private void dgvTipoPromocion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se ha hecho clic en una fila válida
            {
                DataGridViewRow row = dgvTipoPromocion.Rows[e.RowIndex];

                if (cbTipoPromocion.SelectedItem.ToString() == "Clientes")
                {
                    // Asigna el cliente seleccionado a un TextBox o propiedad
                    txtCliente.Text = row.Cells["Nombre"].Value.ToString(); // Asumiendo que la columna del nombre es "Nombre"
                }
                else if (cbTipoPromocion.SelectedItem.ToString() == "Productos")
                {
                    // Asigna el producto seleccionado a un TextBox o propiedad
                    txtProducto.Text = row.Cells["Nombre"].Value.ToString(); // Asumiendo que la columna del nombre es "Nombre"

                    // Además, muestra el precio de venta en el TextBox txtPrecioVenta
                    txtPrecioVenta.Text = row.Cells["PrecioVenta"].Value.ToString(); // Asumiendo que la columna del precio de venta es "PrecioVenta"
                }
            }
        }


        private void btnGuardarPromocion_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya seleccionado un tipo de promoción
                if (cbTipoPromocion.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona un tipo de promoción.");
                    return;
                }

                // Validar que la descripción no esté vacía
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingresa una descripción de la promoción.");
                    return;
                }

                // Crear una nueva instancia de la clase Promociones
                Promociones nuevaPromocion = new Promociones
                {
                    Descripcion = txtDescripcion.Text, // Asegúrate de tener un TextBox llamado txtDescripcion
                    Descuento = nudDescuento.Value, // Asegúrate de tener un NumericUpDown llamado nudDescuento
                    FechaInicio = dtpFechaInicio.Value, // Asegúrate de tener un DateTimePicker llamado dtpFechaInicio
                    FechaFin = dtpFechaFin.Value, // Asegúrate de tener un DateTimePicker llamado dtpFechaFin
                    ProductoID = ObtenerProductoID(), // Método para obtener el ID del producto seleccionado
                    ClienteID = ObtenerClienteID() // Método para obtener el ID del cliente seleccionado, si aplica
                };

                // Llamar al método GuardarPromocion y manejar el resultado
                bool resultado = nuevaPromocion.GuardarPromocion();
                if (resultado)
                {
                    MessageBox.Show("Promoción guardada exitosamente.");
                    // Aquí puedes limpiar los campos o actualizar el DataGridView si es necesario
                    LimpiarCampos(); // Método para limpiar los campos
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la promoción.");
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                MessageBox.Show("Ocurrió un error al intentar guardar la promoción: " + ex.Message);
            }
        }
        private int ObtenerProductoID()
        {
            if (dgvTipoPromocion.SelectedRows.Count > 0)
            {
                // Asumiendo que la columna 0 del DataGridView es el ID del producto
                return Convert.ToInt32(dgvTipoPromocion.SelectedRows[0].Cells[0].Value);
            }
            return -1; // Valor que indica que no se ha seleccionado un producto
        }
        private int ObtenerClienteID()
        {
            if (dgvTipoPromocion.SelectedRows.Count > 0)
            {
                // Asumiendo que la columna 0 del DataGridView es el ID del cliente
                return Convert.ToInt32(dgvTipoPromocion.SelectedRows[0].Cells[0].Value);
            }
            return -1; // Valor que indica que no se ha seleccionado un cliente
        }
        private void LimpiarCampos()
        {
            txtDescripcion.Clear(); // Limpiar el campo de descripción
            nudDescuento.Value = 0; // Restablecer el descuento a 0
            dtpFechaInicio.Value = DateTime.Now; // Restablecer la fecha de vigencia a ahora
            dtpFechaFin.Value = DateTime.Now.AddDays(30); // Establecer la fecha de caducidad a 30 días a partir de ahora
            cbTipoPromocion.SelectedIndex = -1; // Desmarcar el ComboBox de tipo de promoción
        }

        private void dgvTablaPromociones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
