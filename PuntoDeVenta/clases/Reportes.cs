using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.clases
{
    internal class Reportes
    {

        ConexionSQLServer miConexion = new ConexionSQLServer();

        public DataTable ListaClientes()
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM Clientes", miConexion.conexion);
            miConexion.conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            dataAdapter.Fill(tabla);
            miConexion.conexion.Close();

            return tabla;
        }

        public DataTable VentasProducto()
        {
            SqlCommand comando = new SqlCommand("select p.Nombre, sum(d.Cantidad) as Cantidad, sum(p.PrecioVenta) as Total " +
                "from Ventas V inner join DetalleVenta D on v.ID = d.VentaID inner join Productos p on p.ID= d.ProductoID " +
                "group by p.Nombre, d.Cantidad, p.PrecioVenta", miConexion.conexion);
                miConexion.conexion.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                dataAdapter.Fill(tabla);
                miConexion.conexion.Close();

            return tabla;
        }

        public DataTable VentasClientes()
        {
            SqlCommand comando = new SqlCommand("select c.Nombre, sum(d.Cantidad) as Cantidad, sum(p.PrecioVenta) as Total " +
                "from Ventas V inner join DetalleVenta D on v.ID = d.VentaID inner join Productos p on p.ID = d.ProductoID  inner join Clientes c on c.ID = v.ClienteID " +
                "group by c.Nombre, d.Cantidad, p.PrecioVenta", miConexion.conexion);
            miConexion.conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            dataAdapter.Fill(tabla);
            miConexion.conexion.Close();

            return tabla;
        }

        public DataTable ListaProductos()
        {
            SqlCommand comando = new SqlCommand("select * from Productos", miConexion.conexion);
            miConexion.conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            dataAdapter.Fill(tabla);
            miConexion.conexion.Close();

            return tabla;
        }

        public DataTable VentasMes()
        {
            SqlCommand comando = new SqlCommand("select YEAR(Fecha) AS Año,MONTH(Fecha) AS Mes, SUM(Total) AS Total, COUNT(*) AS Cantidad " +
                "FROM Ventas " +
                "GROUP BY YEAR(Fecha), MONTH(Fecha)\r\nORDER BY Año, Mes;", miConexion.conexion);
            miConexion.conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            dataAdapter.Fill(tabla);
            miConexion.conexion.Close();

            return tabla;
        }

    }
}
