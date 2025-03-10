using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace PuntoDeVenta.clases
{
    internal class ConexionSQLServer
    {
        public SqlConnection conexion;
        SqlCommand oCom = new SqlCommand();
        SqlDataReader oDR;
        SqlDataAdapter oDA;
        DataSet oDS;
        DataTable oDT;  // Contener tablas

        public ConexionSQLServer()
        {
            // La cadena de conexión utiliza Integrated Security para la autenticación de Windows
            conexion = new SqlConnection(@"Data Source=.;Initial Catalog=PuntoDeVenta2;Integrated Security=True");
        }

        public void abrirConexion1()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conectarse " + e.Message);
            }
        }

        public static SqlConnection abrirConexion()
        {
            SqlConnection oCon = new SqlConnection(@"Data Source=.;Initial Catalog=PuntoDeVenta2;Integrated Security=True");
            oCon.Open();
            return oCon;
        }

        public bool cerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool RegistrarVentaConDetalles(int clienteID, decimal total, int empleadoID, DataGridView dgvDetalles, out int ventaID)
        {
            SqlTransaction transaction = null;
            ventaID = 0; // Inicializar el parámetro de salida

            try
            {
                // Abrir la conexión
                abrirConexion1();

                // Iniciar una transacción
                transaction = conexion.BeginTransaction();

                // Crear el comando SQL para registrar la venta
                SqlCommand cmdVenta = new SqlCommand("sp_GuardarVenta", conexion, transaction);
                cmdVenta.CommandType = CommandType.StoredProcedure;

                // Pasar los parámetros al procedimiento de la venta
                cmdVenta.Parameters.AddWithValue("@Fecha", DateTime.Now);
                cmdVenta.Parameters.AddWithValue("@ClienteID", clienteID);
                cmdVenta.Parameters.AddWithValue("@Total", total);
                cmdVenta.Parameters.AddWithValue("@EmpleadoID", empleadoID);

                // Parametro de salida para capturar el ID de la venta generada
                SqlParameter ventaIDParam = new SqlParameter("@VentaID", SqlDbType.Int);
                ventaIDParam.Direction = ParameterDirection.Output;
                cmdVenta.Parameters.Add(ventaIDParam);

                // Ejecutar el comando para registrar la venta
                cmdVenta.ExecuteNonQuery();

                // Obtener el ID de la venta generada
                ventaID = Convert.ToInt32(ventaIDParam.Value);

                // Registrar los detalles de la venta desde el DataGridView
                foreach (DataGridViewRow row in dgvDetalles.Rows)
                {
                    // Asegurarse de que la fila no esté vacía
                    if (row.Cells["ID"].Value != null && row.Cells["Cantidad"].Value != null)
                    {
                        int productoID = Convert.ToInt32(row.Cells["ID"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        SqlCommand cmdDetalle = new SqlCommand("sp_GuardarDetalleVenta", conexion, transaction);
                        cmdDetalle.CommandType = CommandType.StoredProcedure;

                        // Pasar los parámetros al procedimiento del detalle
                        cmdDetalle.Parameters.AddWithValue("@VentaID", ventaID);
                        cmdDetalle.Parameters.AddWithValue("@ProductoID", productoID);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad);

                        // Ejecutar el comando para registrar cada detalle
                        cmdDetalle.ExecuteNonQuery();
                    }
                }

                // Si todo sale bien, confirmar la transacción
                transaction.Commit();

                // Cerrar la conexión
                cerrarConexion();

                return true; // Indicar que todo se registró correctamente
            }
            catch (Exception ex)
            {
                // Si ocurre un error, deshacer la transacción
                transaction?.Rollback();

                MessageBox.Show("Error al registrar la venta y sus detalles: " + ex.Message);
                return false; // Indicar que ocurrió un error
            }
        }

        public DataTable DatosQuery(string consulta)
        {
            try
            {
                // Crear una nueva instancia de DataTable para almacenar los resultados
                DataTable tablaResultado = new DataTable();

                // Abrir la conexión a la base de datos
                abrirConexion1();

                // Crear el comando SQL con la consulta recibida como parámetro
                SqlCommand comando = new SqlCommand(consulta, conexion);

                // Utilizar SqlDataAdapter para ejecutar el comando y llenar el DataTable con los resultados
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tablaResultado);

                // Cerrar la conexión a la base de datos
                cerrarConexion();

                // Retornar el DataTable con los resultados de la consulta
                return tablaResultado;
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar un mensaje y retornar null
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return null;
            }
        }


        public int EjecutarSP_GuardarPagosPrecompra(int ID, int CajaID, decimal Pago, string TipoPago)
        {

            try
            {
                abrirConexion1();
                SqlCommand oCom = new SqlCommand("SP_GuardarPagosPreCompra", conexion);
                oCom.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros
                oCom.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                oCom.Parameters.Add("@CajaID", SqlDbType.Int).Value = CajaID;
                oCom.Parameters.Add("@TipoPago", SqlDbType.VarChar).Value = TipoPago;
                oCom.Parameters.Add("@Pago", SqlDbType.Decimal).Value = Pago;

                // Ejecutar el comando
                int result = oCom.ExecuteNonQuery();

                cerrarConexion();
                return result > 0 ? 1 : 0; // Retorna 1 si se afectaron filas, 0 si no


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1; // Retornar un valor que indique error
            }
        }

        public int EjecutarSP_GuardarPrecompra(int ClienteID, int ProductoID, int Cantidad, int EmpleadoID, decimal PagoInicial, decimal TotalPago, int CajaID, string TipoPago)
        {

            try
            {
                abrirConexion1();
                SqlCommand oCom = new SqlCommand("SP_GuardarPrecompra", conexion);
                oCom.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros
                oCom.Parameters.Add("@ClienteID", SqlDbType.Int).Value = ClienteID;
                oCom.Parameters.Add("@ProductoID", SqlDbType.Int).Value = ProductoID;
                oCom.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Cantidad;
                oCom.Parameters.Add("@EmpleadoID", SqlDbType.Int).Value = EmpleadoID;
                oCom.Parameters.Add("@PagoInicial", SqlDbType.Decimal).Value = PagoInicial;
                oCom.Parameters.Add("@TotalPago", SqlDbType.Decimal).Value = TotalPago;
                oCom.Parameters.Add("@CajaID", SqlDbType.Int).Value = CajaID;
                oCom.Parameters.Add("@TipoPago", SqlDbType.VarChar).Value = TipoPago;

                // Ejecutar el comando
                int result = oCom.ExecuteNonQuery();

                cerrarConexion();
                return result > 0 ? 1 : 0; // Retorna 1 si se afectaron filas, 0 si no

                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1; // Retornar un valor que indique error
            }
        }

        public static DataTable llenartablaproducto(string consul)
        {
            DataTable tabla = new DataTable();
            try
            {
                abrirConexion();
                tabla = new DataTable();
                string consultar = consul;
                SqlCommand comando = new SqlCommand(consultar, abrirConexion());
                SqlDataAdapter data = new SqlDataAdapter(comando);
                data.Fill(tabla);
                return tabla;
            }
            catch (Exception sms1)
            {
                MessageBox.Show(sms1.Message);
                return tabla;
            }
        }

        //Clientes
        public DataSet ejecutarSP_InsertarCLIENTE(string SP, string Cedula_Pasaporte, string Nombre_Cliente, string Ciudad, string Direccion, string telefono)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@Cedula", SqlDbType.VarChar, 10);
                oCom.Parameters["@Cedula"].Value = Cedula_Pasaporte;

                oCom.Parameters.Add("@Telefono", SqlDbType.VarChar, 50);
                oCom.Parameters["@Telefono"].Value = Nombre_Cliente;

                oCom.Parameters.Add("@Nombre", SqlDbType.VarChar, 20);
                oCom.Parameters["@Nombre"].Value = Ciudad;

                oCom.Parameters.Add("@NombreReferencia", SqlDbType.VarChar, 50);
                oCom.Parameters["@NombreReferencia"].Value = Direccion;

                oCom.Parameters.Add("@TelefonoReferencia", SqlDbType.VarChar, 10);
                oCom.Parameters["@TelefonoReferencia"].Value = telefono;

                //Necesito trabajar con info a nivel de registros
                oDA = new SqlDataAdapter(oCom);  // ejecuta SqlCommand y paso a SqlAdapter
                oDS = new DataSet("dsRetorna");  // DataSet puede tener muchas tablas
                oDA.Fill(oDS, "dsRetorna");  // almacenar en tbla 

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataSet ejecutarSP_Actualizar_ClIENTE(string SP, string ID, string Cedula, string Telefono, string Nombre, string NombreReferencia, string TelefonoReferencia)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@ID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ID"].Value = ID;

                oCom.Parameters.Add("@Cedula", SqlDbType.VarChar, 10);
                oCom.Parameters["@Cedula"].Value = Cedula;

                oCom.Parameters.Add("@Telefono", SqlDbType.VarChar, 10);
                oCom.Parameters["@Telefono"].Value = Telefono;

                oCom.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                oCom.Parameters["@Nombre"].Value = Nombre;

                oCom.Parameters.Add("@NombreReferencia", SqlDbType.VarChar, 50);
                oCom.Parameters["@NombreReferencia"].Value = NombreReferencia;

                oCom.Parameters.Add("@TelefonoReferencia", SqlDbType.VarChar, 50);
                oCom.Parameters["@TelefonoReferencia"].Value = TelefonoReferencia;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataSet ejecutarSP_Eliminar_ClIENTE(string SP, string ID)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@ID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ID"].Value = ID;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        //Bodega
        public DataSet ejecutarSP_InsertarBodega(string SP, string Nombre_Bodega, string Ubicacion, string EmpleadoID)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                oCom.Parameters["@Nombre"].Value = Nombre_Bodega;

                oCom.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 100);
                oCom.Parameters["@Ubicacion"].Value = Ubicacion;

                oCom.Parameters.Add("@EmpleadoID", SqlDbType.VarChar, 10);
                oCom.Parameters["@EmpleadoID"].Value = EmpleadoID;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataSet ejecutarSP_ActualizarBodega(string SP, string ID, string Nombre_Bodega, string Ubicacion, string EmpleadoID)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@ID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ID"].Value = ID;

                oCom.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                oCom.Parameters["@Nombre"].Value = Nombre_Bodega;

                oCom.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 100);
                oCom.Parameters["@Ubicacion"].Value = Ubicacion;

                oCom.Parameters.Add("@EmpleadoID", SqlDbType.VarChar, 10);
                oCom.Parameters["@EmpleadoID"].Value = EmpleadoID;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataSet ejecutarSP_EliminarBodega(string SP, string ID)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@ID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ID"].Value = ID;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        //Pagos
        public DataSet ejecutarSP_InsertarPago(string SP, string ClienteID, string ProductoID, decimal monto, string usuario, string CajaID)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@ClienteID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ClienteID"].Value = ClienteID;

                oCom.Parameters.Add("@ProductoID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ProductoID"].Value = ProductoID;

                oCom.Parameters.Add("@monto", SqlDbType.Decimal);
                oCom.Parameters["@monto"].Value = monto;

                oCom.Parameters.Add("@usuario", SqlDbType.VarChar, 50);
                oCom.Parameters["@usuario"].Value = usuario;

                oCom.Parameters.Add("@CajaID", SqlDbType.VarChar, 10);
                oCom.Parameters["@CajaID"].Value = CajaID;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataSet ejecutarSP_ActualizarPago(string SP, string ClienteID, string ProductoID, decimal monto, string usuario, string CajaID)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@ClienteID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ClienteID"].Value = ClienteID;

                oCom.Parameters.Add("@ProductoID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ProductoID"].Value = ProductoID;

                oCom.Parameters.Add("@monto", SqlDbType.Decimal);
                oCom.Parameters["@monto"].Value = monto;

                oCom.Parameters.Add("@usuario", SqlDbType.VarChar, 50);
                oCom.Parameters["@usuario"].Value = usuario;

                oCom.Parameters.Add("@CajaID", SqlDbType.VarChar, 10);
                oCom.Parameters["@CajaID"].Value = CajaID;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataSet ejecutarSP_EliminarPago(string SP, string ID)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@ID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ID"].Value = ID;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        //Productos
        public DataSet ejecutarSP_InsertarProducto(string SP, string Nombre, string CodigoBarra, decimal PrecioCompra, decimal PrecioVenta, int Existencia, int StockMinimo, string ProveedorID, string BodegaID, DateTime? inicio, DateTime? fin, char codIVA)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                oCom.Parameters["@Nombre"].Value = Nombre;

                oCom.Parameters.Add("@CodigoBarra", SqlDbType.VarChar, 20);
                oCom.Parameters["@CodigoBarra"].Value = CodigoBarra;

                oCom.Parameters.Add("@PrecioCompra", SqlDbType.Decimal);
                oCom.Parameters["@PrecioCompra"].Value = PrecioCompra;

                oCom.Parameters.Add("@PrecioVenta", SqlDbType.Decimal);
                oCom.Parameters["@PrecioVenta"].Value = PrecioVenta;

                oCom.Parameters.Add("@Existencia", SqlDbType.Int);
                oCom.Parameters["@Existencia"].Value = Existencia;

                oCom.Parameters.Add("@StockMinimo", SqlDbType.Int);
                oCom.Parameters["@StockMinimo"].Value = StockMinimo;

                oCom.Parameters.Add("@ProveedorID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ProveedorID"].Value = ProveedorID;

                oCom.Parameters.Add("@BodegaID", SqlDbType.VarChar, 10);
                oCom.Parameters["@BodegaID"].Value = BodegaID;

                oCom.Parameters.Add("@inicio", SqlDbType.Date);
                oCom.Parameters["@inicio"].Value = (object)inicio ?? DBNull.Value;

                oCom.Parameters.Add("@fin", SqlDbType.Date);
                oCom.Parameters["@fin"].Value = (object)fin ?? DBNull.Value;

                
                oCom.Parameters.Add("@codiva", SqlDbType.Char, 1);
                oCom.Parameters["@codiva"].Value = codIVA;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataSet ejecutarSP_ActualizarProducto(string SP, string ID, string Nombre, string CodigoBarra, decimal PrecioCompra, decimal PrecioVenta, int Existencia, int StockMinimo, string ProveedorID, string BodegaID, char codIVA, bool Estado)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@ID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ID"].Value = ID;

                oCom.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                oCom.Parameters["@Nombre"].Value = Nombre;

                oCom.Parameters.Add("@CodigoBarra", SqlDbType.VarChar, 20);
                oCom.Parameters["@CodigoBarra"].Value = CodigoBarra;

                oCom.Parameters.Add("@PrecioCompra", SqlDbType.Decimal);
                oCom.Parameters["@PrecioCompra"].Value = PrecioCompra;

                oCom.Parameters.Add("@PrecioVenta", SqlDbType.Decimal);
                oCom.Parameters["@PrecioVenta"].Value = PrecioVenta;

                oCom.Parameters.Add("@Existencia", SqlDbType.Int);
                oCom.Parameters["@Existencia"].Value = Existencia;

                oCom.Parameters.Add("@StockMinimo", SqlDbType.Int);
                oCom.Parameters["@StockMinimo"].Value = StockMinimo;

                oCom.Parameters.Add("@ProveedorID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ProveedorID"].Value = ProveedorID;

                oCom.Parameters.Add("@BodegaID", SqlDbType.VarChar, 10);
                oCom.Parameters["@BodegaID"].Value = BodegaID;


                oCom.Parameters.Add("@codiva", SqlDbType.Char, 1);
                oCom.Parameters["@codiva"].Value = codIVA;

                oCom.Parameters.Add("@Estado", SqlDbType.Bit);
                oCom.Parameters["@Estado"].Value = Estado ;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataSet ejecutarSP_EliminarProducto(string SP, string ID)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@ID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ID"].Value = ID;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataSet ejecutarSP_InsertarProveedor(string SP, string Nombre, string Telefono, string Direccion)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                oCom.Parameters["@Nombre"].Value = Nombre;

                oCom.Parameters.Add("@Telefono", SqlDbType.VarChar, 20);
                oCom.Parameters["@Telefono"].Value = Telefono;

                oCom.Parameters.Add("@Direccion", SqlDbType.VarChar, 100);
                oCom.Parameters["@Direccion"].Value = Direccion;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataSet ejecutarSP_ActualizarProveedor(string SP, string ID, string Nombre, string Telefono, string Direccion)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@ID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ID"].Value = ID;

                oCom.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                oCom.Parameters["@Nombre"].Value = Nombre;

                oCom.Parameters.Add("@Telefono", SqlDbType.VarChar, 20);
                oCom.Parameters["@Telefono"].Value = Telefono;

                oCom.Parameters.Add("@Direccion", SqlDbType.VarChar, 100);
                oCom.Parameters["@Direccion"].Value = Direccion;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataSet ejecutarSP_EliminarProveedor(string SP, string ID)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@ID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ID"].Value = ID;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        //Caja
        public DataSet ejecutarSP_InsertarCaja(string SP, string Descripcion, string Tipo, decimal Monto, DateTime Fecha)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
                oCom.Parameters["@Descripcion"].Value = Descripcion;

                oCom.Parameters.Add("@Tipo", SqlDbType.VarChar, 50);
                oCom.Parameters["@Tipo"].Value = Tipo;

                oCom.Parameters.Add("@Monto", SqlDbType.Decimal);
                oCom.Parameters["@Monto"].Value = Monto;

                // Agregar parámetro para la fecha
                oCom.Parameters.Add("@Fecha", SqlDbType.Date);
                oCom.Parameters["@Fecha"].Value = Fecha;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }



        public DataSet ejecutarSP_ActualizarCaja(string SP, string ID, string Descripcion, string Tipo, string Monto, DateTime Fecha)
{
    try
    {
        abrirConexion1();
        oCom = new SqlCommand(SP, conexion);
        // indicar tipo procedimiento almacenado
        oCom.CommandType = CommandType.StoredProcedure;

        oCom.Parameters.Add("@ID", SqlDbType.VarChar, 10);
        oCom.Parameters["@ID"].Value = ID;

        oCom.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
        oCom.Parameters["@Descripcion"].Value = Descripcion;

        oCom.Parameters.Add("@Tipo", SqlDbType.VarChar, 50);
        oCom.Parameters["@Tipo"].Value = Tipo;

        oCom.Parameters.Add("@Monto", SqlDbType.VarChar, 100);
        oCom.Parameters["@Monto"].Value = Monto;

        // Agregar parámetro de la fecha
        oCom.Parameters.Add("@Fecha", SqlDbType.DateTime);
        oCom.Parameters["@Fecha"].Value = Fecha;

        oDA = new SqlDataAdapter(oCom);
        oDS = new DataSet("dsRetorna");
        oDA.Fill(oDS, "dsRetorna");

        cerrarConexion();

        return oDS;
    }
    catch (Exception e)
    {
        MessageBox.Show(e.Message);
        return null;
    }
}


        public DataTable BuscarEnTabla(string nombreTabla, string campo1, string campo2, string terminoBusqueda)
        {
            try
            {
                abrirConexion1();
                string query = $"SELECT * FROM {nombreTabla} WHERE {campo1} LIKE @Busqueda OR {campo2} LIKE @Busqueda";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Busqueda", "%" + terminoBusqueda + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cerrarConexion();

                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la búsqueda: " + e.Message);
                return null;
            }
        }
        public void ActualizarInventarioProducto(int productoID, int cantidadApartada)
        {
            try
            {
                abrirConexion1();

                string query = "UPDATE Productos SET Existencia = Existencia - @cantidadApartada WHERE ID = @productoID";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@cantidadApartada", cantidadApartada);
                cmd.Parameters.AddWithValue("@productoID", productoID);

                cmd.ExecuteNonQuery();
                cerrarConexion();

                MessageBox.Show("El inventario ha sido actualizado correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualizar el inventario: " + e.Message);
            }
        }

        public DataSet ejecutarSP_EliminarCaja(string SP, string ID)
        {
            try
            {
                abrirConexion1();
                oCom = new SqlCommand(SP, conexion);
                // indicar tipo procedimiento almacenado
                oCom.CommandType = CommandType.StoredProcedure;

                oCom.Parameters.Add("@ID", SqlDbType.VarChar, 10);
                oCom.Parameters["@ID"].Value = ID;

                oDA = new SqlDataAdapter(oCom);
                oDS = new DataSet("dsRetorna");
                oDA.Fill(oDS, "dsRetorna");

                cerrarConexion();

                return oDS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public void InsertarFactura(DateTime fecha, int clienteID, decimal subtotal, decimal iva, decimal total)
        {
            try
            {
                abrirConexion1(); // Abre la conexión

                // La consulta SQL para insertar la nueva factura
                string query = "INSERT INTO RegistroFactura (Fecha, ClienteID, Subtotal, IVA, Total) " +
                               "VALUES (@Fecha, @ClienteID, @Subtotal, @IVA, @Total)";

                SqlCommand cmd = new SqlCommand(query, conexion);

                // Agregar los parámetros de la consulta
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                cmd.Parameters.AddWithValue("@Subtotal", subtotal);
                cmd.Parameters.AddWithValue("@IVA", iva);
                cmd.Parameters.AddWithValue("@Total", total);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();

                // Cerrar la conexión
                cerrarConexion();

                MessageBox.Show("Factura guardada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la factura: " + ex.Message);
            }
        }

    }
}