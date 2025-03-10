using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PuntoDeVenta.clases
{
    public class Promociones
    {
        public int PromocionID { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal Descuento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int ProductoID { get; set; }
        public int? ClienteID { get; set; } // ClienteID puede ser nulo

        ConexionSQLServer miConexion = new ConexionSQLServer();

        public List<Promociones> ObtenerPromociones()
        {
            List<Promociones> lista = new List<Promociones>();

            using (SqlCommand comando = new SqlCommand("SELECT PromocionID, Descripcion, Descuento, FechaInicio, FechaFin, ProductoID, ClienteID FROM Promociones", miConexion.conexion))
            {
                miConexion.conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Promociones promo = new Promociones
                    {
                        PromocionID = reader.GetInt32(0),
                        Descripcion = reader.GetString(1),
                        Descuento = reader.GetDecimal(2),
                        FechaInicio = reader.GetDateTime(3),
                        FechaFin = reader.GetDateTime(4),
                        ProductoID = reader.GetInt32(5),
                        ClienteID = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6)
                    };
                    lista.Add(promo);
                }
                reader.Close();
                miConexion.conexion.Close();
            }

            return lista;
        }

        public bool GuardarPromocion()
        {
            try
            {
                string query = "INSERT INTO Promociones (Descripcion, Descuento, FechaInicio, FechaFin, ProductoID, ClienteID) " +
                               "VALUES (@Descripcion, @Descuento, @FechaInicio, @FechaFin, @ProductoID, @ClienteID)";

                using (SqlCommand comando = new SqlCommand(query, miConexion.conexion))
                {
                    comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                    comando.Parameters.AddWithValue("@Descuento", Descuento);
                    comando.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                    comando.Parameters.AddWithValue("@FechaFin", FechaFin);
                    comando.Parameters.AddWithValue("@ProductoID", ProductoID);
                    comando.Parameters.AddWithValue("@ClienteID", (object)ClienteID ?? DBNull.Value);

                    miConexion.conexion.Open();
                    comando.ExecuteNonQuery();
                    miConexion.conexion.Close();
                }
                return true; // Retorna verdadero si se insertó correctamente
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al guardar la promoción: " + ex.Message);
                return false; // Retorna falso si hubo un error
            }
        }
    }
}
