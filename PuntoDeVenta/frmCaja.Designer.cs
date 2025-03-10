namespace PuntoDeVenta
{
    partial class frmCaja
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
            groupBox1 = new GroupBox();
            dtp_FechaCaja = new DateTimePicker();
            cmbtipocaja = new ComboBox();
            txt_montoCaja = new TextBox();
            label2 = new Label();
            lbl_cedula = new Label();
            txt_descripcionCaja = new TextBox();
            lbl_nombre = new Label();
            lbl_nombreRefe = new Label();
            lblIDCaja = new Label();
            btnEliminarCaja = new ButtomDesing();
            btnEditarCaja = new ButtomDesing();
            btnAgregar = new ButtomDesing();
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            dgvCajaEgresos = new DataGridView();
            dgvCajasIngresos = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCajaEgresos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCajasIngresos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblIDCaja);
            panel1.Controls.Add(btnEliminarCaja);
            panel1.Controls.Add(btnEditarCaja);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 222);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtp_FechaCaja);
            groupBox1.Controls.Add(cmbtipocaja);
            groupBox1.Controls.Add(txt_montoCaja);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lbl_cedula);
            groupBox1.Controls.Add(txt_descripcionCaja);
            groupBox1.Controls.Add(lbl_nombre);
            groupBox1.Controls.Add(lbl_nombreRefe);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 48);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(661, 167);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Caja";
            // 
            // dtp_FechaCaja
            // 
            dtp_FechaCaja.Enabled = false;
            dtp_FechaCaja.Location = new Point(114, 28);
            dtp_FechaCaja.Name = "dtp_FechaCaja";
            dtp_FechaCaja.Size = new Size(206, 23);
            dtp_FechaCaja.TabIndex = 32;
            // 
            // cmbtipocaja
            // 
            cmbtipocaja.FormattingEnabled = true;
            cmbtipocaja.Items.AddRange(new object[] { "--Seleccion una Opción--", "Ingreso", "Egreso" });
            cmbtipocaja.Location = new Point(420, 35);
            cmbtipocaja.Name = "cmbtipocaja";
            cmbtipocaja.Size = new Size(178, 23);
            cmbtipocaja.TabIndex = 31;
            // 
            // txt_montoCaja
            // 
            txt_montoCaja.Location = new Point(420, 72);
            txt_montoCaja.Name = "txt_montoCaja";
            txt_montoCaja.Size = new Size(178, 23);
            txt_montoCaja.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(341, 72);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 29;
            label2.Text = "Monto";
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cedula.Location = new Point(14, 28);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(39, 15);
            lbl_cedula.TabIndex = 19;
            lbl_cedula.Text = "Fecha";
            // 
            // txt_descripcionCaja
            // 
            txt_descripcionCaja.Location = new Point(114, 70);
            txt_descripcionCaja.Multiline = true;
            txt_descripcionCaja.Name = "txt_descripcionCaja";
            txt_descripcionCaja.Size = new Size(174, 23);
            txt_descripcionCaja.TabIndex = 16;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(14, 71);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(72, 15);
            lbl_nombre.TabIndex = 20;
            lbl_nombre.Text = "Descripción";
            // 
            // lbl_nombreRefe
            // 
            lbl_nombreRefe.AutoSize = true;
            lbl_nombreRefe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombreRefe.Location = new Point(341, 35);
            lbl_nombreRefe.Name = "lbl_nombreRefe";
            lbl_nombreRefe.Size = new Size(31, 15);
            lbl_nombreRefe.TabIndex = 22;
            lbl_nombreRefe.Text = "Tipo";
            // 
            // lblIDCaja
            // 
            lblIDCaja.AutoSize = true;
            lblIDCaja.Location = new Point(353, 23);
            lblIDCaja.Name = "lblIDCaja";
            lblIDCaja.Size = new Size(10, 15);
            lblIDCaja.TabIndex = 42;
            lblIDCaja.Text = ".";
            // 
            // btnEliminarCaja
            // 
            btnEliminarCaja.BackColor = Color.Brown;
            btnEliminarCaja.BackgroundColor = Color.Brown;
            btnEliminarCaja.BorderColor = Color.PaleVioletRed;
            btnEliminarCaja.BorderRadius = 20;
            btnEliminarCaja.BorderSize = 0;
            btnEliminarCaja.FlatAppearance.BorderSize = 0;
            btnEliminarCaja.FlatStyle = FlatStyle.Flat;
            btnEliminarCaja.ForeColor = Color.White;
            btnEliminarCaja.Location = new Point(683, 177);
            btnEliminarCaja.Margin = new Padding(3, 2, 3, 2);
            btnEliminarCaja.Name = "btnEliminarCaja";
            btnEliminarCaja.Size = new Size(126, 38);
            btnEliminarCaja.TabIndex = 4;
            btnEliminarCaja.Text = "- Eliminar";
            btnEliminarCaja.TextColor = Color.White;
            btnEliminarCaja.UseVisualStyleBackColor = false;
            btnEliminarCaja.Click += btnEliminarCaja_Click;
            // 
            // btnEditarCaja
            // 
            btnEditarCaja.BackColor = Color.SandyBrown;
            btnEditarCaja.BackgroundColor = Color.SandyBrown;
            btnEditarCaja.BorderColor = Color.PaleVioletRed;
            btnEditarCaja.BorderRadius = 20;
            btnEditarCaja.BorderSize = 0;
            btnEditarCaja.FlatAppearance.BorderSize = 0;
            btnEditarCaja.FlatStyle = FlatStyle.Flat;
            btnEditarCaja.ForeColor = Color.White;
            btnEditarCaja.Location = new Point(683, 118);
            btnEditarCaja.Margin = new Padding(3, 2, 3, 2);
            btnEditarCaja.Name = "btnEditarCaja";
            btnEditarCaja.Size = new Size(126, 38);
            btnEditarCaja.TabIndex = 5;
            btnEditarCaja.Text = "Editar";
            btnEditarCaja.TextColor = Color.White;
            btnEditarCaja.UseVisualStyleBackColor = false;
            btnEditarCaja.Click += btnEditarCaja_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(38, 70, 83);
            btnAgregar.BackgroundColor = Color.FromArgb(38, 70, 83);
            btnAgregar.BorderColor = Color.PaleVioletRed;
            btnAgregar.BorderRadius = 20;
            btnAgregar.BorderSize = 0;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(683, 60);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(126, 38);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "+ Agregar";
            btnAgregar.TextColor = Color.White;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(16, 21);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar";
            textBox1.Size = new Size(316, 23);
            textBox1.TabIndex = 0;
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
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dgvCajaEgresos);
            panel3.Controls.Add(dgvCajasIngresos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 222);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(18, 15, 18, 15);
            panel3.Size = new Size(830, 294);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(141, 15);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 44;
            label4.Text = "Ingreso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(585, 15);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 31;
            label3.Text = "Egreso";
            // 
            // dgvCajaEgresos
            // 
            dgvCajaEgresos.AllowUserToAddRows = false;
            dgvCajaEgresos.AllowUserToResizeColumns = false;
            dgvCajaEgresos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvCajaEgresos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCajaEgresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCajaEgresos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCajaEgresos.BackgroundColor = Color.White;
            dgvCajaEgresos.BorderStyle = BorderStyle.None;
            dgvCajaEgresos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCajaEgresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCajaEgresos.ColumnHeadersHeight = 29;
            dgvCajaEgresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCajaEgresos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCajaEgresos.EnableHeadersVisualStyles = false;
            dgvCajaEgresos.GridColor = Color.Black;
            dgvCajaEgresos.Location = new Point(425, 59);
            dgvCajaEgresos.Margin = new Padding(3, 2, 3, 2);
            dgvCajaEgresos.MultiSelect = false;
            dgvCajaEgresos.Name = "dgvCajaEgresos";
            dgvCajaEgresos.ReadOnly = true;
            dgvCajaEgresos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCajaEgresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCajaEgresos.RowHeadersVisible = false;
            dgvCajaEgresos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCajaEgresos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCajaEgresos.RowTemplate.Height = 29;
            dgvCajaEgresos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCajaEgresos.Size = new Size(384, 218);
            dgvCajaEgresos.TabIndex = 43;
            dgvCajaEgresos.CellContentClick += dgvCajaEgresos_CellContentClick;
            // 
            // dgvCajasIngresos
            // 
            dgvCajasIngresos.AllowUserToAddRows = false;
            dgvCajasIngresos.AllowUserToResizeColumns = false;
            dgvCajasIngresos.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dgvCajasIngresos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCajasIngresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCajasIngresos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCajasIngresos.BackgroundColor = Color.White;
            dgvCajasIngresos.BorderStyle = BorderStyle.None;
            dgvCajasIngresos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCajasIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCajasIngresos.ColumnHeadersHeight = 29;
            dgvCajasIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvCajasIngresos.DefaultCellStyle = dataGridViewCellStyle8;
            dgvCajasIngresos.EnableHeadersVisualStyles = false;
            dgvCajasIngresos.GridColor = Color.Black;
            dgvCajasIngresos.Location = new Point(12, 59);
            dgvCajasIngresos.Margin = new Padding(3, 2, 3, 2);
            dgvCajasIngresos.MultiSelect = false;
            dgvCajasIngresos.Name = "dgvCajasIngresos";
            dgvCajasIngresos.ReadOnly = true;
            dgvCajasIngresos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvCajasIngresos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvCajasIngresos.RowHeadersVisible = false;
            dgvCajasIngresos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCajasIngresos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvCajasIngresos.RowTemplate.Height = 29;
            dgvCajasIngresos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCajasIngresos.Size = new Size(384, 218);
            dgvCajasIngresos.TabIndex = 0;
            dgvCajasIngresos.CellContentClick += dgvCajas_CellContentClick;
            // 
            // frmCaja
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
            Name = "frmCaja";
            Text = "frmProductos";
            Load += frmCaja_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCajaEgresos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCajasIngresos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvCajasIngresos;
        private TextBox textBox1;
        private ButtomDesing btnEliminarCaja;
        private ButtomDesing btnEditarCaja;
        private ButtomDesing btnAgregar;
        private GroupBox groupBox1;
        private TextBox txt_montoCaja;
        private Label label2;
        private Label lbl_cedula;
        private TextBox txt_descripcionCaja;
        private Label lbl_nombre;
        private Label lbl_nombreRefe;
        private TextBox txt_tipoCaja;
        private Label lblIDCaja;
        private DataGridView dgvCajaEgresos;
        private Label label4;
        private Label label3;
        private ComboBox cmbtipocaja;
        private DateTimePicker dtp_FechaCaja;
    }
}