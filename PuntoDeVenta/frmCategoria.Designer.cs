namespace PuntoDeVenta
{
    partial class frmCategoria
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
            txtCategoria = new TextBox();
            lbl_nombre = new Label();
            txtDescripcion = new TextBox();
            btnEditar = new ButtomDesing();
            btnAgregar = new ButtomDesing();
            txtBuscarCategoria = new TextBox();
            panel3 = new Panel();
            dgvCategoria = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblIDProveedor);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtBuscarCategoria);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 170);
            panel1.TabIndex = 1;
            // 
            // lblIDProveedor
            // 
            lblIDProveedor.AutoSize = true;
            lblIDProveedor.Location = new Point(353, 22);
            lblIDProveedor.Name = "lblIDProveedor";
            lblIDProveedor.Size = new Size(10, 15);
            lblIDProveedor.TabIndex = 43;
            lblIDProveedor.Text = ".";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_cedula);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(lbl_nombre);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(10, 51);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(645, 104);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de la categoria";
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.BackColor = Color.Transparent;
            lbl_cedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cedula.Location = new Point(30, 27);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(53, 15);
            lbl_cedula.TabIndex = 19;
            lbl_cedula.Text = "Nombre";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(89, 24);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(186, 23);
            txtCategoria.TabIndex = 15;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.BackColor = Color.Transparent;
            lbl_nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(281, 32);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(72, 15);
            lbl_nombre.TabIndex = 20;
            lbl_nombre.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(371, 24);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(256, 67);
            txtDescripcion.TabIndex = 16;
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
            btnEditar.Location = new Point(688, 120);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(124, 35);
            btnEditar.TabIndex = 28;
            btnEditar.Text = "Editar";
            btnEditar.TextColor = Color.White;
            btnEditar.UseVisualStyleBackColor = false;
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
            btnAgregar.Location = new Point(688, 75);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(124, 35);
            btnAgregar.TabIndex = 27;
            btnAgregar.Text = "+ Agregar";
            btnAgregar.TextColor = Color.White;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtBuscarCategoria
            // 
            txtBuscarCategoria.BackColor = Color.White;
            txtBuscarCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarCategoria.Location = new Point(18, 20);
            txtBuscarCategoria.Margin = new Padding(3, 2, 3, 2);
            txtBuscarCategoria.Name = "txtBuscarCategoria";
            txtBuscarCategoria.PlaceholderText = "Buscar";
            txtBuscarCategoria.Size = new Size(316, 23);
            txtBuscarCategoria.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvCategoria);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 170);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(18, 15, 18, 15);
            panel3.Size = new Size(818, 228);
            panel3.TabIndex = 4;
            // 
            // dgvCategoria
            // 
            dgvCategoria.AllowUserToAddRows = false;
            dgvCategoria.AllowUserToDeleteRows = false;
            dgvCategoria.AllowUserToResizeColumns = false;
            dgvCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dgvCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCategoria.BackgroundColor = Color.White;
            dgvCategoria.BorderStyle = BorderStyle.None;
            dgvCategoria.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCategoria.ColumnHeadersHeight = 29;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvCategoria.DefaultCellStyle = dataGridViewCellStyle8;
            dgvCategoria.EnableHeadersVisualStyles = false;
            dgvCategoria.GridColor = Color.Black;
            dgvCategoria.Location = new Point(10, 15);
            dgvCategoria.Margin = new Padding(3, 2, 3, 2);
            dgvCategoria.MultiSelect = false;
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            dgvCategoria.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvCategoria.RowHeadersVisible = false;
            dgvCategoria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCategoria.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvCategoria.RowTemplate.Height = 29;
            dgvCategoria.Size = new Size(796, 209);
            dgvCategoria.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 398);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(818, 52);
            panel2.TabIndex = 3;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategoria";
            Text = "frmCategoria";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblIDProveedor;
        private GroupBox groupBox1;
        private Label lbl_cedula;
        private TextBox txtCategoria;
        private Label lbl_nombre;
        private TextBox txtDescripcion;
        private ButtomDesing btnEditar;
        private ButtomDesing btnAgregar;
        private TextBox txtBuscarCategoria;
        private Panel panel3;
        private DataGridView dgvCategoria;
        private Panel panel2;
    }
}