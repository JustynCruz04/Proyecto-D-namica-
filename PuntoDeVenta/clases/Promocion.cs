using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.clases
{
    internal class Promocion
    {

        public int IDPromo { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal Descuento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

    

       

        ConexionSQLServer miConexion = new ConexionSQLServer();

        public bool RegistrarCombo(string Descripcion, decimal Descuento, decimal Total, DateTime FInicio, DateTime FFinal, DataGridView DetalleCombo)
        {
            try
            {
                using (SqlConnection conn = ConexionSQLServer.abrirConexion())
                {
                    // Primero, insertar el Combo
                    SqlCommand cmdCombo = new SqlCommand("GuardarCombo", conn);
                    cmdCombo.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros al comando para el Combo
                    cmdCombo.Parameters.AddWithValue("@Descripcion", Descripcion);
                    cmdCombo.Parameters.AddWithValue("@Descuento", Descuento);
                    cmdCombo.Parameters.AddWithValue("@Total", Total);
                    cmdCombo.Parameters.AddWithValue("@FechaInicio", FInicio);
                    cmdCombo.Parameters.AddWithValue("@FechaFin", FFinal);

                    // Parámetro de salida para obtener el ID generado
                    SqlParameter idComboParam = new SqlParameter("@IDCombo", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmdCombo.Parameters.Add(idComboParam);

                    // Ejecutar el comando
                    cmdCombo.ExecuteNonQuery();

                    // Obtener el IDCombo generado
                    int idCombo = (int)idComboParam.Value;

                    // Insertar los detalles del combo
                    foreach (DataGridViewRow row in DetalleCombo.Rows)
                    {
                        if (row.IsNewRow) continue;

                        SqlCommand cmdDetalle = new SqlCommand("GuardarDetalleCombo", conn);
                        cmdDetalle.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros al comando para el DetalleCombo
                        cmdDetalle.Parameters.AddWithValue("@IDCombo", idCombo);
                        cmdDetalle.Parameters.AddWithValue("@IDProducto", Convert.ToInt32(row.Cells["DCIDProducto"].Value));
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(row.Cells["DCCantidad"].Value));

                        // Ejecutar el comando
                        cmdDetalle.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }

}
