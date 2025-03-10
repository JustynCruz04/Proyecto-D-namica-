using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.clases
{
    internal class Proveedor
    {
        public int ID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; }
        public string Direccion { get; set; } = string.Empty;

        ConexionSQLServer miConexion = new ConexionSQLServer();
        private string connectionString;

        public Proveedor(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Proveedor() { }

        public List<Proveedor> ListaProveedorees()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlCommand comando = new SqlCommand("SELECT * FROM Proveedores", miConexion.conexion))
            {
                miConexion.conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Proveedor dato = new Proveedor();
                    dato.ID = reader.GetInt32(0);
                    dato.Nombre = reader.GetString(1);
                    dato.Telefono = reader.GetString(2);
                    dato.Direccion = reader.GetString(3);
                    lista.Add(dato);
                }
                reader.Close();
                miConexion.conexion.Close();
            }

            return lista;
        }

    }
}
