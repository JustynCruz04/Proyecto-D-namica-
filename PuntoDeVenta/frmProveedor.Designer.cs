namespace PuntoDeVenta
{
    partial class frmProveedor
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblIDProveedor = new Label();
            groupBox1 = new GroupBox();
            lbl_cedula = new Label();
            txt_nombreProveedor = new TextBox();
            lbl_nombre = new Label();
            txt_TelefonoProveedor = new TextBox();
            lbl_telefonoRef = new Label();
            txt_direccionProveedor = new TextBox();
            btnEliminar = new ButtomDesing();
            btnEditar = new ButtomDesing();
            btnAgregar = new ButtomDesing();
            txtBuscarProveedor = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvProveedores = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblIDProveedor);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtBuscarProveedor);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 227);
            panel1.TabIndex = 0;
            // 
            // lblIDProveedor
            // 
            lblIDProveedor.AutoSize = true;
            lblIDProveedor.Location = new Point(403, 29);
            lblIDProveedor.Name = "lblIDProveedor";
            lblIDProveedor.Size = new Size(12, 20);
            lblIDProveedor.TabIndex = 43;
            lblIDProveedor.Text = ".";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_cedula);
            groupBox1.Controls.Add(txt_nombreProveedor);
            groupBox1.Controls.Add(lbl_nombre);
            groupBox1.Controls.Add(txt_TelefonoProveedor);
            groupBox1.Controls.Add(lbl_telefonoRef);
            groupBox1.Controls.Add(txt_direccionProveedor);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(737, 139);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Proveedor";
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.BackColor = Color.Transparent;
            lbl_cedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cedula.Location = new Point(63, 36);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(67, 20);
            lbl_cedula.TabIndex = 19;
            lbl_cedula.Text = "Nombre";
            // 
            // txt_nombreProveedor
            // 
            txt_nombreProveedor.Location = new Point(152, 32);
            txt_nombreProveedor.Margin = new Padding(3, 4, 3, 4);
            txt_nombreProveedor.Name = "txt_nombreProveedor";
            txt_nombreProveedor.Size = new Size(146, 27);
            txt_nombreProveedor.TabIndex = 15;
            txt_nombreProveedor.TextChanged += txt_nombreProveedor_TextChanged;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.BackColor = Color.Transparent;
            lbl_nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(392, 36);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(70, 20);
            lbl_nombre.TabIndex = 20;
            lbl_nombre.Text = "Telefono";
            // 
            // txt_TelefonoProveedor
            // 
            txt_TelefonoProveedor.Location = new Point(482, 32);
            txt_TelefonoProveedor.Margin = new Padding(3, 4, 3, 4);
            txt_TelefonoProveedor.Name = "txt_TelefonoProveedor";
            txt_TelefonoProveedor.Size = new Size(146, 27);
            txt_TelefonoProveedor.TabIndex = 16;
            // 
            // lbl_telefonoRef
            // 
            lbl_telefonoRef.AutoSize = true;
            lbl_telefonoRef.BackColor = Color.Transparent;
            lbl_telefonoRef.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_telefonoRef.Location = new Point(56, 97);
            lbl_telefonoRef.Name = "lbl_telefonoRef";
            lbl_telefonoRef.Size = new Size(74, 20);
            lbl_telefonoRef.TabIndex = 24;
            lbl_telefonoRef.Text = "Dirección";
            // 
            // txt_direccionProveedor
            // 
            txt_direccionProveedor.Location = new Point(152, 93);
            txt_direccionProveedor.Margin = new Padding(3, 4, 3, 4);
            txt_direccionProveedor.Name = "txt_direccionProveedor";
            txt_direccionProveedor.Size = new Size(146, 27);
            txt_direccionProveedor.TabIndex = 23;
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
            btnEliminar.Location = new Point(786, 165);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 47);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "- Eliminar";
            btnEliminar.TextColor = Color.White;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnEditar.Location = new Point(786, 104);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(142, 47);
            btnEditar.TabIndex = 28;
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
            btnAgregar.Location = new Point(786, 37);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(142, 47);
            btnAgregar.TabIndex = 27;
            btnAgregar.Text = "+ Agregar";
            btnAgregar.TextColor = Color.White;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.BackColor = Color.White;
            txtBuscarProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarProveedor.Location = new Point(21, 27);
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.PlaceholderText = "Buscar";
            txtBuscarProveedor.Size = new Size(361, 27);
            txtBuscarProveedor.TabIndex = 0;
            txtBuscarProveedor.TextChanged += txtBuscarProveedor_TextChanged;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 688);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 69);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvProveedores);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 227);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(21, 20, 21, 20);
            panel3.Size = new Size(949, 461);
            panel3.TabIndex = 2;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToResizeColumns = false;
            dgvProveedores.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dgvProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvProveedores.ColumnHeadersHeight = 29;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvProveedores.DefaultCellStyle = dataGridViewCellStyle8;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.GridColor = Color.Black;
            dgvProveedores.Location = new Point(21, 20);
            dgvProveedores.MultiSelect = false;
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvProveedores.RowTemplate.Height = 29;
            dgvProveedores.Size = new Size(907, 436);
            dgvProveedores.TabIndex = 0;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            dgvProveedores.CellContentDoubleClick += dgvProveedores_CellContentDoubleClick;
            // 
            // frmProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(949, 757);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProveedor";
            Text = "frmProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvProveedores;
        private TextBox txtBuscarProveedor;
        private Label lbl_telefonoRef;
        private TextBox txt_direccionProveedor;
        private Label lbl_nombre;
        private Label lbl_cedula;
        private TextBox txt_TelefonoProveedor;
        private TextBox txt_nombreProveedor;
        private ButtomDesing btnAgregar;
        private ButtomDesing btnEditar;
        private GroupBox groupBox1;
        private ButtomDesing btnEliminar;
        private Label lblIDProveedor;
    }
}