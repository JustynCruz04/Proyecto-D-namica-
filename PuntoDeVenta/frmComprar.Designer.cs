namespace PuntoDeVenta
{
    partial class frmComprar
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
            panel1 = new Panel();
            btnEliminar = new ButtomDesing();
            btnagregar = new ButtomDesing();
            groupBox1 = new GroupBox();
            txtProductoID = new TextBox();
            txtCantidades = new TextBox();
            lbl_cantidad = new Label();
            lbl_Proveedor = new Label();
            lbl_precio = new Label();
            txtProveedor = new TextBox();
            lbl_fecha = new Label();
            lbl_productoID = new Label();
            txtFecha = new TextBox();
            txtPrecio = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvCompras = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnagregar);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 155);
            panel1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Brown;
            btnEliminar.BackgroundColor = Color.Brown;
            btnEliminar.BorderColor = Color.PaleVioletRed;
            btnEliminar.BorderRadius = 20;
            btnEliminar.BorderSize = 0;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(701, 66);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 35);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "- Limpiar";
            btnEliminar.TextColor = Color.White;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.MediumSlateBlue;
            btnagregar.BackgroundColor = Color.MediumSlateBlue;
            btnagregar.BorderColor = Color.Azure;
            btnagregar.BorderRadius = 20;
            btnagregar.BorderSize = 0;
            btnagregar.FlatAppearance.BorderSize = 0;
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.ForeColor = Color.White;
            btnagregar.Location = new Point(701, 22);
            btnagregar.Margin = new Padding(3, 2, 3, 2);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(124, 35);
            btnagregar.TabIndex = 24;
            btnagregar.Text = "+ Agregar";
            btnagregar.TextColor = Color.White;
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtProductoID);
            groupBox1.Controls.Add(txtCantidades);
            groupBox1.Controls.Add(lbl_cantidad);
            groupBox1.Controls.Add(lbl_Proveedor);
            groupBox1.Controls.Add(lbl_precio);
            groupBox1.Controls.Add(txtProveedor);
            groupBox1.Controls.Add(lbl_fecha);
            groupBox1.Controls.Add(lbl_productoID);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(9, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(686, 128);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Compra";
            // 
            // txtProductoID
            // 
            txtProductoID.Location = new Point(6, 39);
            txtProductoID.MaxLength = 10;
            txtProductoID.Name = "txtProductoID";
            txtProductoID.Size = new Size(234, 23);
            txtProductoID.TabIndex = 2;
            txtProductoID.TextChanged += txtProductoID_TextChanged;
            // 
            // txtCantidades
            // 
            txtCantidades.Location = new Point(6, 80);
            txtCantidades.Name = "txtCantidades";
            txtCantidades.Size = new Size(234, 23);
            txtCantidades.TabIndex = 3;
            txtCantidades.TextChanged += txt_nombre_TextChanged;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cantidad.Location = new Point(6, 65);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(55, 15);
            lbl_cantidad.TabIndex = 7;
            lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_Proveedor
            // 
            lbl_Proveedor.AutoSize = true;
            lbl_Proveedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Proveedor.Location = new Point(436, 21);
            lbl_Proveedor.Name = "lbl_Proveedor";
            lbl_Proveedor.Size = new Size(66, 15);
            lbl_Proveedor.TabIndex = 11;
            lbl_Proveedor.Text = "Proveedor";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_precio.Location = new Point(246, 21);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(42, 15);
            lbl_precio.TabIndex = 8;
            lbl_precio.Text = "Precio";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(436, 39);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(175, 23);
            txtProveedor.TabIndex = 4;
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_fecha.Location = new Point(246, 65);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(39, 15);
            lbl_fecha.TabIndex = 9;
            lbl_fecha.Text = "Fecha";
            // 
            // lbl_productoID
            // 
            lbl_productoID.AutoSize = true;
            lbl_productoID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_productoID.Location = new Point(6, 21);
            lbl_productoID.Name = "lbl_productoID";
            lbl_productoID.Size = new Size(71, 15);
            lbl_productoID.TabIndex = 6;
            lbl_productoID.Text = "ProductoID";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(246, 80);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(184, 23);
            txtFecha.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(246, 39);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(184, 23);
            txtPrecio.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 516);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 52);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvCompras);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 155);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(18, 15, 18, 15);
            panel3.Size = new Size(830, 361);
            panel3.TabIndex = 2;
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToResizeColumns = false;
            dgvCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCompras.BackgroundColor = Color.White;
            dgvCompras.BorderStyle = BorderStyle.None;
            dgvCompras.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCompras.ColumnHeadersHeight = 29;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCompras.Dock = DockStyle.Fill;
            dgvCompras.EnableHeadersVisualStyles = false;
            dgvCompras.GridColor = Color.Black;
            dgvCompras.Location = new Point(18, 15);
            dgvCompras.Margin = new Padding(3, 2, 3, 2);
            dgvCompras.MultiSelect = false;
            dgvCompras.Name = "dgvCompras";
            dgvCompras.ReadOnly = true;
            dgvCompras.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCompras.RowHeadersVisible = false;
            dgvCompras.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCompras.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCompras.RowTemplate.Height = 29;
            dgvCompras.Size = new Size(794, 331);
            dgvCompras.TabIndex = 0;
            dgvCompras.TabStop = false;
            dgvCompras.CellClick += dgvCompras_CellClick;
            // 
            // frmComprar
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
            Name = "frmComprar";
            Text = "frmProductos";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvCompras;
        private ButtomDesing btnEliminar;
        private ButtomDesing btnagregar;
        private GroupBox groupBox1;
        private TextBox txtProductoID;
        private TextBox txtCantidades;
        private Label lbl_cantidad;
        private Label lbl_Proveedor;
        private Label lbl_precio;
        private TextBox txtProveedor;
        private Label lbl_fecha;
        private Label lbl_productoID;
        private TextBox txtFecha;
        private TextBox txtPrecio;
    }
}