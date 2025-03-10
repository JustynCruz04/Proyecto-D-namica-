using PuntoDeVenta.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class frmCaja : Form
    {
        Caja db = new Caja();
        private Caja caja;
        ConexionSQLServer sqlCon;

        public frmCaja()
        {
            InitializeComponent();

            // Inicializar las listas de ingresos y egresos
            Caja db = new Caja();
            List<Caja> listaingreso = db.ListaCajaIngreso();
            List<Caja> listaegreso = db.ListaCajaEgreso();

            dgvCajasIngresos.DataSource = listaingreso;
            dgvCajaEgresos.DataSource = listaegreso;

            string connectionString = "Data Source=.;Initial Catalog=PuntoDeVenta2;Integrated Security=True;";
            caja = new Caja(connectionString);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay campos vacíos antes de continuar (eliminamos las referencias a los TextBox eliminados)
                if (string.IsNullOrWhiteSpace(txt_descripcionCaja.Text) ||
                    string.IsNullOrWhiteSpace(txt_montoCaja.Text))
                {
                    MessageBox.Show("Por favor, verifica que todos los campos estén correctos.", "Campos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres agregar estos datos?", "Confirmar adición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    string seleccion = cmbtipocaja.SelectedItem.ToString();
                    DateTime fechaCaja = dtp_FechaCaja.Value;  // Capturar la fecha del DateTimePicker

                    if (resultado == DialogResult.Yes)
                    {
                        sqlCon = new ConexionSQLServer();
                        sqlCon.ejecutarSP_InsertarCaja("InsertarCaja", txt_descripcionCaja.Text, seleccion, Convert.ToDecimal(txt_montoCaja.Text), fechaCaja);
                        MessageBox.Show("Se ha ingresado nueva caja correctamente.");
                        dgvCajaEgresos.DataSource = db.ListaCajaEgreso();
                        dgvCajasIngresos.DataSource = db.ListaCajaIngreso();
                        LimpiarCamposCaja();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay campos vacíos antes de continuar
                if (string.IsNullOrWhiteSpace(txt_descripcionCaja.Text) ||
                    string.IsNullOrWhiteSpace(txt_montoCaja.Text))
                {
                    MessageBox.Show("Por favor, verifica que todos los campos estén correctos.", "Campos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres editar estos datos?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    string seleccion = cmbtipocaja.SelectedItem.ToString();
                    DateTime fechaCaja = dtp_FechaCaja.Value;  // Capturar la fecha del DateTimePicker

                    if (resultado == DialogResult.Yes)
                    {
                        sqlCon = new ConexionSQLServer();
                        sqlCon.ejecutarSP_ActualizarCaja("EditarCaja", lblIDCaja.Text, txt_descripcionCaja.Text, seleccion, txt_montoCaja.Text, fechaCaja);
                        MessageBox.Show("Se ha actualizado la caja correctamente.");
                        dgvCajaEgresos.DataSource = db.ListaCajaIngreso();
                        dgvCajasIngresos.DataSource = db.ListaCajaEgreso();
                        LimpiarCamposCaja();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar estos datos?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    sqlCon = new ConexionSQLServer();
                    sqlCon.ejecutarSP_EliminarCaja("EliminarCaja", lblIDCaja.Text);
                    MessageBox.Show("Se ha eliminado la caja correctamente.");
                    dgvCajaEgresos.DataSource = db.ListaCajaEgreso();
                    dgvCajasIngresos.DataSource = db.ListaCajaIngreso();
                    LimpiarCamposCaja();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCamposCaja()
        {
            txt_descripcionCaja.Text = "";
            txt_montoCaja.Text = "";
            dtp_FechaCaja.Value = DateTime.Now;  // Resetear el DateTimePicker a la fecha actual
            cmbtipocaja.SelectedIndex = -1;

        }

        private void dgvCajas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblIDCaja.Text = dgvCajasIngresos.CurrentRow.Cells[0].Value.ToString();
                dtp_FechaCaja.Value = Convert.ToDateTime(dgvCajasIngresos.CurrentRow.Cells[1].Value);  // Asignar la fecha al DateTimePicker
                txt_descripcionCaja.Text = dgvCajasIngresos.CurrentRow.Cells[2].Value.ToString();
                txt_montoCaja.Text = dgvCajasIngresos.CurrentRow.Cells[3].Value.ToString();

                // Asignar el valor del tipo de caja al ComboBox
                string tipoCaja = dgvCajasIngresos.CurrentRow.Cells[4].Value.ToString();
                cmbtipocaja.SelectedItem = tipoCaja;  // Seleccionar el valor en el ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCajaEgresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblIDCaja.Text = dgvCajaEgresos.CurrentRow.Cells[0].Value.ToString();
                dtp_FechaCaja.Value = Convert.ToDateTime(dgvCajaEgresos.CurrentRow.Cells[1].Value);  // Asignar la fecha al DateTimePicker
                txt_descripcionCaja.Text = dgvCajaEgresos.CurrentRow.Cells[2].Value.ToString();
                txt_montoCaja.Text = dgvCajaEgresos.CurrentRow.Cells[3].Value.ToString();

                // Asignar el valor del tipo de caja al ComboBox
                string tipoCaja = dgvCajaEgresos.CurrentRow.Cells[4].Value.ToString();
                cmbtipocaja.SelectedItem = tipoCaja;  // Seleccionar el valor en el ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmCaja_Load(object sender, EventArgs e)
        {

        }
    }
}
