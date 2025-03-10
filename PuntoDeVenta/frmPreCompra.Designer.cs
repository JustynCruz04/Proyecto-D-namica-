namespace PuntoDeVenta
{
    partial class frmPreCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label6 = new Label();
            lblID = new Label();
            txtBuscarProducto = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnPreRealizadas = new ButtomDesing();
            dgvPreCompra = new DataGridView();
            pnPreCompra = new Panel();
            btnBuscarClientes = new Button();
            btnCancelar = new Button();
            label20 = new Label();
            cbCaja = new ComboBox();
            label13 = new Label();
            cbTipoPago = new ComboBox();
            lbRestante = new Label();
            label10 = new Label();
            lbCliente = new Label();
            lbProducto = new Label();
            lbMonto = new Label();
            txtAnticipo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreCompra).BeginInit();
            pnPreCompra.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblID);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 38);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(38, 70, 83);
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(18, 0, 0, 0);
            label6.Size = new Size(830, 38);
            label6.TabIndex = 42;
            label6.Text = "PreCompra";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(344, 28);
            lblID.Name = "lblID";
            lblID.Size = new Size(10, 15);
            lblID.TabIndex = 41;
            lblID.Text = ".";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.BackColor = Color.White;
            txtBuscarProducto.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarProducto.Location = new Point(17, 21);
            txtBuscarProducto.Margin = new Padding(3, 2, 3, 2);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.PlaceholderText = "Buscar";
            txtBuscarProducto.Size = new Size(625, 23);
            txtBuscarProducto.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 530);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 38);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPreRealizadas);
            panel3.Controls.Add(txtBuscarProducto);
            panel3.Controls.Add(dgvPreCompra);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 38);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(18, 15, 18, 15);
            panel3.Size = new Size(830, 492);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // btnPreRealizadas
            // 
            btnPreRealizadas.BackColor = Color.FromArgb(38, 70, 83);
            btnPreRealizadas.BackgroundColor = Color.FromArgb(38, 70, 83);
            btnPreRealizadas.BorderColor = Color.PaleVioletRed;
            btnPreRealizadas.BorderRadius = 10;
            btnPreRealizadas.BorderSize = 0;
            btnPreRealizadas.FlatAppearance.BorderSize = 0;
            btnPreRealizadas.FlatStyle = FlatStyle.Flat;
            btnPreRealizadas.ForeColor = Color.White;
            btnPreRealizadas.Location = new Point(647, 17);
            btnPreRealizadas.Margin = new Padding(3, 2, 3, 2);
            btnPreRealizadas.Name = "btnPreRealizadas";
            btnPreRealizadas.Size = new Size(163, 26);
            btnPreRealizadas.TabIndex = 28;
            btnPreRealizadas.Text = "PreCompra Realizadas";
            btnPreRealizadas.TextColor = Color.White;
            btnPreRealizadas.UseVisualStyleBackColor = false;
            btnPreRealizadas.Click += btnPreRealizadas_Click;
            // 
            // dgvPreCompra
            // 
            dgvPreCompra.AllowUserToAddRows = false;
            dgvPreCompra.AllowUserToResizeColumns = false;
            dgvPreCompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvPreCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPreCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPreCompra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPreCompra.BackgroundColor = Color.White;
            dgvPreCompra.BorderStyle = BorderStyle.None;
            dgvPreCompra.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPreCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPreCompra.ColumnHeadersHeight = 29;
            dgvPreCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPreCompra.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPreCompra.EnableHeadersVisualStyles = false;
            dgvPreCompra.GridColor = Color.Black;
            dgvPreCompra.Location = new Point(18, 51);
            dgvPreCompra.Margin = new Padding(3, 2, 3, 2);
            dgvPreCompra.MultiSelect = false;
            dgvPreCompra.Name = "dgvPreCompra";
            dgvPreCompra.ReadOnly = true;
            dgvPreCompra.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPreCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPreCompra.RowHeadersVisible = false;
            dgvPreCompra.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvPreCompra.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvPreCompra.RowTemplate.Height = 29;
            dgvPreCompra.Size = new Size(794, 402);
            dgvPreCompra.TabIndex = 0;
            dgvPreCompra.CellDoubleClick += dgvPreCompra_CellDoubleClick;
            // 
            // pnPreCompra
            // 
            pnPreCompra.BackColor = Color.White;
            pnPreCompra.Controls.Add(btnBuscarClientes);
            pnPreCompra.Controls.Add(btnCancelar);
            pnPreCompra.Controls.Add(label20);
            pnPreCompra.Controls.Add(cbCaja);
            pnPreCompra.Controls.Add(label13);
            pnPreCompra.Controls.Add(cbTipoPago);
            pnPreCompra.Controls.Add(lbRestante);
            pnPreCompra.Controls.Add(label10);
            pnPreCompra.Controls.Add(lbCliente);
            pnPreCompra.Controls.Add(lbProducto);
            pnPreCompra.Controls.Add(lbMonto);
            pnPreCompra.Controls.Add(txtAnticipo);
            pnPreCompra.Controls.Add(label5);
            pnPreCompra.Controls.Add(label4);
            pnPreCompra.Controls.Add(label3);
            pnPreCompra.Controls.Add(label2);
            pnPreCompra.Controls.Add(label1);
            pnPreCompra.Controls.Add(btnGuardar);
            pnPreCompra.Location = new Point(130, 89);
            pnPreCompra.Margin = new Padding(3, 2, 3, 2);
            pnPreCompra.Name = "pnPreCompra";
            pnPreCompra.Size = new Size(368, 296);
            pnPreCompra.TabIndex = 24;
            pnPreCompra.Paint += pnPreCompra_Paint;
            // 
            // btnBuscarClientes
            // 
            btnBuscarClientes.BackColor = Color.Transparent;
            btnBuscarClientes.Location = new Point(289, 69);
            btnBuscarClientes.Name = "btnBuscarClientes";
            btnBuscarClientes.Size = new Size(59, 20);
            btnBuscarClientes.TabIndex = 61;
            btnBuscarClientes.Text = "Buscar";
            btnBuscarClientes.UseVisualStyleBackColor = false;
            btnBuscarClientes.Click += btnBuscarClientes_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(100, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(195, 259);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(152, 22);
            btnCancelar.TabIndex = 56;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(19, 223);
            label20.Margin = new Padding(3, 0, 3, 8);
            label20.Name = "label20";
            label20.Size = new Size(45, 15);
            label20.TabIndex = 55;
            label20.Text = "CajaID:";
            // 
            // cbCaja
            // 
            cbCaja.FormattingEnabled = true;
            cbCaja.Location = new Point(77, 217);
            cbCaja.Margin = new Padding(3, 2, 3, 2);
            cbCaja.Name = "cbCaja";
            cbCaja.Size = new Size(133, 23);
            cbCaja.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(18, 197);
            label13.Margin = new Padding(3, 0, 3, 8);
            label13.Name = "label13";
            label13.Size = new Size(81, 15);
            label13.TabIndex = 49;
            label13.Text = "Tipo de pago:";
            // 
            // cbTipoPago
            // 
            cbTipoPago.FormattingEnabled = true;
            cbTipoPago.Items.AddRange(new object[] { "Efectivo", "Credito", "Transferencia", "Deposito" });
            cbTipoPago.Location = new Point(116, 191);
            cbTipoPago.Margin = new Padding(3, 2, 3, 2);
            cbTipoPago.Name = "cbTipoPago";
            cbTipoPago.Size = new Size(133, 23);
            cbTipoPago.TabIndex = 48;
            // 
            // lbRestante
            // 
            lbRestante.AutoSize = true;
            lbRestante.ForeColor = Color.Black;
            lbRestante.Location = new Point(140, 166);
            lbRestante.Margin = new Padding(3, 0, 3, 8);
            lbRestante.Name = "lbRestante";
            lbRestante.Size = new Size(73, 15);
            lbRestante.TabIndex = 43;
            lbRestante.Text = "Monto total:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(19, 166);
            label10.Margin = new Padding(3, 0, 3, 8);
            label10.Name = "label10";
            label10.Size = new Size(103, 15);
            label10.TabIndex = 42;
            label10.Text = "Restante a pagar:";
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.ForeColor = Color.Red;
            lbCliente.Location = new Point(77, 74);
            lbCliente.Margin = new Padding(3, 0, 3, 8);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(113, 15);
            lbCliente.TabIndex = 41;
            lbCliente.Text = "Seleccione el cliente";
            // 
            // lbProducto
            // 
            lbProducto.ForeColor = Color.Black;
            lbProducto.Location = new Point(91, 97);
            lbProducto.Margin = new Padding(3, 0, 3, 8);
            lbProducto.Name = "lbProducto";
            lbProducto.Size = new Size(256, 15);
            lbProducto.TabIndex = 40;
            lbProducto.Text = "Monto total:";
            // 
            // lbMonto
            // 
            lbMonto.AutoSize = true;
            lbMonto.ForeColor = Color.Black;
            lbMonto.Location = new Point(116, 119);
            lbMonto.Margin = new Padding(3, 0, 3, 8);
            lbMonto.Name = "lbMonto";
            lbMonto.Size = new Size(73, 15);
            lbMonto.TabIndex = 39;
            lbMonto.Text = "Monto total:";
            // 
            // txtAnticipo
            // 
            txtAnticipo.Location = new Point(105, 144);
            txtAnticipo.Margin = new Padding(3, 2, 3, 2);
            txtAnticipo.Name = "txtAnticipo";
            txtAnticipo.Size = new Size(204, 23);
            txtAnticipo.TabIndex = 38;
            txtAnticipo.TextChanged += txtAnticipo_TextChanged;
            txtAnticipo.KeyPress += txtAnticipo_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 149);
            label5.Margin = new Padding(3, 0, 3, 8);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 37;
            label5.Text = "Pago Inicial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 119);
            label4.Margin = new Padding(3, 0, 3, 8);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 36;
            label4.Text = "Total a pagar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 97);
            label3.Margin = new Padding(3, 0, 3, 8);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 35;
            label3.Text = "Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 74);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 8);
            label2.Size = new Size(49, 23);
            label2.TabIndex = 34;
            label2.Text = "Cliente:";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(38, 70, 83);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(368, 38);
            label1.TabIndex = 33;
            label1.Text = "PreCompra";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(38, 70, 83);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(18, 259);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(152, 22);
            btnGuardar.TabIndex = 32;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmPreCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(830, 568);
            Controls.Add(pnPreCompra);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPreCompra";
            Text = "frmProductos";
            Load += frmPreCompra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreCompra).EndInit();
            pnPreCompra.ResumeLayout(false);
            pnPreCompra.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvPreCompra;
        private TextBox txtBuscarProducto;
        private ButtomDesing btnAgregar;
        private ButtomDesing btnEditar;
        private ButtomDesing btnEliminar;
        private Label lblID;
        private Panel pnPreCompra;
        private Button btnCancelar;
        private Label label20;
        private ComboBox cbCaja;
        private Label label13;
        private ComboBox cbTipoPago;
        private Label lbRestante;
        private Label label10;
        private Label lbCliente;
        private Label lbProducto;
        private Label lbMonto;
        private TextBox txtAnticipo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private Button btnBuscarClientes;
        private Label label6;
        private ButtomDesing btnPreRealizadas;
    }
}