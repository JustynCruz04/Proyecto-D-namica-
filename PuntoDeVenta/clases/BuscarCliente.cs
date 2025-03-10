using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.clases
{
    public class BuscarCliente
    {
        public int ID { get; set; } 
        public string Cedula { get; set; } 
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string NombreReferencia { get; set; }
        public string TelefonoReferencia { get; set; }

        public BuscarCliente(int id, string cedula, string telefono, string nombre, string nombreReferencia, string telefonoReferencia)
        {
            ID = id;
            Cedula = cedula;
            Telefono = telefono;
            Nombre = nombre;
            NombreReferencia = nombreReferencia;
            TelefonoReferencia = telefonoReferencia;
        }
        public BuscarCliente() { }
    }
}

