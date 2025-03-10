using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.clases
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Cedula { get; set; } = string.Empty;
        public string Telefono { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string NombreReferencia { get; set; }
        public string TelefonoReferencia { get; set; } = string.Empty;

        private string connectionString;

        ConexionSQLServer miConexion = new ConexionSQLServer();

        public Cliente(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Cliente() { }
        //string query = "SELECT ID, Cedula, Telefono, Nombre, NombreReferencia, TelefonoReferencia FROM Clientes WHERE ID > 2";
        public List<Cliente> ListaClientes()
        {
            List<Cliente> lstClientes = new List<Cliente>();

            using (SqlCommand comando = new SqlCommand("SELECT ID, Cedula, Telefono, Nombre, NombreReferencia, TelefonoReferencia FROM Clientes WHERE ID > 2", miConexion.conexion))
            {
                miConexion.conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.ID = reader.GetInt32(0);
                    cliente.Cedula = reader.GetString(1);
                    cliente.Telefono = reader.GetString(2);
                    cliente.Nombre = reader.GetString(3);
                    // Manejar valores NULL en NombreReferencia
                    cliente.NombreReferencia = reader.IsDBNull(4) ? null : reader.GetString(4);

                    // Manejar valores NULL en TelefonoReferencia
                    cliente.TelefonoReferencia = reader.IsDBNull(5) ? null : reader.GetString(5);

                    lstClientes.Add(cliente);
                }
                reader.Close();
                miConexion.conexion.Close();
            }

            return lstClientes;
        }

        // Método para obtener ventas por cliente usando el nombre del cliente
        public DataTable ObtenerVentaPorCliente(string nombreCliente)
        {
            DataTable ventasTabla = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crear el comando SQL para ejecutar la función
                    using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.ObtenerVentaPorCliente(@NombreCliente)", connection))
                    {
                        // Agregar el parámetro para el nombre del cliente
                        command.Parameters.AddWithValue("@NombreCliente", nombreCliente);

                        // Ejecutar el comando y llenar el DataTable con los resultados
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(ventasTabla);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return ventasTabla;
        }
    }
}
