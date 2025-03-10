namespace PuntoDeVenta
{
    partial class frmProductos
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
            lblID = new Label();
            groupBox1 = new GroupBox();
            cb_NombreBodega = new ComboBox();
            cb_NombreProveedor = new ComboBox();
            chkEstado = new CheckBox();
            cbIVA = new ComboBox();
            label5 = new Label();
            chbPreCompra = new CheckBox();
            dtFin = new DateTimePicker();
            label4 = new Label();
            dtInicio = new DateTimePicker();
            label14 = new Label();
            lbl_cedula = new Label();
            txt_Nombre = new TextBox();
            txt_CodigoBarra = new TextBox();
            txt_BodegaID = new TextBox();
            label3 = new Label();
            txt_ProveedorID = new TextBox();
            lbl_nombre = new Label();
            txt_PrecioCompra = new TextBox();
            label2 = new Label();
            lbl_telefonoRef = new Label();
            lbl_nombreRefe = new Label();
            txt_StockMinimo = new TextBox();
            label1 = new Label();
            txt_Existencia = new TextBox();
            txt_PrecioVenta = new TextBox();
            lbl_telefono = new Label();
            btnEditar = new ButtomDesing();
            btnAgregar = new ButtomDesing();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvProductos = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAgregar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 250);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(364, 19);
            lblID.Name = "lblID";
            lblID.Size = new Size(10, 15);
            lblID.TabIndex = 42;
            lblID.Text = ".";
            lblID.Click += lblID_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_NombreBodega);
            groupBox1.Controls.Add(cb_NombreProveedor);
            groupBox1.Controls.Add(chkEstado);
            groupBox1.Controls.Add(cbIVA);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(chbPreCompra);
            groupBox1.Controls.Add(dtFin);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtInicio);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(lbl_cedula);
            groupBox1.Controls.Add(txt_Nombre);
            groupBox1.Controls.Add(txt_CodigoBarra);
            groupBox1.Controls.Add(txt_BodegaID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_ProveedorID);
            groupBox1.Controls.Add(lbl_nombre);
            groupBox1.Controls.Add(txt_PrecioCompra);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lbl_telefonoRef);
            groupBox1.Controls.Add(lbl_nombreRefe);
            groupBox1.Controls.Add(txt_StockMinimo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_Existencia);
            groupBox1.Controls.Add(txt_PrecioVenta);
            groupBox1.Controls.Add(lbl_telefono);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(16, 46);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(711, 196);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle del Producto";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cb_NombreBodega
            // 
            cb_NombreBodega.FormattingEnabled = true;
            cb_NombreBodega.Location = new Point(595, 70);
            cb_NombreBodega.Name = "cb_NombreBodega";
            cb_NombreBodega.Size = new Size(97, 23);
            cb_NombreBodega.TabIndex = 42;
            // 
            // cb_NombreProveedor
            // 
            cb_NombreProveedor.FormattingEnabled = true;
            cb_NombreProveedor.Location = new Point(595, 30);
            cb_NombreProveedor.Name = "cb_NombreProveedor";
            cb_NombreProveedor.Size = new Size(97, 23);
            cb_NombreProveedor.TabIndex = 41;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(466, 144);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(62, 19);
            chkEstado.TabIndex = 40;
            chkEstado.Text = "Estado";
            chkEstado.UseVisualStyleBackColor = true;
            chkEstado.Visible = false;
            // 
            // cbIVA
            // 
            cbIVA.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIVA.FormattingEnabled = true;
            cbIVA.Location = new Point(551, 164);
            cbIVA.Name = "cbIVA";
            cbIVA.Size = new Size(100, 23);
            cbIVA.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(466, 168);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 38;
            label5.Text = "IVA";
            // 
            // chbPreCompra
            // 
            chbPreCompra.AutoSize = true;
            chbPreCompra.Location = new Point(466, 113);
            chbPreCompra.Margin = new Padding(3, 2, 3, 2);
            chbPreCompra.Name = "chbPreCompra";
            chbPreCompra.Size = new Size(157, 19);
            chbPreCompra.TabIndex = 37;
            chbPreCompra.Text = "Producto En Precompra";
            chbPreCompra.UseVisualStyleBackColor = true;
            chbPreCompra.CheckedChanged += chbPreCompra_CheckedChanged;
            // 
            // dtFin
            // 
            dtFin.CustomFormat = "dd/MM/yyyy";
            dtFin.Enabled = false;
            dtFin.Location = new Point(172, 169);
            dtFin.Margin = new Padding(3, 2, 3, 2);
            dtFin.Name = "dtFin";
            dtFin.Size = new Size(275, 23);
            dtFin.TabIndex = 36;
            dtFin.Value = new DateTime(2024, 9, 8, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 172);
            label4.Margin = new Padding(3, 0, 3, 8);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 35;
            label4.Text = "Fecha Fin PreCompra:";
            // 
            // dtInicio
            // 
            dtInicio.CustomFormat = "dd/MM/yyyy";
            dtInicio.Enabled = false;
            dtInicio.Location = new Point(172, 144);
            dtInicio.Margin = new Padding(3, 2, 3, 2);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(275, 23);
            dtInicio.TabIndex = 34;
            dtInicio.Value = new DateTime(2024, 9, 8, 0, 0, 0, 0);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(14, 148);
            label14.Margin = new Padding(3, 0, 3, 8);
            label14.Name = "label14";
            label14.Size = new Size(140, 15);
            label14.TabIndex = 33;
            label14.Text = "Fecha Inicio PreCompra:";
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cedula.Location = new Point(14, 30);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(53, 15);
            lbl_cedula.TabIndex = 19;
            lbl_cedula.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(127, 30);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(113, 23);
            txt_Nombre.TabIndex = 15;
            // 
            // txt_CodigoBarra
            // 
            txt_CodigoBarra.Location = new Point(127, 70);
            txt_CodigoBarra.MaxLength = 10;
            txt_CodigoBarra.Name = "txt_CodigoBarra";
            txt_CodigoBarra.Size = new Size(113, 23);
            txt_CodigoBarra.TabIndex = 16;
            txt_CodigoBarra.TextChanged += textBox3_TextChanged;
            // 
            // txt_BodegaID
            // 
            txt_BodegaID.Location = new Point(551, 70);
            txt_BodegaID.Name = "txt_BodegaID";
            txt_BodegaID.ReadOnly = true;
            txt_BodegaID.Size = new Size(38, 23);
            txt_BodegaID.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(466, 76);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 32;
            label3.Text = "Bodega";
            // 
            // txt_ProveedorID
            // 
            txt_ProveedorID.Location = new Point(551, 30);
            txt_ProveedorID.Name = "txt_ProveedorID";
            txt_ProveedorID.ReadOnly = true;
            txt_ProveedorID.Size = new Size(38, 23);
            txt_ProveedorID.TabIndex = 29;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(14, 73);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(95, 15);
            lbl_nombre.TabIndex = 20;
            lbl_nombre.Text = "Codigo de Barra";
            // 
            // txt_PrecioCompra
            // 
            txt_PrecioCompra.Location = new Point(127, 111);
            txt_PrecioCompra.Name = "txt_PrecioCompra";
            txt_PrecioCompra.Size = new Size(113, 23);
            txt_PrecioCompra.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(466, 32);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 30;
            label2.Text = "Proveedor";
            // 
            // lbl_telefonoRef
            // 
            lbl_telefonoRef.AutoSize = true;
            lbl_telefonoRef.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_telefonoRef.Location = new Point(14, 113);
            lbl_telefonoRef.Name = "lbl_telefonoRef";
            lbl_telefonoRef.Size = new Size(105, 15);
            lbl_telefonoRef.TabIndex = 24;
            lbl_telefonoRef.Text = "Precio de Compra";
            // 
            // lbl_nombreRefe
            // 
            lbl_nombreRefe.AutoSize = true;
            lbl_nombreRefe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombreRefe.Location = new Point(245, 30);
            lbl_nombreRefe.Name = "lbl_nombreRefe";
            lbl_nombreRefe.Size = new Size(94, 15);
            lbl_nombreRefe.TabIndex = 22;
            lbl_nombreRefe.Text = "Precio de Venta";
            // 
            // txt_StockMinimo
            // 
            txt_StockMinimo.Location = new Point(348, 111);
            txt_StockMinimo.Name = "txt_StockMinimo";
            txt_StockMinimo.Size = new Size(113, 23);
            txt_StockMinimo.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(245, 113);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 28;
            label1.Text = "Stock Minimo";
            // 
            // txt_Existencia
            // 
            txt_Existencia.Location = new Point(348, 70);
            txt_Existencia.Name = "txt_Existencia";
            txt_Existencia.Size = new Size(113, 23);
            txt_Existencia.TabIndex = 17;
            // 
            // txt_PrecioVenta
            // 
            txt_PrecioVenta.Location = new Point(348, 30);
            txt_PrecioVenta.Name = "txt_PrecioVenta";
            txt_PrecioVenta.Size = new Size(113, 23);
            txt_PrecioVenta.TabIndex = 18;
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_telefono.Location = new Point(245, 73);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(62, 15);
            lbl_telefono.TabIndex = 21;
            lbl_telefono.Text = "Existencia";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SandyBrown;
            btnEditar.BackgroundColor = Color.SandyBrown;
            btnEditar.BorderColor = Color.PaleVioletRed;
            btnEditar.BorderRadius = 20;
            btnEditar.BorderSize = 0;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(733, 157);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(84, 35);
            btnEditar.TabIndex = 34;
            btnEditar.Text = "Editar";
            btnEditar.TextColor = Color.White;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.MediumSlateBlue;
            btnAgregar.BackgroundColor = Color.MediumSlateBlue;
            btnAgregar.BorderColor = Color.Azure;
            btnAgregar.BorderRadius = 20;
            btnAgregar.BorderSize = 0;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(733, 113);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(84, 35);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "+ Agregar";
            btnAgregar.TextColor = Color.White;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 536);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 32);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvProductos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 250);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(18, 15, 18, 15);
            panel3.Size = new Size(830, 286);
            panel3.TabIndex = 2;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeight = 29;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.Black;
            dgvProductos.Location = new Point(12, 17);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(806, 323);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(830, 568);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvProductos;
        private Label lbl_telefonoRef;
        private TextBox txt_PrecioCompra;
        private Label lbl_nombreRefe;
        private Label lbl_telefono;
        private Label lbl_nombre;
        private Label lbl_cedula;
        private TextBox txt_PrecioVenta;
        private TextBox txt_Existencia;
        private TextBox txt_CodigoBarra;
        private TextBox txt_Nombre;
        private Label label2;
        private TextBox txt_ProveedorID;
        private Label label1;
        private TextBox txt_StockMinimo;
        private Label label3;
        private TextBox txt_BodegaID;
        private ButtomDesing btnAgregar;
        private ButtomDesing btnEditar;
        private GroupBox groupBox1;
        private Label lblID;
        private DateTimePicker dtFin;
        private Label label4;
        private DateTimePicker dtInicio;
        private Label label14;
        private CheckBox chbPreCompra;
        private ComboBox cbIVA;
        private Label label5;
        private CheckBox chkEstado;
        private ComboBox cb_NombreBodega;
        private ComboBox cb_NombreProveedor;
    }
}