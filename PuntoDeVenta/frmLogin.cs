using PuntoDeVenta.clases;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class frmLogin : Form
    {
        private frmPrincipal frm;

        public frmLogin(frmPrincipal existefrm)
        {
            InitializeComponent();
            frm = existefrm;

            txtUsuario.KeyDown += new KeyEventHandler(txt_KeyDown);
            txtClave.KeyDown += new KeyEventHandler(txt_KeyDown);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(45, 84, 99);
            int borderWidth = 1;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1));
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MostrarError("Por favor, complete todos los campos.");
                return;
            }

            DatosGlobales.usuario = usuario;
            DatosGlobales.clave = clave;

            ConexionSQLServer miConexion = new ConexionSQLServer();

            try
            {
                miConexion.conexion.Open();

                // Aquí deberías añadir la lógica para validar al usuario en la base de datos.
                // Ejemplo de pseudo-código:
                // bool esValido = ValidarUsuario(usuario, clave, miConexion);
                // if (!esValido)
                // {
                //     MostrarError("Usuario o contraseña incorrectos.");
                //     return;
                // }

                frm.InicioSesion();
                this.Close();
            }
            catch (SqlException ex)
            {
                MostrarError("Error de conexión a la base de datos. Por favor, inténtelo de nuevo." + ex.ToString());
            }
            finally
            {
                if (miConexion.conexion.State == System.Data.ConnectionState.Open)
                {
                    miConexion.conexion.Close();
                }
            }
        }

        private void MostrarError(string mensaje)
        {
            // Puedes personalizar este método para mostrar errores en una etiqueta o cuadro de mensaje.
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        // Eventos vacíos, pueden ser eliminados si no se utilizan.
        private void txtClave_TextChanged(object sender, EventArgs e) { }
        private void lblClave_Click(object sender, EventArgs e) { }
        private void lblUsuario_Click(object sender, EventArgs e) { }
        private void txtUsuario_TextChanged(object sender, EventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }
    }
}
