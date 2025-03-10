namespace PuntoDeVenta
{
    partial class frmPreCompraRealizadas
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label6 = new Label();
            lblID = new Label();
            txtBuscarProducto = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnPreCompra = new ButtomDesing();
            dgvPreCompra = new DataGridView();
            pnPreCompra = new Panel();
            btnCancelar = new Button();
            label20 = new Label();
            cbCaja = new ComboBox();
            label13 = new Label();
            cbTipoPago = new ComboBox();
            lbRestante = new Label();
            label10 = new Label();
            lbCliente = new Label();
            lbProducto = new Label();
            lbTotal = new Label();
            txtAnticipo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            pnPagos = new Panel();
            btnCerrarPagos = new Button();
            dgvPagos = new DataGridView();
            lbPagoProducto = new Label();
            label8 = new Label();
            lbPagoCliente = new Label();
            label19 = new Label();
            label21 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreCompra).BeginInit();
            pnPreCompra.SuspendLayout();
            pnPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
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
            label6.Text = "PreCompra Realizadas";
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
            panel3.Controls.Add(btnPreCompra);
            panel3.Controls.Add(txtBuscarProducto);
            panel3.Controls.Add(dgvPreCompra);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 38);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(18, 15, 18, 15);
            panel3.Size = new Size(830, 492);
            panel3.TabIndex = 2;
            // 
            // btnPreCompra
            // 
            btnPreCompra.BackColor = Color.FromArgb(38, 70, 83);
            btnPreCompra.BackgroundColor = Color.FromArgb(38, 70, 83);
            btnPreCompra.BorderColor = Color.PaleVioletRed;
            btnPreCompra.BorderRadius = 10;
            btnPreCompra.BorderSize = 0;
            btnPreCompra.FlatAppearance.BorderSize = 0;
            btnPreCompra.FlatStyle = FlatStyle.Flat;
            btnPreCompra.ForeColor = Color.White;
            btnPreCompra.Location = new Point(647, 17);
            btnPreCompra.Margin = new Padding(3, 2, 3, 2);
            btnPreCompra.Name = "btnPreCompra";
            btnPreCompra.Size = new Size(163, 26);
            btnPreCompra.TabIndex = 28;
            btnPreCompra.Text = "PreCompra";
            btnPreCompra.TextColor = Color.White;
            btnPreCompra.UseVisualStyleBackColor = false;
            btnPreCompra.Click += btnPreCompra_Click;
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
            dgvPreCompra.CellClick += dgvPreCompra_CellClick;
            dgvPreCompra.CellContentClick += dgvPreCompra_CellContentClick;
            // 
            // pnPreCompra
            // 
            pnPreCompra.BackColor = Color.White;
            pnPreCompra.Controls.Add(btnCancelar);
            pnPreCompra.Controls.Add(label20);
            pnPreCompra.Controls.Add(cbCaja);
            pnPreCompra.Controls.Add(label13);
            pnPreCompra.Controls.Add(cbTipoPago);
            pnPreCompra.Controls.Add(lbRestante);
            pnPreCompra.Controls.Add(label10);
            pnPreCompra.Controls.Add(lbCliente);
            pnPreCompra.Controls.Add(lbProducto);
            pnPreCompra.Controls.Add(lbTotal);
            pnPreCompra.Controls.Add(txtAnticipo);
            pnPreCompra.Controls.Add(label5);
            pnPreCompra.Controls.Add(label4);
            pnPreCompra.Controls.Add(label3);
            pnPreCompra.Controls.Add(label2);
            pnPreCompra.Controls.Add(label1);
            pnPreCompra.Controls.Add(btnGuardar);
            pnPreCompra.Location = new Point(9, 112);
            pnPreCompra.Margin = new Padding(3, 2, 3, 2);
            pnPreCompra.Name = "pnPreCompra";
            pnPreCompra.Size = new Size(368, 296);
            pnPreCompra.TabIndex = 24;
            pnPreCompra.Paint += pnPreCompra_Paint;
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
            lbCliente.ForeColor = Color.Black;
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
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.ForeColor = Color.Black;
            lbTotal.Location = new Point(116, 119);
            lbTotal.Margin = new Padding(3, 0, 3, 8);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(73, 15);
            lbTotal.TabIndex = 39;
            lbTotal.Text = "Monto total:";
            // 
            // txtAnticipo
            // 
            txtAnticipo.Location = new Point(110, 144);
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
            label5.Size = new Size(77, 15);
            label5.TabIndex = 37;
            label5.Text = "Monto Pago:";
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
            label1.Text = "Realizar Pago";
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
            // pnPagos
            // 
            pnPagos.BackColor = Color.White;
            pnPagos.Controls.Add(btnCerrarPagos);
            pnPagos.Controls.Add(dgvPagos);
            pnPagos.Controls.Add(lbPagoProducto);
            pnPagos.Controls.Add(label8);
            pnPagos.Controls.Add(lbPagoCliente);
            pnPagos.Controls.Add(label19);
            pnPagos.Controls.Add(label21);
            pnPagos.Location = new Point(398, 112);
            pnPagos.Margin = new Padding(3, 2, 3, 2);
            pnPagos.Name = "pnPagos";
            pnPagos.Size = new Size(411, 296);
            pnPagos.TabIndex = 57;
            pnPagos.Paint += pnPagos_Paint;
            // 
            // btnCerrarPagos
            // 
            btnCerrarPagos.BackColor = Color.FromArgb(100, 0, 0);
            btnCerrarPagos.FlatAppearance.BorderSize = 0;
            btnCerrarPagos.FlatStyle = FlatStyle.Flat;
            btnCerrarPagos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarPagos.ForeColor = Color.White;
            btnCerrarPagos.Location = new Point(9, 8);
            btnCerrarPagos.Margin = new Padding(3, 2, 3, 2);
            btnCerrarPagos.Name = "btnCerrarPagos";
            btnCerrarPagos.Size = new Size(26, 22);
            btnCerrarPagos.TabIndex = 57;
            btnCerrarPagos.Text = "X";
            btnCerrarPagos.UseVisualStyleBackColor = false;
            btnCerrarPagos.Click += btnCerrarPagos_Click;
            // 
            // dgvPagos
            // 
            dgvPagos.AllowUserToAddRows = false;
            dgvPagos.AllowUserToResizeColumns = false;
            dgvPagos.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dgvPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPagos.BackgroundColor = Color.White;
            dgvPagos.BorderStyle = BorderStyle.None;
            dgvPagos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPagos.ColumnHeadersHeight = 29;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPagos.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPagos.EnableHeadersVisualStyles = false;
            dgvPagos.GridColor = Color.Black;
            dgvPagos.Location = new Point(11, 92);
            dgvPagos.Margin = new Padding(3, 2, 3, 2);
            dgvPagos.MultiSelect = false;
            dgvPagos.Name = "dgvPagos";
            dgvPagos.ReadOnly = true;
            dgvPagos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvPagos.RowHeadersVisible = false;
            dgvPagos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvPagos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvPagos.RowTemplate.Height = 29;
            dgvPagos.Size = new Size(385, 188);
            dgvPagos.TabIndex = 44;
            // 
            // lbPagoProducto
            // 
            lbPagoProducto.ForeColor = Color.Black;
            lbPagoProducto.Location = new Point(84, 68);
            lbPagoProducto.Margin = new Padding(3, 0, 3, 8);
            lbPagoProducto.Name = "lbPagoProducto";
            lbPagoProducto.Size = new Size(256, 15);
            lbPagoProducto.TabIndex = 43;
            lbPagoProducto.Text = "Monto total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(11, 68);
            label8.Margin = new Padding(3, 0, 3, 8);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 42;
            label8.Text = "Producto:";
            // 
            // lbPagoCliente
            // 
            lbPagoCliente.AutoSize = true;
            lbPagoCliente.ForeColor = Color.Black;
            lbPagoCliente.Location = new Point(70, 45);
            lbPagoCliente.Margin = new Padding(3, 0, 3, 8);
            lbPagoCliente.Name = "lbPagoCliente";
            lbPagoCliente.Size = new Size(113, 15);
            lbPagoCliente.TabIndex = 41;
            lbPagoCliente.Text = "Seleccione el cliente";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(11, 45);
            label19.Name = "label19";
            label19.Padding = new Padding(0, 0, 0, 8);
            label19.Size = new Size(49, 23);
            label19.TabIndex = 34;
            label19.Text = "Cliente:";
            // 
            // label21
            // 
            label21.BackColor = Color.FromArgb(38, 70, 83);
            label21.Dock = DockStyle.Top;
            label21.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(0, 0);
            label21.Name = "label21";
            label21.RightToLeft = RightToLeft.No;
            label21.Size = new Size(411, 38);
            label21.TabIndex = 33;
            label21.Text = "Pagos Realizados";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPreCompraRealizadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(830, 568);
            Controls.Add(pnPreCompra);
            Controls.Add(pnPagos);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPreCompraRealizadas";
            Text = "frmProductos";
            Load += frmPreCompraRealizadas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreCompra).EndInit();
            pnPreCompra.ResumeLayout(false);
            pnPreCompra.PerformLayout();
            pnPagos.ResumeLayout(false);
            pnPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
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
        private Label lbTotal;
        private TextBox txtAnticipo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private Label label6;
        private ButtomDesing btnPreCompra;
        private Panel pnPagos;
        private Button button1;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label9;
        private Label label11;
        private Label lbPagoCliente;
        private Label label14;
        private Label label15;
        private TextBox textBox1;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label21;
        private Label lbPagoProducto;
        private Label label8;
        private DataGridView dgvPagos;
        private Button btnCerrarPagos;
        private Button button2;
    }
}