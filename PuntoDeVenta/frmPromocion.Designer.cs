namespace PuntoDeVenta
{
    partial class frmPromocion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromocion));
            label1 = new Label();
            txt_RegistrarDescripcionCombo = new TextBox();
            txt_RegistrarDescuentoCombo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtp_FechaInicioCombo = new DateTimePicker();
            dtp_FechaFinalProducto = new DateTimePicker();
            label5 = new Label();
            btnBuscarProducto = new Button();
            dgvCombos = new DataGridView();
            DCIDProducto = new DataGridViewTextBoxColumn();
            DCProducto = new DataGridViewTextBoxColumn();
            DCCantidad = new DataGridViewTextBoxColumn();
            DCPrecio = new DataGridViewTextBoxColumn();
            DCIVA = new DataGridViewTextBoxColumn();
            DCQuitar = new DataGridViewButtonColumn();
            btn_AgregarProductoCombo = new Button();
            label11 = new Label();
            label12 = new Label();
            txtNombreProducto = new TextBox();
            pnlCombos = new Panel();
            txtTotalCombo = new TextBox();
            label15 = new Label();
            txtCantidad = new TextBox();
            label14 = new Label();
            dgvTodo = new DataGridView();
            pnlpromociones = new Panel();
            txtNombreCliente = new TextBox();
            dgvPromociones = new DataGridView();
            label13 = new Label();
            btn_BuscarClientePromo = new Button();
            btn_AgregarClientePromo = new Button();
            label10 = new Label();
            dtp_FechaFinalPromo = new DateTimePicker();
            dtp_FechaInicioPromo = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_RegistrarDescuentoPromo = new TextBox();
            txt_RegistrarDescripcionPromo = new TextBox();
            label9 = new Label();
            rb_Categorias = new RadioButton();
            rb_Clientes = new RadioButton();
            cb_Categoria = new ComboBox();
            btnGuardar = new Button();
            label16 = new Label();
            txtBuscar = new TextBox();
            label17 = new Label();
            label18 = new Label();
            dtpFiltroInicio = new DateTimePicker();
            dtpFiltroFinal = new DateTimePicker();
            btnFiltroFechas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCombos).BeginInit();
            pnlCombos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodo).BeginInit();
            pnlpromociones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 85);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 10;
            label1.Text = "Descripcion:";
            // 
            // txt_RegistrarDescripcionCombo
            // 
            txt_RegistrarDescripcionCombo.Location = new Point(94, 78);
            txt_RegistrarDescripcionCombo.Multiline = true;
            txt_RegistrarDescripcionCombo.Name = "txt_RegistrarDescripcionCombo";
            txt_RegistrarDescripcionCombo.Size = new Size(239, 23);
            txt_RegistrarDescripcionCombo.TabIndex = 11;
            // 
            // txt_RegistrarDescuentoCombo
            // 
            txt_RegistrarDescuentoCombo.Location = new Point(94, 109);
            txt_RegistrarDescuentoCombo.MaxLength = 3;
            txt_RegistrarDescuentoCombo.Name = "txt_RegistrarDescuentoCombo";
            txt_RegistrarDescuentoCombo.Size = new Size(59, 23);
            txt_RegistrarDescuentoCombo.TabIndex = 12;
            txt_RegistrarDescuentoCombo.TextChanged += txt_RegistrarDescuentoCombo_TextChanged;
            txt_RegistrarDescuentoCombo.KeyPress += txt_RegistrarDescuentoCombo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 112);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 13;
            label2.Text = "Descuento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 143);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 14;
            label3.Text = "Fecha Inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 144);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 15;
            label4.Text = "Fecha Final:";
            // 
            // dtp_FechaInicioCombo
            // 
            dtp_FechaInicioCombo.Format = DateTimePickerFormat.Short;
            dtp_FechaInicioCombo.Location = new Point(94, 138);
            dtp_FechaInicioCombo.Name = "dtp_FechaInicioCombo";
            dtp_FechaInicioCombo.Size = new Size(80, 23);
            dtp_FechaInicioCombo.TabIndex = 16;
            // 
            // dtp_FechaFinalProducto
            // 
            dtp_FechaFinalProducto.Format = DateTimePickerFormat.Short;
            dtp_FechaFinalProducto.Location = new Point(253, 138);
            dtp_FechaFinalProducto.Name = "dtp_FechaFinalProducto";
            dtp_FechaFinalProducto.Size = new Size(80, 23);
            dtp_FechaFinalProducto.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 18);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 18;
            label5.Text = "Elegir Productos:";
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.Transparent;
            btnBuscarProducto.BackgroundImage = (Image)resources.GetObject("btnBuscarProducto.BackgroundImage");
            btnBuscarProducto.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscarProducto.Location = new Point(117, 12);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(36, 34);
            btnBuscarProducto.TabIndex = 24;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // dgvCombos
            // 
            dgvCombos.AllowUserToAddRows = false;
            dgvCombos.AllowUserToDeleteRows = false;
            dgvCombos.AllowUserToResizeColumns = false;
            dgvCombos.AllowUserToResizeRows = false;
            dgvCombos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCombos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCombos.Columns.AddRange(new DataGridViewColumn[] { DCIDProducto, DCProducto, DCCantidad, DCPrecio, DCIVA, DCQuitar });
            dgvCombos.Location = new Point(15, 167);
            dgvCombos.Name = "dgvCombos";
            dgvCombos.ReadOnly = true;
            dgvCombos.RowHeadersVisible = false;
            dgvCombos.RowTemplate.Height = 25;
            dgvCombos.Size = new Size(318, 201);
            dgvCombos.TabIndex = 25;
            // 
            // DCIDProducto
            // 
            DCIDProducto.HeaderText = "ID";
            DCIDProducto.Name = "DCIDProducto";
            DCIDProducto.ReadOnly = true;
            // 
            // DCProducto
            // 
            DCProducto.HeaderText = "Producto";
            DCProducto.Name = "DCProducto";
            DCProducto.ReadOnly = true;
            // 
            // DCCantidad
            // 
            DCCantidad.HeaderText = "Cantidad";
            DCCantidad.Name = "DCCantidad";
            DCCantidad.ReadOnly = true;
            // 
            // DCPrecio
            // 
            DCPrecio.HeaderText = "Precio";
            DCPrecio.Name = "DCPrecio";
            DCPrecio.ReadOnly = true;
            // 
            // DCIVA
            // 
            DCIVA.HeaderText = "IVA";
            DCIVA.Name = "DCIVA";
            DCIVA.ReadOnly = true;
            // 
            // DCQuitar
            // 
            DCQuitar.HeaderText = "Opción";
            DCQuitar.Name = "DCQuitar";
            DCQuitar.ReadOnly = true;
            // 
            // btn_AgregarProductoCombo
            // 
            btn_AgregarProductoCombo.FlatStyle = FlatStyle.Popup;
            btn_AgregarProductoCombo.Location = new Point(251, 13);
            btn_AgregarProductoCombo.Name = "btn_AgregarProductoCombo";
            btn_AgregarProductoCombo.Size = new Size(82, 25);
            btn_AgregarProductoCombo.TabIndex = 26;
            btn_AgregarProductoCombo.Text = "Agregar";
            btn_AgregarProductoCombo.UseVisualStyleBackColor = true;
            btn_AgregarProductoCombo.Click += btn_AgregarProductoCombo_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(38, 70, 83);
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Padding = new Padding(18, 0, 0, 0);
            label11.Size = new Size(147, 25);
            label11.TabIndex = 43;
            label11.Text = "Promociones";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 51);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 44;
            label12.Text = "Producto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(93, 49);
            txtNombreProducto.Multiline = true;
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.ReadOnly = true;
            txtNombreProducto.Size = new Size(240, 23);
            txtNombreProducto.TabIndex = 45;
            // 
            // pnlCombos
            // 
            pnlCombos.Controls.Add(txtTotalCombo);
            pnlCombos.Controls.Add(label15);
            pnlCombos.Controls.Add(txtCantidad);
            pnlCombos.Controls.Add(label14);
            pnlCombos.Controls.Add(dgvCombos);
            pnlCombos.Controls.Add(label1);
            pnlCombos.Controls.Add(txt_RegistrarDescripcionCombo);
            pnlCombos.Controls.Add(txtNombreProducto);
            pnlCombos.Controls.Add(txt_RegistrarDescuentoCombo);
            pnlCombos.Controls.Add(label12);
            pnlCombos.Controls.Add(label2);
            pnlCombos.Controls.Add(label3);
            pnlCombos.Controls.Add(label4);
            pnlCombos.Controls.Add(dtp_FechaInicioCombo);
            pnlCombos.Controls.Add(dtp_FechaFinalProducto);
            pnlCombos.Controls.Add(label5);
            pnlCombos.Controls.Add(btnBuscarProducto);
            pnlCombos.Controls.Add(btn_AgregarProductoCombo);
            pnlCombos.Location = new Point(467, 88);
            pnlCombos.Name = "pnlCombos";
            pnlCombos.Size = new Size(341, 407);
            pnlCombos.TabIndex = 48;
            // 
            // txtTotalCombo
            // 
            txtTotalCombo.Enabled = false;
            txtTotalCombo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalCombo.Location = new Point(223, 374);
            txtTotalCombo.MaxLength = 3;
            txtTotalCombo.Name = "txtTotalCombo";
            txtTotalCombo.Size = new Size(110, 25);
            txtTotalCombo.TabIndex = 49;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(120, 377);
            label15.Name = "label15";
            label15.Size = new Size(97, 19);
            label15.TabIndex = 48;
            label15.Text = "Total combo:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(223, 109);
            txtCantidad.MaxLength = 3;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(110, 23);
            txtCantidad.TabIndex = 47;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(159, 112);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 46;
            label14.Text = "Cantidad:";
            // 
            // dgvTodo
            // 
            dgvTodo.AllowUserToAddRows = false;
            dgvTodo.AllowUserToDeleteRows = false;
            dgvTodo.AllowUserToResizeColumns = false;
            dgvTodo.AllowUserToResizeRows = false;
            dgvTodo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodo.Location = new Point(32, 88);
            dgvTodo.Name = "dgvTodo";
            dgvTodo.ReadOnly = true;
            dgvTodo.RowHeadersVisible = false;
            dgvTodo.RowTemplate.Height = 25;
            dgvTodo.Size = new Size(429, 412);
            dgvTodo.TabIndex = 49;
            // 
            // pnlpromociones
            // 
            pnlpromociones.Controls.Add(txtNombreCliente);
            pnlpromociones.Controls.Add(dgvPromociones);
            pnlpromociones.Controls.Add(label13);
            pnlpromociones.Controls.Add(btn_BuscarClientePromo);
            pnlpromociones.Controls.Add(btn_AgregarClientePromo);
            pnlpromociones.Controls.Add(label10);
            pnlpromociones.Controls.Add(dtp_FechaFinalPromo);
            pnlpromociones.Controls.Add(dtp_FechaInicioPromo);
            pnlpromociones.Controls.Add(label6);
            pnlpromociones.Controls.Add(label7);
            pnlpromociones.Controls.Add(label8);
            pnlpromociones.Controls.Add(txt_RegistrarDescuentoPromo);
            pnlpromociones.Controls.Add(txt_RegistrarDescripcionPromo);
            pnlpromociones.Controls.Add(label9);
            pnlpromociones.Controls.Add(rb_Categorias);
            pnlpromociones.Controls.Add(rb_Clientes);
            pnlpromociones.Controls.Add(cb_Categoria);
            pnlpromociones.Location = new Point(831, 88);
            pnlpromociones.Name = "pnlpromociones";
            pnlpromociones.Size = new Size(376, 406);
            pnlpromociones.TabIndex = 50;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Location = new Point(197, 48);
            txtNombreCliente.MaxLength = 3;
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(167, 23);
            txtNombreCliente.TabIndex = 63;
            // 
            // dgvPromociones
            // 
            dgvPromociones.AllowUserToAddRows = false;
            dgvPromociones.AllowUserToDeleteRows = false;
            dgvPromociones.AllowUserToResizeColumns = false;
            dgvPromociones.AllowUserToResizeRows = false;
            dgvPromociones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromociones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromociones.ColumnHeadersVisible = false;
            dgvPromociones.Location = new Point(9, 177);
            dgvPromociones.Name = "dgvPromociones";
            dgvPromociones.ReadOnly = true;
            dgvPromociones.RowHeadersVisible = false;
            dgvPromociones.RowTemplate.Height = 25;
            dgvPromociones.Size = new Size(355, 218);
            dgvPromociones.TabIndex = 61;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(144, 50);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 62;
            label13.Text = "Cliente:";
            // 
            // btn_BuscarClientePromo
            // 
            btn_BuscarClientePromo.BackColor = Color.Transparent;
            btn_BuscarClientePromo.BackgroundImage = (Image)resources.GetObject("btn_BuscarClientePromo.BackgroundImage");
            btn_BuscarClientePromo.BackgroundImageLayout = ImageLayout.Stretch;
            btn_BuscarClientePromo.Location = new Point(95, 41);
            btn_BuscarClientePromo.Name = "btn_BuscarClientePromo";
            btn_BuscarClientePromo.Size = new Size(36, 34);
            btn_BuscarClientePromo.TabIndex = 60;
            btn_BuscarClientePromo.UseVisualStyleBackColor = false;
            btn_BuscarClientePromo.Click += btn_BuscarClientePromo_Click_1;
            // 
            // btn_AgregarClientePromo
            // 
            btn_AgregarClientePromo.FlatStyle = FlatStyle.Popup;
            btn_AgregarClientePromo.Location = new Point(308, 6);
            btn_AgregarClientePromo.Name = "btn_AgregarClientePromo";
            btn_AgregarClientePromo.Size = new Size(61, 25);
            btn_AgregarClientePromo.TabIndex = 59;
            btn_AgregarClientePromo.Text = "Agregar";
            btn_AgregarClientePromo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 51);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 58;
            label10.Text = "Elegir Cliente:";
            // 
            // dtp_FechaFinalPromo
            // 
            dtp_FechaFinalPromo.Format = DateTimePickerFormat.Short;
            dtp_FechaFinalPromo.Location = new Point(244, 136);
            dtp_FechaFinalPromo.Name = "dtp_FechaFinalPromo";
            dtp_FechaFinalPromo.Size = new Size(79, 23);
            dtp_FechaFinalPromo.TabIndex = 57;
            // 
            // dtp_FechaInicioPromo
            // 
            dtp_FechaInicioPromo.Enabled = false;
            dtp_FechaInicioPromo.Format = DateTimePickerFormat.Short;
            dtp_FechaInicioPromo.Location = new Point(83, 136);
            dtp_FechaInicioPromo.MinDate = new DateTime(2024, 9, 29, 1, 47, 24, 0);
            dtp_FechaInicioPromo.Name = "dtp_FechaInicioPromo";
            dtp_FechaInicioPromo.Size = new Size(80, 23);
            dtp_FechaInicioPromo.TabIndex = 56;
            dtp_FechaInicioPromo.Value = new DateTime(2024, 9, 29, 1, 47, 24, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 140);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 55;
            label6.Text = "Fecha Final:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 140);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 54;
            label7.Text = "Fecha Inicio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 110);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 53;
            label8.Text = "Descuento:";
            // 
            // txt_RegistrarDescuentoPromo
            // 
            txt_RegistrarDescuentoPromo.Location = new Point(83, 108);
            txt_RegistrarDescuentoPromo.MaxLength = 3;
            txt_RegistrarDescuentoPromo.Name = "txt_RegistrarDescuentoPromo";
            txt_RegistrarDescuentoPromo.Size = new Size(100, 23);
            txt_RegistrarDescuentoPromo.TabIndex = 52;
            // 
            // txt_RegistrarDescripcionPromo
            // 
            txt_RegistrarDescripcionPromo.Location = new Point(83, 81);
            txt_RegistrarDescripcionPromo.Multiline = true;
            txt_RegistrarDescripcionPromo.Name = "txt_RegistrarDescripcionPromo";
            txt_RegistrarDescripcionPromo.Size = new Size(281, 23);
            txt_RegistrarDescripcionPromo.TabIndex = 51;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 84);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 50;
            label9.Text = "Descripcion:";
            // 
            // rb_Categorias
            // 
            rb_Categorias.AutoSize = true;
            rb_Categorias.Location = new Point(83, 9);
            rb_Categorias.Name = "rb_Categorias";
            rb_Categorias.Size = new Size(81, 19);
            rb_Categorias.TabIndex = 49;
            rb_Categorias.TabStop = true;
            rb_Categorias.Text = "Categorias";
            rb_Categorias.UseVisualStyleBackColor = true;
            // 
            // rb_Clientes
            // 
            rb_Clientes.AutoSize = true;
            rb_Clientes.Location = new Point(9, 9);
            rb_Clientes.Name = "rb_Clientes";
            rb_Clientes.Size = new Size(67, 19);
            rb_Clientes.TabIndex = 48;
            rb_Clientes.TabStop = true;
            rb_Clientes.Text = "Clientes";
            rb_Clientes.UseVisualStyleBackColor = true;
            // 
            // cb_Categoria
            // 
            cb_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Categoria.FormattingEnabled = true;
            cb_Categoria.Location = new Point(169, 5);
            cb_Categoria.Name = "cb_Categoria";
            cb_Categoria.Size = new Size(133, 23);
            cb_Categoria.TabIndex = 47;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(548, 501);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(194, 35);
            btnGuardar.TabIndex = 63;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(32, 59);
            label16.Name = "label16";
            label16.Size = new Size(45, 15);
            label16.TabIndex = 50;
            label16.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(83, 56);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(191, 23);
            txtBuscar.TabIndex = 51;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(280, 59);
            label17.Name = "label17";
            label17.Size = new Size(73, 15);
            label17.TabIndex = 50;
            label17.Text = "Fecha Inicio:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(446, 60);
            label18.Name = "label18";
            label18.Size = new Size(69, 15);
            label18.TabIndex = 51;
            label18.Text = "Fecha Final:";
            // 
            // dtpFiltroInicio
            // 
            dtpFiltroInicio.Format = DateTimePickerFormat.Short;
            dtpFiltroInicio.Location = new Point(360, 54);
            dtpFiltroInicio.Name = "dtpFiltroInicio";
            dtpFiltroInicio.Size = new Size(80, 23);
            dtpFiltroInicio.TabIndex = 52;
            dtpFiltroInicio.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtpFiltroFinal
            // 
            dtpFiltroFinal.Format = DateTimePickerFormat.Short;
            dtpFiltroFinal.Location = new Point(519, 54);
            dtpFiltroFinal.Name = "dtpFiltroFinal";
            dtpFiltroFinal.Size = new Size(80, 23);
            dtpFiltroFinal.TabIndex = 53;
            // 
            // btnFiltroFechas
            // 
            btnFiltroFechas.FlatStyle = FlatStyle.Popup;
            btnFiltroFechas.Location = new Point(614, 52);
            btnFiltroFechas.Name = "btnFiltroFechas";
            btnFiltroFechas.Size = new Size(36, 25);
            btnFiltroFechas.TabIndex = 50;
            btnFiltroFechas.Text = "+";
            btnFiltroFechas.UseVisualStyleBackColor = true;
            btnFiltroFechas.Click += btnFiltroFechas_Click;
            // 
            // frmPromocion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 540);
            Controls.Add(btnFiltroFechas);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(dtpFiltroInicio);
            Controls.Add(txtBuscar);
            Controls.Add(dtpFiltroFinal);
            Controls.Add(btnGuardar);
            Controls.Add(pnlpromociones);
            Controls.Add(dgvTodo);
            Controls.Add(pnlCombos);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(830, 540);
            MinimumSize = new Size(830, 540);
            Name = "frmPromocion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Promocion";
            Load += frmPromocion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCombos).EndInit();
            pnlCombos.ResumeLayout(false);
            pnlCombos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodo).EndInit();
            pnlpromociones.ResumeLayout(false);
            pnlpromociones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txt_RegistrarDescripcionCombo;
        private TextBox txt_RegistrarDescuentoCombo;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtp_FechaInicioCombo;
        private DateTimePicker dtp_FechaFinalProducto;
        private Label label5;
        private Button btnBuscarProducto;
        private DataGridView dgvCombos;
        private Button btn_AgregarProductoCombo;
        private Label label11;
        private Label label12;
        private TextBox txtNombreProducto;
        private Panel pnlCombos;
        private DataGridView dgvTodo;
        private Panel pnlpromociones;
        private DataGridView dgvPromociones;
        private Label label13;
        private Button btn_BuscarClientePromo;
        private Button btn_AgregarClientePromo;
        private Label label10;
        private DateTimePicker dtp_FechaFinalPromo;
        private DateTimePicker dtp_FechaInicioPromo;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_RegistrarDescuentoPromo;
        private TextBox txt_RegistrarDescripcionPromo;
        private Label label9;
        private RadioButton rb_Categorias;
        private RadioButton rb_Clientes;
        private ComboBox cb_Categoria;
        private Button btnGuardar;
        private TextBox txtNombreCliente;
        private TextBox txtCantidad;
        private Label label14;
        private TextBox txtTotalCombo;
        private Label label15;
        private DataGridViewTextBoxColumn DCIDProducto;
        private DataGridViewTextBoxColumn DCProducto;
        private DataGridViewTextBoxColumn DCCantidad;
        private DataGridViewTextBoxColumn DCPrecio;
        private DataGridViewTextBoxColumn DCIVA;
        private DataGridViewButtonColumn DCQuitar;
        private Label label16;
        private TextBox txtBuscar;
        private Label label17;
        private Label label18;
        private DateTimePicker dtpFiltroInicio;
        private DateTimePicker dtpFiltroFinal;
        private Button btnFiltroFechas;
    }
}