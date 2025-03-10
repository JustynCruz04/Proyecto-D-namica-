namespace PuntoDeVenta
{
    partial class frmBodega
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
            lblID = new Label();
            groupBox1 = new GroupBox();
            txt_Nombre = new TextBox();
            lbl_cedula = new Label();
            lbl_nombre = new Label();
            txt_Ubicacion = new TextBox();
            lbl_telefonoRef = new Label();
            txt_EmpleadoID = new TextBox();
            btnEliminar = new ButtomDesing();
            btnEditar = new ButtomDesing();
            btnAgregar = new ButtomDesing();
            txtBuscarBodega = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvBodega = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBodega).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtBuscarBodega);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 255);
            panel1.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(393, 37);
            lblID.Name = "lblID";
            lblID.Size = new Size(12, 20);
            lblID.TabIndex = 41;
            lblID.Text = ".";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Nombre);
            groupBox1.Controls.Add(lbl_cedula);
            groupBox1.Controls.Add(lbl_nombre);
            groupBox1.Controls.Add(txt_Ubicacion);
            groupBox1.Controls.Add(lbl_telefonoRef);
            groupBox1.Controls.Add(txt_EmpleadoID);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(21, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 161);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Bodega";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(80, 47);
            txt_Nombre.Margin = new Padding(3, 4, 3, 4);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(234, 27);
            txt_Nombre.TabIndex = 29;
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cedula.Location = new Point(10, 53);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(67, 20);
            lbl_cedula.TabIndex = 31;
            lbl_cedula.Text = "Nombre";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(358, 57);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(77, 20);
            lbl_nombre.TabIndex = 32;
            lbl_nombre.Text = "Ubicación";
            // 
            // txt_Ubicacion
            // 
            txt_Ubicacion.Location = new Point(433, 49);
            txt_Ubicacion.Margin = new Padding(3, 4, 3, 4);
            txt_Ubicacion.Name = "txt_Ubicacion";
            txt_Ubicacion.Size = new Size(243, 27);
            txt_Ubicacion.TabIndex = 30;
            // 
            // lbl_telefonoRef
            // 
            lbl_telefonoRef.AutoSize = true;
            lbl_telefonoRef.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_telefonoRef.Location = new Point(10, 115);
            lbl_telefonoRef.Name = "lbl_telefonoRef";
            lbl_telefonoRef.Size = new Size(98, 20);
            lbl_telefonoRef.TabIndex = 34;
            lbl_telefonoRef.Text = "Empleado ID";
            // 
            // txt_EmpleadoID
            // 
            txt_EmpleadoID.Location = new Point(102, 111);
            txt_EmpleadoID.Margin = new Padding(3, 4, 3, 4);
            txt_EmpleadoID.Name = "txt_EmpleadoID";
            txt_EmpleadoID.Size = new Size(212, 27);
            txt_EmpleadoID.TabIndex = 33;
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
            btnEliminar.Location = new Point(795, 192);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 47);
            btnEliminar.TabIndex = 39;
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
            btnEditar.Location = new Point(793, 124);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(142, 47);
            btnEditar.TabIndex = 38;
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
            btnAgregar.Location = new Point(795, 61);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(142, 47);
            btnAgregar.TabIndex = 37;
            btnAgregar.Text = "+ Agregar";
            btnAgregar.TextColor = Color.White;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtBuscarBodega
            // 
            txtBuscarBodega.BackColor = Color.White;
            txtBuscarBodega.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarBodega.Location = new Point(31, 35);
            txtBuscarBodega.Name = "txtBuscarBodega";
            txtBuscarBodega.PlaceholderText = "Buscar";
            txtBuscarBodega.Size = new Size(325, 27);
            txtBuscarBodega.TabIndex = 27;
            txtBuscarBodega.TextChanged += txtBuscarBodega_TextChanged;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 713);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 44);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvBodega);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 255);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(21, 20, 21, 20);
            panel3.Size = new Size(949, 458);
            panel3.TabIndex = 2;
            // 
            // dgvBodega
            // 
            dgvBodega.AllowUserToAddRows = false;
            dgvBodega.AllowUserToResizeColumns = false;
            dgvBodega.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dgvBodega.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvBodega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBodega.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBodega.BackgroundColor = Color.White;
            dgvBodega.BorderStyle = BorderStyle.None;
            dgvBodega.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvBodega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvBodega.ColumnHeadersHeight = 29;
            dgvBodega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvBodega.DefaultCellStyle = dataGridViewCellStyle8;
            dgvBodega.EnableHeadersVisualStyles = false;
            dgvBodega.GridColor = Color.Black;
            dgvBodega.Location = new Point(21, 23);
            dgvBodega.MultiSelect = false;
            dgvBodega.Name = "dgvBodega";
            dgvBodega.ReadOnly = true;
            dgvBodega.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvBodega.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvBodega.RowHeadersVisible = false;
            dgvBodega.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBodega.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvBodega.RowTemplate.Height = 29;
            dgvBodega.Size = new Size(907, 413);
            dgvBodega.TabIndex = 0;
            dgvBodega.CellContentDoubleClick += dgvBodegas_CellContentDoubleClick;
            // 
            // frmBodega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(949, 757);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBodega";
            Text = "frmProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBodega).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvBodega;
        private Label lbl_telefonoRef;
        private TextBox txt_EmpleadoID;
        private Label lbl_nombre;
        private Label lbl_cedula;
        private TextBox txt_Ubicacion;
        private TextBox txt_Nombre;
        private TextBox txtBuscarBodega;
        private ButtomDesing btnAgregar;
        private ButtomDesing btnEditar;
        private GroupBox groupBox1;
        private ButtomDesing btnEliminar;
        private Label lblID;
    }
}