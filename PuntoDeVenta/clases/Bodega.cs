using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.clases
{
    internal class Bodega
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public int EmpleadoID { get; set; }
        private string connectionString;

        ConexionSQLServer miConexion = new ConexionSQLServer();

        public Bodega(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Bodega() { }

        public List<Bodega> ListaBodega()
        {
            List<Bodega> lista = new List<Bodega>();

            using (SqlCommand comando = new SqlCommand("SELECT * FROM Bodega", miConexion.conexion))
            {
                miConexion.conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Bodega dato = new Bodega();
                    dato.ID = reader.GetInt32(0);
                    dato.Nombre = reader.GetString(1);
                    dato.Ubicacion = reader.GetString(2);
                    dato.EmpleadoID = reader.GetInt32(3);
                    lista.Add(dato);
                }
                reader.Close();
                miConexion.conexion.Close();
            }

            return lista;
        }

    }
}
