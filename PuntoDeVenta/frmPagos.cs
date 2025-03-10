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
    public partial class frmPagos : Form
    {
        Pagos db = new Pagos();

        private Pagos pagos;
        ConexionSQLServer sqlCon;

        public frmPagos()
        {
            InitializeComponent();

            Pagos db = new Pagos();

            List<Pagos> lista = db.ListaPagos();

            dgvPagos.DataSource = lista;

            //DataGridViewButtonColumn botonModificar = new DataGridViewButtonColumn();
            //botonModificar.Name = "Modificar";
            //botonModificar.HeaderText = "Modificar";
            //botonModificar.Text = "Modificar";
            //botonModificar.UseColumnTextForButtonValue = true;

            //dgvPagos.Columns.Add(botonModificar);

            // Inicializa el servicio con la cadena de conexión a tu base de datos
            string connectionString = "Data Source=.;Initial Catalog=PuntoDeVenta2;Integrated Security=True;"; // Reemplaza con tu cadena de conexión
            pagos = new Pagos(connectionString);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se valida si hay campos vacíos antes de continuar
                if (string.IsNullOrWhiteSpace(txt_ClienteID.Text) ||
                string.IsNullOrWhiteSpace(txt_ProductoID.Text) ||
                string.IsNullOrWhiteSpace(txt_monto.Text) ||
                string.IsNullOrWhiteSpace(txt_usuario.Text) ||
                string.IsNullOrWhiteSpace(txt_CajaID.Text))
                {
                    MessageBox.Show("Por favor, Verifica que todos los campos estén correctos.", "Campos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres agregar este pago?", "Confirmar adición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        sqlCon = new ConexionSQLServer();
                        sqlCon.ejecutarSP_InsertarPago("InsertarPago", txt_ClienteID.Text, txt_ProductoID.Text, Convert.ToDecimal(txt_monto.Text), txt_usuario.Text, txt_CajaID.Text);
                        MessageBox.Show("Se ha ingresado un nuevo pago correctamente.");
                        dgvPagos.DataSource = db.ListaPagos();
                        LimpiarCamposPago();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se valida si hay campos vacíos antes de continuar
                if (string.IsNullOrWhiteSpace(txt_ClienteID.Text) ||
                string.IsNullOrWhiteSpace(txt_ProductoID.Text) ||
                string.IsNullOrWhiteSpace(txt_monto.Text) ||
                string.IsNullOrWhiteSpace(txt_usuario.Text) ||
                string.IsNullOrWhiteSpace(txt_CajaID.Text))
                {
                    MessageBox.Show("Por favor, Verifica que todos los campos estén correctos.", "Campos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres editar este pago?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        sqlCon = new ConexionSQLServer();
                        sqlCon.ejecutarSP_ActualizarPago("EditarPago", txt_ClienteID.Text, txt_ProductoID.Text, Convert.ToDecimal(txt_monto.Text), txt_usuario.Text, txt_CajaID.Text);
                        MessageBox.Show("Se ha actualizado el pago correctamente.");
                        dgvPagos.DataSource = db.ListaPagos();
                        LimpiarCamposPago();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar este pago?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    sqlCon = new ConexionSQLServer();
                    sqlCon.ejecutarSP_EliminarPago("EliminarPago", lblID.Text);
                    MessageBox.Show("Se ha eliminado el pago correctamente.");
                    dgvPagos.DataSource = db.ListaPagos();
                    LimpiarCamposPago();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCamposPago()
        {
            // Se limpian todos los campos de pagos
            txt_ClienteID.Text = "";
            txt_ProductoID.Text = "";
            txt_monto.Text = "";
            txt_usuario.Text = "";
            txt_CajaID.Text = "";
        }

        private void dgvPagos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblID.Text = dgvPagos.CurrentRow.Cells[0].Value.ToString();  // ID del pago
                txt_ClienteID.Text = dgvPagos.CurrentRow.Cells[1].Value.ToString();  // ClienteID
                txt_ProductoID.Text = dgvPagos.CurrentRow.Cells[2].Value.ToString(); // ProductoID
                txt_monto.Text = dgvPagos.CurrentRow.Cells[3].Value.ToString();      // Monto
                txt_usuario.Text = dgvPagos.CurrentRow.Cells[4].Value.ToString();    // Usuario
                txt_CajaID.Text = dgvPagos.CurrentRow.Cells[5].Value.ToString();     // CajaID
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
