using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.clases
{
    internal class Caja
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; } 
        public string Descripcion { get; set; }
        public decimal Monto { get; set; } 
        public string Tipo { get; set; }
        public int EmpleadoID { get; set; }

        private string connectionString;

        ConexionSQLServer miConexion = new ConexionSQLServer();

        public Caja(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Caja() { }

        public List<Caja> ListaCajaIngreso()
        {
            List<Caja> lista = new List<Caja>();

            using (SqlCommand comando = new SqlCommand("SELECT * FROM Caja where Tipo = 'Ingreso'", miConexion.conexion))
            {
                miConexion.conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Caja dato = new Caja();
                    dato.ID = reader.GetInt32(0);
                    dato.Fecha = reader.GetDateTime(1);
                    dato.Descripcion = reader.GetString(2);
                    dato.Monto = reader.GetDecimal(3);
                    dato.Tipo = reader.GetString(4);
                    dato.EmpleadoID = reader.GetInt32(5);
                    lista.Add(dato);
                }
                reader.Close();
                miConexion.conexion.Close();
            }

            return lista;
        }

        public List<Caja> ListaCajaEgreso()
        {
            List<Caja> lista = new List<Caja>();

            using (SqlCommand comando = new SqlCommand("SELECT * FROM Caja where Tipo = 'Egreso'", miConexion.conexion))
            {
                miConexion.conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Caja dato = new Caja();
                    dato.ID = reader.GetInt32(0);
                    dato.Fecha = reader.GetDateTime(1);
                    dato.Descripcion = reader.GetString(2);
                    dato.Monto = reader.GetDecimal(3);
                    dato.Tipo = reader.GetString(4);
                    dato.EmpleadoID = reader.GetInt32(5);
                    lista.Add(dato);
                }
                reader.Close();
                miConexion.conexion.Close();
            }

            return lista;
        }

    }
}
