using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.clases
{
    internal class Pagos
    {
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public int ProductoID { get; set; }
        public decimal Monto { get; set; }
        public decimal Antiicipo { get; set; }
        public decimal Restante { get; set; }
        public DateTime FechaApartado{ get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Usuario { get; set; }
        public string TipoPago { get; set; }
        public int Cuotas { get; set; }
        public decimal TotalPagar { get; set; }
        public string TAG { get; set; }
        public int CajaID { get; set; }

        private string connectionString;

        ConexionSQLServer miConexion = new ConexionSQLServer();

        public Pagos(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Pagos() { }



        public List<Pagos> ListaPagos()
        {
            List<Pagos> lista = new List<Pagos>();

            using (SqlCommand comando = new SqlCommand("SELECT * FROM PagosAlTotal", miConexion.conexion))
            {
                miConexion.conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Pagos dato = new Pagos();
                    dato.ID = reader.GetInt32(0);
                    dato.ClienteID = reader.GetInt32(1);
                    dato.ProductoID = reader.GetInt32(2);
                    dato.Monto = reader.GetDecimal(3);
                    dato.Usuario = reader.GetString(4);
                    dato.CajaID = reader.GetInt32(5);
                    lista.Add(dato);
                }
                reader.Close();
                miConexion.conexion.Close();
            }

            return lista;
        }

        public void InsertarPago(Pagos pago)
        {
            using (SqlCommand comando = new SqlCommand("INSERT INTO PagosACredito ([ClienteID],[ProductoID],[Monto],[Anticipo],[Restante],[FechaApartado],[FechaVencimiento],[Usuario],[TipoPago],[Cuotas],[TotalAPagar],[TAG],[CajaID]) " +
                "VALUES (@CLIENTE,@PRODUCTO, @MONTO, @ANTICIPO, @RESTANTE, @FECHAA, @FECHAV, @USUARIO, @TIPOPAGO, @CUOTAS, @TOTAL, @TAG, @CAJA)", miConexion.conexion))
            {
                miConexion.conexion.Open();
                comando.Parameters.AddWithValue("@CLIENTE", pago.ClienteID);
                comando.Parameters.AddWithValue("@PRODUCTO", pago.ProductoID);
                comando.Parameters.AddWithValue("@MONTO", pago.Monto);
                comando.Parameters.AddWithValue("@ANTICIPO", pago.Antiicipo);
                comando.Parameters.AddWithValue("@RESTANTE", pago.Restante);
                comando.Parameters.AddWithValue("@FECHAA", pago.FechaApartado);
                comando.Parameters.AddWithValue("@FECHAV", pago.FechaVencimiento);
                comando.Parameters.AddWithValue("@USUARIO", pago.Usuario);
                comando.Parameters.AddWithValue("@TIPOPAGO", pago.TipoPago);
                comando.Parameters.AddWithValue("@CUOTAS", pago.Cuotas);
                comando.Parameters.AddWithValue("@TOTAL", pago.TotalPagar);
                comando.Parameters.AddWithValue("@TAG", pago.TAG);
                comando.Parameters.AddWithValue("@CAJA", pago.CajaID);
                comando.ExecuteNonQuery();
                miConexion.conexion.Close();
            }
        }


    }
}
