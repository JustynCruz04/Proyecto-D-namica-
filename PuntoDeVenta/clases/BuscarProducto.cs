using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    public class BuscarProducto
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string CodigoBarra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int StockMinimo { get; set; }
        public int Existencia { get; set; }

        public BuscarProducto() { }
    }
}

