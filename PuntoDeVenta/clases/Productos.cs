using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.clases
{
    public class Productos
    {
        public int ID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string CodigoBarra { get; set; } = string.Empty;
        public decimal PrecioCompra { get; set; } 
        public decimal PrecioVenta { get; set; }
        public int Existencia { get; set; } 
        public int StookMinimo { get; set; }
        public int ProveedorID { get; set; } 
        public int BodegaID { get; set; }
        public int IVA { get; set; }
        public bool Estado { get; set; }

        private string connectionString;

        public Productos(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Productos() { }

        ConexionSQLServer miConexion = new ConexionSQLServer();



        public class ProductosVenta {
            public string Nombre { get; set; } = string.Empty;
            public string CodigoBarra { get; set; } = string.Empty;
            public decimal PrecioVenta { get; set; }
        }
        

        public List<Productos> ListaProductos()
        {
            List<Productos> lista = new List<Productos>();

            using (SqlCommand comando = new SqlCommand("SELECT ID,Nombre,CodigoBarra,PrecioCompra,PrecioVenta,Existencia,StockMinimo,ProveedorID,BodegaID,I.Porcentaje as IVA, Estado, inicio_precompra,fin_precompra  FROM Productos as P\r\njoin tbIVA as I on P.CodIVa=I.CodIVA", miConexion.conexion))
            {
                miConexion.conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Productos dato = new Productos();
                    dato.ID = reader.GetInt32(0);
                    dato.Nombre = reader.GetString(1);
                    dato.CodigoBarra = reader.GetString(2);
                    dato.PrecioCompra = reader.GetDecimal(3);
                    dato.PrecioVenta = reader.GetDecimal(4);
                    dato.Existencia = reader.GetInt32(5);
                    dato.StookMinimo = reader.GetInt32(6);
                    dato.ProveedorID = reader.GetInt32(7);
                    dato.BodegaID = reader.GetInt32(8);
                    dato.IVA = reader.GetInt32(9);
                    dato.Estado = reader.GetBoolean(10);
                    lista.Add(dato);
                }
                reader.Close();
                miConexion.conexion.Close();
            }

            return lista;
        }


        public List<ProductosVenta> ListaProductosVenta()
        {
            List<ProductosVenta> lista = new List<ProductosVenta>();

            using (SqlCommand comando = new SqlCommand("SELECT Nombre, CodigoBarra, PrecioVenta FROM Productos", miConexion.conexion))
            {
                miConexion.conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    ProductosVenta dato = new ProductosVenta();
                    dato.Nombre = reader.GetString(0);
                    dato.CodigoBarra = reader.GetString(1);
                    dato.PrecioVenta = reader.GetDecimal(2);
                    lista.Add(dato);
                }
                reader.Close();
                miConexion.conexion.Close();
            }

            return lista;
        }


    }
}
