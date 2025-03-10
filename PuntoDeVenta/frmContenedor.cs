

namespace PuntoDeVenta
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            pnMenu.Visible = false;
            pnMenu.Enabled = false;

            pnLogin.Left = (this.Size.Width - pnLogin.Width) / 2;
            pnLogin.Top = (this.Size.Height - pnLogin.Height) / 2;

            frmLogin frm = new frmLogin(this);

            frm.TopLevel = false;

            pnLogin.Controls.Clear();

            pnLogin.Controls.Add(frm);

            frm.Dock = DockStyle.Fill;

            frm.Show();


        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public void InicioSesion()
        {
            pnMenu.Visible = true;
            pnMenu.Enabled = true;
            pnLogin.Visible = false;
            pnLogin.Enabled = false;
        }

        public void IniciarPreCompra() {
            frmPreCompra frm = new frmPreCompra(this);
            LlenarPanelFormulario(frm);
            btnPreCompra.BackColor = Color.FromArgb(42, 157, 143);
        }

        public void IniciarPreCompraRealizadas()
        {
            frmPreCompraRealizadas frm = new frmPreCompraRealizadas(this);
            LlenarPanelFormulario(frm);
            btnPreCompra.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void pnSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void pnSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            dragging = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(45, 84, 99);
            int borderWidth = 1;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1));
            }
        }

        private void LlenarPanelFormulario(Form formulario)
        {
            btnInicio.BackColor = Color.FromArgb(38, 70, 83);
            btnVender.BackColor = Color.FromArgb(38, 70, 83);
            //btnComprar.BackColor = Color.FromArgb(38, 70, 83);
            btnProducto.BackColor = Color.FromArgb(38, 70, 83);
            btnBodega.BackColor = Color.FromArgb(38, 70, 83);
            btnPagos.BackColor = Color.FromArgb(38, 70, 83);
            btnClientes.BackColor = Color.FromArgb(38, 70, 83);
            btnProveedores.BackColor = Color.FromArgb(38, 70, 83);
            btnCaja.BackColor = Color.FromArgb(38, 70, 83);
            btnReportes.BackColor = Color.FromArgb(38, 70, 83);
            btnPreCompra.BackColor = Color.FromArgb(38, 70, 83);

            formulario.TopLevel = false;

            pnContenido.Controls.Clear();

            pnContenido.Controls.Add(formulario);

            formulario.Dock = DockStyle.Fill;

            formulario.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            LlenarPanelFormulario(frm);
            btnInicio.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            frmVender frm = new frmVender();
            LlenarPanelFormulario(frm);
            btnVender.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            frmComprar frm = new frmComprar();
            LlenarPanelFormulario(frm);
            //btnComprar.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            LlenarPanelFormulario(frm);
            btnProducto.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void btnBodega_Click(object sender, EventArgs e)
        {
            frmBodega frm = new frmBodega();
            LlenarPanelFormulario(frm);
            btnBodega.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            frmPagos frm = new frmPagos();
            LlenarPanelFormulario(frm);
            btnPagos.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            LlenarPanelFormulario(frm);
            btnClientes.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            LlenarPanelFormulario(frm);
            btnProveedores.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            frmCaja frm = new frmCaja();
            LlenarPanelFormulario(frm);
            btnCaja.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            LlenarPanelFormulario(frm);
            btnReportes.BackColor = Color.FromArgb(42, 157, 143);
        }

        private void btnPreCompra_Click(object sender, EventArgs e)
        {
            frmPreCompra frm = new frmPreCompra(this);
            LlenarPanelFormulario(frm);
            btnPreCompra.BackColor = Color.FromArgb(42, 157, 143);
        }
    }
}
