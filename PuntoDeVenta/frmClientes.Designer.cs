namespace PuntoDeVenta
{
    partial class frmClientes
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
            panel1 = new Panel();
            lblID = new Label();
            btnEliminar = new ButtomDesing();
            btnEditar = new ButtomDesing();
            btnAgregar = new ButtomDesing();
            groupBox1 = new GroupBox();
            txt_cedula = new TextBox();
            txt_nombre = new TextBox();
            lbl_nombre = new Label();
            lbl_telefonoRef = new Label();
            lbl_telefono = new Label();
            txt_Telefono = new TextBox();
            txt_nombRef = new TextBox();
            lbl_nombreRefe = new Label();
            lbl_cedula = new Label();
            txt_telefRef = new TextBox();
            txtBuscarCliente = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btn_numerocliente1 = new ButtomDesing();
            dgv_ventascliente = new DataGridView();
            txt_nombreCliente = new TextBox();
            dgvClientes = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ventascliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txtBuscarCliente);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 182);
            panel1.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(351, 21);
            lblID.Name = "lblID";
            lblID.Size = new Size(10, 15);
            lblID.TabIndex = 18;
            lblID.Text = ".";
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
            btnEliminar.Location = new Point(704, 127);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 35);
            btnEliminar.TabIndex = 17;
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
            btnEditar.Location = new Point(704, 88);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(124, 35);
            btnEditar.TabIndex = 12;
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
            btnAgregar.Location = new Point(704, 48);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(124, 35);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "+ Agregar";
            btnAgregar.TextColor = Color.White;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_cedula);
            groupBox1.Controls.Add(txt_nombre);
            groupBox1.Controls.Add(lbl_nombre);
            groupBox1.Controls.Add(lbl_telefonoRef);
            groupBox1.Controls.Add(lbl_telefono);
            groupBox1.Controls.Add(txt_Telefono);
            groupBox1.Controls.Add(txt_nombRef);
            groupBox1.Controls.Add(lbl_nombreRefe);
            groupBox1.Controls.Add(lbl_cedula);
            groupBox1.Controls.Add(txt_telefRef);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(15, 47);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(686, 128);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Cliente";
            // 
            // txt_cedula
            // 
            txt_cedula.Location = new Point(67, 33);
            txt_cedula.MaxLength = 10;
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(123, 23);
            txt_cedula.TabIndex = 2;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(67, 84);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(234, 23);
            txt_nombre.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(6, 86);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(53, 15);
            lbl_nombre.TabIndex = 7;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_telefonoRef
            // 
            lbl_telefonoRef.AutoSize = true;
            lbl_telefonoRef.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_telefonoRef.Location = new Point(397, 36);
            lbl_telefonoRef.Name = "lbl_telefonoRef";
            lbl_telefonoRef.Size = new Size(134, 15);
            lbl_telefonoRef.TabIndex = 11;
            lbl_telefonoRef.Text = "Telefono de referencia";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_telefono.Location = new Point(201, 38);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(56, 15);
            lbl_telefono.TabIndex = 8;
            lbl_telefono.Text = "Telefono";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(271, 35);
            txt_Telefono.MaxLength = 10;
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(103, 23);
            txt_Telefono.TabIndex = 4;
            // 
            // txt_nombRef
            // 
            txt_nombRef.Location = new Point(447, 86);
            txt_nombRef.MaxLength = 10;
            txt_nombRef.Name = "txt_nombRef";
            txt_nombRef.Size = new Size(114, 23);
            txt_nombRef.TabIndex = 5;
            // 
            // lbl_nombreRefe
            // 
            lbl_nombreRefe.AutoSize = true;
            lbl_nombreRefe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombreRefe.Location = new Point(307, 86);
            lbl_nombreRefe.Name = "lbl_nombreRefe";
            lbl_nombreRefe.Size = new Size(134, 15);
            lbl_nombreRefe.TabIndex = 9;
            lbl_nombreRefe.Text = "Nombre de Referencia";
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cedula.Location = new Point(6, 38);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(44, 15);
            lbl_cedula.TabIndex = 6;
            lbl_cedula.Text = "Cedula";
            // 
            // txt_telefRef
            // 
            txt_telefRef.Location = new Point(537, 35);
            txt_telefRef.Name = "txt_telefRef";
            txt_telefRef.Size = new Size(143, 23);
            txt_telefRef.TabIndex = 10;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.BackColor = Color.White;
            txtBuscarCliente.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarCliente.Location = new Point(21, 13);
            txtBuscarCliente.Margin = new Padding(3, 2, 3, 2);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.PlaceholderText = "Buscar";
            txtBuscarCliente.Size = new Size(104, 23);
            txtBuscarCliente.TabIndex = 0;
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 535);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 33);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_numerocliente1);
            panel3.Controls.Add(dgv_ventascliente);
            panel3.Controls.Add(txt_nombreCliente);
            panel3.Controls.Add(dgvClientes);
            panel3.Location = new Point(0, 184);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(18, 15, 18, 15);
            panel3.Size = new Size(830, 358);
            panel3.TabIndex = 2;
            // 
            // btn_numerocliente1
            // 
            btn_numerocliente1.BackColor = Color.Snow;
            btn_numerocliente1.BackgroundColor = Color.Snow;
            btn_numerocliente1.BorderColor = Color.PaleVioletRed;
            btn_numerocliente1.BorderRadius = 20;
            btn_numerocliente1.BorderSize = 0;
            btn_numerocliente1.FlatAppearance.BorderSize = 0;
            btn_numerocliente1.FlatStyle = FlatStyle.Flat;
            btn_numerocliente1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_numerocliente1.ForeColor = Color.Black;
            btn_numerocliente1.Location = new Point(15, 188);
            btn_numerocliente1.Margin = new Padding(3, 2, 3, 2);
            btn_numerocliente1.Name = "btn_numerocliente1";
            btn_numerocliente1.Size = new Size(164, 37);
            btn_numerocliente1.TabIndex = 6;
            btn_numerocliente1.Text = "Ventas por Cliente";
            btn_numerocliente1.TextColor = Color.Black;
            btn_numerocliente1.UseVisualStyleBackColor = false;
            btn_numerocliente1.Click += btn_numerocliente1_Click;
            // 
            // dgv_ventascliente
            // 
            dgv_ventascliente.AllowUserToAddRows = false;
            dgv_ventascliente.AllowUserToResizeColumns = false;
            dgv_ventascliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgv_ventascliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_ventascliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ventascliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_ventascliente.BackgroundColor = Color.White;
            dgv_ventascliente.BorderStyle = BorderStyle.None;
            dgv_ventascliente.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_ventascliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_ventascliente.ColumnHeadersHeight = 29;
            dgv_ventascliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_ventascliente.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_ventascliente.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_ventascliente.EnableHeadersVisualStyles = false;
            dgv_ventascliente.GridColor = Color.Black;
            dgv_ventascliente.Location = new Point(12, 239);
            dgv_ventascliente.Margin = new Padding(3, 2, 3, 2);
            dgv_ventascliente.MultiSelect = false;
            dgv_ventascliente.Name = "dgv_ventascliente";
            dgv_ventascliente.ReadOnly = true;
            dgv_ventascliente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_ventascliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_ventascliente.RowHeadersVisible = false;
            dgv_ventascliente.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv_ventascliente.RowTemplate.Height = 29;
            dgv_ventascliente.Size = new Size(794, 106);
            dgv_ventascliente.TabIndex = 5;
            // 
            // txt_nombreCliente
            // 
            txt_nombreCliente.Location = new Point(216, 196);
            txt_nombreCliente.Name = "txt_nombreCliente";
            txt_nombreCliente.Size = new Size(173, 23);
            txt_nombreCliente.TabIndex = 4;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvClientes.ColumnHeadersHeight = 29;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Cursor = Cursors.Hand;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle7;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.Black;
            dgvClientes.Location = new Point(15, 17);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(794, 167);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            dgvClientes.CellContentDoubleClick += dgvClientes_CellContentDoubleClick;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(830, 568);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmClientes";
            Text = "frmProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ventascliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvClientes;
        private TextBox txtBuscarCliente;
        private TextBox txt_nombreCliente;
        private TextBox txt_nombRef;
        private TextBox txt_Telefono;
        private TextBox txt_nombre;
        private TextBox txt_cedula;
        private Label lbl_nombre;
        private Label lbl_cedula;
        private Label lbl_telefonoRef;
        private TextBox txt_telefRef;
        private Label lbl_nombreRefe;
        private Label lbl_telefono;
        private DataGridView dgv_ventascliente;
        private GroupBox groupBox1;
        private ButtomDesing btnAgregar;
        private ButtomDesing btnEditar;
        private ButtomDesing btnEliminar;
        private ButtomDesing btn_numerocliente1;
        private Label lblID;
    }
}