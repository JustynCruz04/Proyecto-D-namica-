using PuntoDeVenta.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PuntoDeVenta
{
    public partial class frmApartar : Form
    {
        private frmVender frm;

        private int semanas = 1;
        public frmApartar(frmVender exisfrm)
        {
            InitializeComponent();
            frm = exisfrm;
            lbCliente.Text = frm.listaClientes.ClienteSeleccionado.Nombre;
            lbMonto.Text = frm.txtTotal.Text.ToString();
            lbFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbRestante.Text = lbMonto.Text;
            lbTotal.Text = frm.txtTotal.Text.ToString();
            lbSemanal.Text = "0 Semanas";
            cbTipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoPago.SelectedIndex = 0;
            cbCaja.DropDownStyle = ComboBoxStyle.DropDownList;
            lbCuotas.Text = lbRestante.Text;

            lbProducto.Text = frm.dgvDetalledeventas.Rows[0].Cells["Nombre"].Value.ToString();

            Caja db = new Caja();
            List<Caja> listaingreso = db.ListaCajaIngreso();

            cbCaja.DataSource = listaingreso;
            cbCaja.DisplayMember = "Descripcion";
            cbCaja.ValueMember = "ID";
            cbCaja.SelectedIndex = 0;

        }

        private void txtCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDecimal(e);
        }

        private void txtAnticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDecimal(e);
        }


        private void frmApartar_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(45, 84, 99);
            int borderWidth = 1;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1));
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Apartar();
        }


        public void soloDecimal(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && txtAnticipo.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void txtAnticipo_TextChanged(object sender, EventArgs e)
        {
            string txtActual = txtAnticipo.Text;
            if (txtActual != "")
            {
                if (txtActual.EndsWith(","))
                {
                    lbRestante.Text = ((decimal.Parse(lbMonto.Text)) - (decimal.Parse(txtActual + "00"))).ToString("N2");
                    lbCuotas.Text = (decimal.Parse(lbRestante.Text) / semanas).ToString("N2");
                }
                else
                {
                    lbRestante.Text = ((decimal.Parse(lbMonto.Text)) - (decimal.Parse(txtActual))).ToString("N2");
                    lbCuotas.Text = (decimal.Parse(lbRestante.Text) / semanas).ToString("N2");
                }
            }
            else
            {
                lbRestante.Text = lbMonto.Text;
                lbCuotas.Text = (decimal.Parse(lbRestante.Text) / semanas).ToString("N2");
            }

        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtFinal.Value;

            DateTime fechaActual = DateTime.Now;

            TimeSpan diferencia = fechaSeleccionada - fechaActual;

            double cantidadSemanas = diferencia.TotalDays / 7;

            semanas = (int)Math.Ceiling(cantidadSemanas);

            lbSemanal.Text = semanas.ToString() + " Semanas.";

            decimal restante = decimal.Parse(lbRestante.Text);

            if (restante != 0)
            {
                lbCuotas.Text = (restante / semanas).ToString("N2");
            }

        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (semanas <= 1)
                {
                    MessageBox.Show("Debe haber más de 1 semana para las cuotas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtTAG.Text == "")
                {
                    MessageBox.Show("No ha agregado un TAG", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (decimal.Parse(txtAnticipo.Text) < 0 && txtAnticipo.Text == "")
                {
                    MessageBox.Show("Asegúrese de que el anticipo tenga un valor y sea positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frm.GuardarVentaCompleta();
                GuardarPagoCompleta();

                // Eliminar la lógica de disminución de inventario aquí
                // La lógica para disminuir el inventario debe ir solo cuando se completa la venta

                MessageBox.Show("Apartado de producto realizado con éxito.", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el apartado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GuardarPagoCompleta()
        {


            try
            {
                Pagos datos = new Pagos();
                datos.ClienteID = frm.listaClientes.ClienteSeleccionado.ID;
                datos.ProductoID = (int)frm.dgvDetalledeventas.Rows[0].Cells["ID"].Value;
                datos.Monto = decimal.Parse(lbMonto.Text);
                datos.Antiicipo = decimal.Parse(txtAnticipo.Text);
                datos.Restante = decimal.Parse(lbRestante.Text);
                datos.FechaApartado = DateTime.Now;
                datos.FechaVencimiento = dtFinal.Value;
                datos.Usuario = frm.listaClientes.ClienteSeleccionado.Nombre;
                datos.TipoPago = cbTipoPago.Text;
                datos.Cuotas = (int)Math.Round(decimal.Parse(lbCuotas.Text));
                datos.TotalPagar = decimal.Parse(lbTotal.Text);
                datos.TAG = txtTAG.Text;
                datos.CajaID = (int)cbCaja.SelectedValue;
                datos.InsertarPago(datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el apartado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
