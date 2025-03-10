using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.clases
{
    internal class Categoria
    {
        public int CategoriaID { get; set; }
        public string NombreCategoria { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        public Categoria() { }

        ConexionSQLServer miConexion = new ConexionSQLServer();
        public bool InsertarCategoria(string nombreCategoria, string descripcion)
        {
            try
            {
                miConexion.abrirConexion1();
                SqlCommand comando = new SqlCommand("InsertarCategoria", miConexion.conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreCategoria", nombreCategoria);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                int resultado = comando.ExecuteNonQuery();
                miConexion.cerrarConexion();
                return resultado > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al insertar categoría: " + e.Message);
                return false;
            }
        }

        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            try
            {
                miConexion.abrirConexion1();
                SqlCommand comando = new SqlCommand("SELECT CategoriaID, NombreCategoria, Descripcion FROM Categoria", miConexion.conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Categoria categoria = new Categoria()
                    {
                        CategoriaID = reader.GetInt32(0),
                        NombreCategoria = reader.GetString(1),
                        Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2)
                    };

                    lista.Add(categoria);
                }
                reader.Close();
                miConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al obtener categorías: " + e.Message);
            }
            return lista;
        }
    }
}
