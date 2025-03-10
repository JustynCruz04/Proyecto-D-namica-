namespace PuntoDeVenta
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            panel1 = new Panel();
            pnMenu = new Panel();
            btnReportes = new Button();
            btnCaja = new Button();
            btnProveedores = new Button();
            btnClientes = new Button();
            btnPagos = new Button();
            btnBodega = new Button();
            btnProducto = new Button();
            btnPreCompra = new Button();
            btnVender = new Button();
            btnInicio = new Button();
            pnRedes = new Panel();
            pnLogo = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnSuperior = new Panel();
            btnCerrar = new Button();
            pnContenido = new Panel();
            pnLogin = new Panel();
            panel1.SuspendLayout();
            pnMenu.SuspendLayout();
            pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 70, 83);
            panel1.Controls.Add(pnMenu);
            panel1.Controls.Add(pnRedes);
            panel1.Controls.Add(pnLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 589);
            panel1.TabIndex = 0;
            // 
            // pnMenu
            // 
            pnMenu.Controls.Add(btnReportes);
            pnMenu.Controls.Add(btnCaja);
            pnMenu.Controls.Add(btnProveedores);
            pnMenu.Controls.Add(btnClientes);
            pnMenu.Controls.Add(btnPagos);
            pnMenu.Controls.Add(btnBodega);
            pnMenu.Controls.Add(btnProducto);
            pnMenu.Controls.Add(btnPreCompra);
            pnMenu.Controls.Add(btnVender);
            pnMenu.Controls.Add(btnInicio);
            pnMenu.Dock = DockStyle.Fill;
            pnMenu.Location = new Point(0, 75);
            pnMenu.Margin = new Padding(3, 2, 3, 2);
            pnMenu.Name = "pnMenu";
            pnMenu.Padding = new Padding(9, 8, 9, 8);
            pnMenu.Size = new Size(219, 454);
            pnMenu.TabIndex = 1;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(9, 350);
            btnReportes.Margin = new Padding(3, 2, 3, 2);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(9, 0, 9, 0);
            btnReportes.Size = new Size(201, 38);
            btnReportes.TabIndex = 9;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnCaja
            // 
            btnCaja.Dock = DockStyle.Top;
            btnCaja.FlatAppearance.BorderSize = 0;
            btnCaja.FlatStyle = FlatStyle.Flat;
            btnCaja.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCaja.ForeColor = Color.White;
            btnCaja.Image = (Image)resources.GetObject("btnCaja.Image");
            btnCaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaja.Location = new Point(9, 312);
            btnCaja.Margin = new Padding(3, 2, 3, 2);
            btnCaja.Name = "btnCaja";
            btnCaja.Padding = new Padding(9, 0, 9, 0);
            btnCaja.Size = new Size(201, 38);
            btnCaja.TabIndex = 1;
            btnCaja.Text = "Caja";
            btnCaja.UseVisualStyleBackColor = true;
            btnCaja.Click += btnCaja_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Image = Properties.Resources.proveedor;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(9, 274);
            btnProveedores.Margin = new Padding(3, 2, 3, 2);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(9, 0, 9, 0);
            btnProveedores.Size = new Size(201, 38);
            btnProveedores.TabIndex = 8;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = Properties.Resources.clientes;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(9, 236);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(9, 0, 9, 0);
            btnClientes.Size = new Size(201, 38);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnPagos
            // 
            btnPagos.Dock = DockStyle.Top;
            btnPagos.FlatAppearance.BorderSize = 0;
            btnPagos.FlatStyle = FlatStyle.Flat;
            btnPagos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagos.ForeColor = Color.White;
            btnPagos.Image = Properties.Resources.pagos;
            btnPagos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagos.Location = new Point(9, 198);
            btnPagos.Margin = new Padding(3, 2, 3, 2);
            btnPagos.Name = "btnPagos";
            btnPagos.Padding = new Padding(9, 0, 9, 0);
            btnPagos.Size = new Size(201, 38);
            btnPagos.TabIndex = 6;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnBodega
            // 
            btnBodega.Dock = DockStyle.Top;
            btnBodega.FlatAppearance.BorderSize = 0;
            btnBodega.FlatStyle = FlatStyle.Flat;
            btnBodega.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBodega.ForeColor = Color.White;
            btnBodega.Image = Properties.Resources.bodega;
            btnBodega.ImageAlign = ContentAlignment.MiddleLeft;
            btnBodega.Location = new Point(9, 160);
            btnBodega.Margin = new Padding(3, 2, 3, 2);
            btnBodega.Name = "btnBodega";
            btnBodega.Padding = new Padding(9, 0, 9, 0);
            btnBodega.Size = new Size(201, 38);
            btnBodega.TabIndex = 5;
            btnBodega.Text = "Bodega";
            btnBodega.UseVisualStyleBackColor = true;
            btnBodega.Click += btnBodega_Click;
            // 
            // btnProducto
            // 
            btnProducto.Dock = DockStyle.Top;
            btnProducto.FlatAppearance.BorderSize = 0;
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducto.ForeColor = Color.White;
            btnProducto.Image = Properties.Resources.productos;
            btnProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducto.Location = new Point(9, 122);
            btnProducto.Margin = new Padding(3, 2, 3, 2);
            btnProducto.Name = "btnProducto";
            btnProducto.Padding = new Padding(9, 0, 9, 0);
            btnProducto.Size = new Size(201, 38);
            btnProducto.TabIndex = 4;
            btnProducto.Text = "Productos";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnPreCompra
            // 
            btnPreCompra.Dock = DockStyle.Top;
            btnPreCompra.FlatAppearance.BorderSize = 0;
            btnPreCompra.FlatStyle = FlatStyle.Flat;
            btnPreCompra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreCompra.ForeColor = Color.White;
            btnPreCompra.Image = Properties.Resources.precompra;
            btnPreCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnPreCompra.Location = new Point(9, 84);
            btnPreCompra.Margin = new Padding(3, 2, 3, 2);
            btnPreCompra.Name = "btnPreCompra";
            btnPreCompra.Padding = new Padding(9, 0, 9, 0);
            btnPreCompra.Size = new Size(201, 38);
            btnPreCompra.TabIndex = 10;
            btnPreCompra.Text = "PreCompra";
            btnPreCompra.UseVisualStyleBackColor = true;
            btnPreCompra.Click += btnPreCompra_Click;
            // 
            // btnVender
            // 
            btnVender.Dock = DockStyle.Top;
            btnVender.FlatAppearance.BorderSize = 0;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVender.ForeColor = Color.White;
            btnVender.Image = Properties.Resources.vender;
            btnVender.ImageAlign = ContentAlignment.MiddleLeft;
            btnVender.Location = new Point(9, 46);
            btnVender.Margin = new Padding(3, 2, 3, 2);
            btnVender.Name = "btnVender";
            btnVender.Padding = new Padding(9, 0, 9, 0);
            btnVender.Size = new Size(201, 38);
            btnVender.TabIndex = 2;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.White;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(9, 8);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(9, 0, 9, 0);
            btnInicio.Size = new Size(201, 38);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnRedes
            // 
            pnRedes.Dock = DockStyle.Bottom;
            pnRedes.Location = new Point(0, 529);
            pnRedes.Margin = new Padding(3, 2, 3, 2);
            pnRedes.Name = "pnRedes";
            pnRedes.Size = new Size(219, 60);
            pnRedes.TabIndex = 0;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(pictureBox1);
            pnLogo.Controls.Add(label1);
            pnLogo.Dock = DockStyle.Top;
            pnLogo.Location = new Point(0, 0);
            pnLogo.Margin = new Padding(3, 2, 3, 2);
            pnLogo.Name = "pnLogo";
            pnLogo.Padding = new Padding(18, 15, 18, 15);
            pnLogo.Size = new Size(219, 75);
            pnLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo64;
            pictureBox1.Location = new Point(9, 17);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 48);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 30);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "TecniCelular";
            // 
            // pnSuperior
            // 
            pnSuperior.Controls.Add(btnCerrar);
            pnSuperior.Dock = DockStyle.Top;
            pnSuperior.Location = new Point(220, 1);
            pnSuperior.Margin = new Padding(3, 2, 3, 2);
            pnSuperior.Name = "pnSuperior";
            pnSuperior.Size = new Size(829, 30);
            pnSuperior.TabIndex = 2;
            pnSuperior.MouseDown += pnSuperior_MouseDown;
            pnSuperior.MouseMove += pnSuperior_MouseMove;
            pnSuperior.MouseUp += pnSuperior_MouseUp;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(208, 1, 27);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 1, 27);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = Properties.Resources.cerrar;
            btnCerrar.Location = new Point(794, 0);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(35, 30);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnContenido
            // 
            pnContenido.Dock = DockStyle.Fill;
            pnContenido.Location = new Point(220, 31);
            pnContenido.Margin = new Padding(3, 2, 3, 2);
            pnContenido.Name = "pnContenido";
            pnContenido.Size = new Size(829, 559);
            pnContenido.TabIndex = 3;
            // 
            // pnLogin
            // 
            pnLogin.BackColor = Color.White;
            pnLogin.Location = new Point(262, 0);
            pnLogin.Margin = new Padding(3, 2, 3, 2);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(350, 150);
            pnLogin.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1050, 591);
            Controls.Add(pnLogin);
            Controls.Add(pnContenido);
            Controls.Add(pnSuperior);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Paint += frmPrincipal_Paint;
            panel1.ResumeLayout(false);
            pnMenu.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnSuperior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnSuperior;
        private Panel pnLogo;
        private Button btnInicio;
        private Panel pnMenu;
        private Panel pnRedes;
        private Button btnCerrar;
        private Panel pnContenido;
        private Button btnVender;
        private Button btnPagos;
        private Button btnBodega;
        private Button btnProducto;
        private Button btnProveedores;
        private Button btnClientes;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnCaja;
        private Panel pnLogin;
        private Button btnReportes;
        private Button btnPreCompra;
    }
}
