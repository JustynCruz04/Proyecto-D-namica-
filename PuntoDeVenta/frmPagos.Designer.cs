namespace PuntoDeVenta
{
    partial class frmPagos
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
            txt_ClienteID = new TextBox();
            txt_ProductoID = new TextBox();
            lbl_cedula = new Label();
            lbl_nombre = new Label();
            label2 = new Label();
            txt_CajaID = new TextBox();
            lbl_telefonoRef = new Label();
            txt_monto = new TextBox();
            label1 = new Label();
            txt_usuario = new TextBox();
            btnEliminar = new ButtomDesing();
            btnEditar = new ButtomDesing();
            btnAgregar = new ButtomDesing();
            textBox4 = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvPagos = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(textBox4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 216);
            panel1.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(356, 37);
            lblID.Name = "lblID";
            lblID.Size = new Size(10, 15);
            lblID.TabIndex = 55;
            lblID.Text = ".";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_ClienteID);
            groupBox1.Controls.Add(txt_ProductoID);
            groupBox1.Controls.Add(lbl_cedula);
            groupBox1.Controls.Add(lbl_nombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_CajaID);
            groupBox1.Controls.Add(lbl_telefonoRef);
            groupBox1.Controls.Add(txt_monto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_usuario);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 63);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(644, 141);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle del Pago";
            // 
            // txt_ClienteID
            // 
            txt_ClienteID.Location = new Point(92, 18);
            txt_ClienteID.Name = "txt_ClienteID";
            txt_ClienteID.Size = new Size(128, 23);
            txt_ClienteID.TabIndex = 39;
            // 
            // txt_ProductoID
            // 
            txt_ProductoID.Location = new Point(92, 59);
            txt_ProductoID.Name = "txt_ProductoID";
            txt_ProductoID.Size = new Size(128, 23);
            txt_ProductoID.TabIndex = 40;
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cedula.Location = new Point(5, 22);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(62, 15);
            lbl_cedula.TabIndex = 41;
            lbl_cedula.Text = "Cliente ID";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(5, 61);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(74, 15);
            lbl_nombre.TabIndex = 42;
            lbl_nombre.Text = "Producto ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 112);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 50;
            label2.Text = "Caja ID";
            // 
            // txt_CajaID
            // 
            txt_CajaID.Location = new Point(92, 104);
            txt_CajaID.Name = "txt_CajaID";
            txt_CajaID.Size = new Size(128, 23);
            txt_CajaID.TabIndex = 49;
            // 
            // lbl_telefonoRef
            // 
            lbl_telefonoRef.AutoSize = true;
            lbl_telefonoRef.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_telefonoRef.Location = new Point(362, 27);
            lbl_telefonoRef.Name = "lbl_telefonoRef";
            lbl_telefonoRef.Size = new Size(44, 15);
            lbl_telefonoRef.TabIndex = 44;
            lbl_telefonoRef.Text = "Monto";
            // 
            // txt_monto
            // 
            txt_monto.Location = new Point(423, 19);
            txt_monto.Name = "txt_monto";
            txt_monto.Size = new Size(146, 23);
            txt_monto.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(358, 66);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 48;
            label1.Text = "Usuario";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(423, 55);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(146, 23);
            txt_usuario.TabIndex = 47;
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
            btnEliminar.Location = new Point(688, 165);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 35);
            btnEliminar.TabIndex = 53;
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
            btnEditar.Location = new Point(688, 118);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(124, 35);
            btnEditar.TabIndex = 52;
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
            btnAgregar.Location = new Point(688, 65);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(124, 35);
            btnAgregar.TabIndex = 51;
            btnAgregar.Text = "+ Agregar";
            btnAgregar.TextColor = Color.White;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(23, 29);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Buscar";
            textBox4.Size = new Size(316, 23);
            textBox4.TabIndex = 37;
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
            panel3.Controls.Add(dgvPagos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 216);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(18, 15, 18, 15);
            panel3.Size = new Size(830, 300);
            panel3.TabIndex = 2;
            // 
            // dgvPagos
            // 
            dgvPagos.AllowUserToAddRows = false;
            dgvPagos.AllowUserToOrderColumns = true;
            dgvPagos.AllowUserToResizeColumns = false;
            dgvPagos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPagos.BackgroundColor = Color.White;
            dgvPagos.BorderStyle = BorderStyle.None;
            dgvPagos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPagos.ColumnHeadersHeight = 29;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPagos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPagos.EnableHeadersVisualStyles = false;
            dgvPagos.GridColor = Color.Black;
            dgvPagos.Location = new Point(18, 15);
            dgvPagos.Margin = new Padding(3, 2, 3, 2);
            dgvPagos.MultiSelect = false;
            dgvPagos.Name = "dgvPagos";
            dgvPagos.ReadOnly = true;
            dgvPagos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPagos.RowHeadersVisible = false;
            dgvPagos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvPagos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvPagos.RowTemplate.Height = 29;
            dgvPagos.Size = new Size(794, 273);
            dgvPagos.TabIndex = 0;
            dgvPagos.CellContentClick += dgvPagos_CellContentClick;
            dgvPagos.CellContentDoubleClick += dgvPagos_CellContentDoubleClick;
            // 
            // frmPagos
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
            Name = "frmPagos";
            Text = "frmProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvPagos;
        private Label label2;
        private TextBox txt_CajaID;
        private Label label1;
        private TextBox txt_usuario;
        private Label lbl_telefonoRef;
        private TextBox txt_monto;
        private Label lbl_nombre;
        private Label lbl_cedula;
        private TextBox txt_ProductoID;
        private TextBox txt_ClienteID;
        private TextBox textBox4;
        private ButtomDesing btnAgregar;
        private ButtomDesing btnEditar;
        private GroupBox groupBox1;
        private ButtomDesing btnEliminar;
        private Label lblID;
    }
}