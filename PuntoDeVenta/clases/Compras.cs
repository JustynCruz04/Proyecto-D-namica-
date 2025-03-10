using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PuntoDeVenta.clases
{
    internal class Compras
    {
        public int ID { get; set; }
        public string NombreProveedor { get; set; } = string.Empty;
        public string NombreEmpleado { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        ConexionSQLServer miConexion = new ConexionSQLServer();

        public List<Compras> ListaCompras()
        {
            List<Compras> lista = new List<Compras>();

            using (SqlCommand comando = new SqlCommand("SELECT c.ID, p.Nombre AS NombreProveedor, e.usuario AS NombreEmpleado, c.Fecha, c.Total FROM Compras c INNER JOIN Proveedores p ON c.ProveedorID = p.ID INNER JOIN Empleado e ON c.EmpleadoID = e.ID", miConexion.conexion))
            {
                miConexion.conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Compras dato = new Compras();
                    dato.ID = reader.GetInt32(0); 
                    dato.NombreProveedor = reader.GetString(1); 
                    dato.NombreEmpleado = reader.GetString(2); 
           
                    dato.Fecha = reader.GetDateTime(3); 
                    dato.Total = reader.GetDecimal(4); 
                    lista.Add(dato);
                }
                reader.Close();
                miConexion.conexion.Close();
            }

            return lista;
        }
    }
}
