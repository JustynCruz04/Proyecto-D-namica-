using PuntoDeVenta.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            dgvventasMensuales.DataSource = ConexionSQLServer.llenartablaproducto("exec ObtenerVentasMensuales");
            dgvProductoMensual.DataSource = ConexionSQLServer.llenartablaproducto("exec ObtenerTopProductoMensual");
            dgvPagosemanal.DataSource = ConexionSQLServer.llenartablaproducto("exec ObtenerPagosSemanales");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
