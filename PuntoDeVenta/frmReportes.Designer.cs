namespace PuntoDeVenta
{
    partial class frmReportes
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
            label4 = new Label();
            btnGuardar = new ButtomDesing();
            panel2 = new Panel();
            panel3 = new Panel();
            lbl_cedula = new Label();
            cbReporte = new ComboBox();
            dgvVer = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 50);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(38, 70, 83);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(21, 0, 0, 0);
            label4.Size = new Size(949, 50);
            label4.TabIndex = 5;
            label4.Text = "Reportes";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(38, 70, 83);
            btnGuardar.BackgroundColor = Color.FromArgb(38, 70, 83);
            btnGuardar.BorderColor = Color.Azure;
            btnGuardar.BorderRadius = 5;
            btnGuardar.BorderSize = 0;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(791, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 28);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 714);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 43);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbl_cedula);
            panel3.Controls.Add(cbReporte);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(dgvVer);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 50);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(21, 20, 21, 20);
            panel3.Size = new Size(949, 664);
            panel3.TabIndex = 2;
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cedula.Location = new Point(12, 20);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(163, 20);
            lbl_cedula.TabIndex = 36;
            lbl_cedula.Text = "Seleccionar el reporte:";
            // 
            // cbReporte
            // 
            cbReporte.FormattingEnabled = true;
            cbReporte.Location = new Point(181, 16);
            cbReporte.Name = "cbReporte";
            cbReporte.Size = new Size(604, 28);
            cbReporte.TabIndex = 35;
            cbReporte.DropDownClosed += cbReporte_DropDownClosed;
            // 
            // dgvVer
            // 
            dgvVer.AllowUserToAddRows = false;
            dgvVer.AllowUserToResizeColumns = false;
            dgvVer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvVer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVer.BackgroundColor = Color.White;
            dgvVer.BorderStyle = BorderStyle.None;
            dgvVer.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVer.ColumnHeadersHeight = 29;
            dgvVer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVer.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVer.EnableHeadersVisualStyles = false;
            dgvVer.GridColor = Color.Black;
            dgvVer.Location = new Point(12, 50);
            dgvVer.MultiSelect = false;
            dgvVer.Name = "dgvVer";
            dgvVer.ReadOnly = true;
            dgvVer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvVer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvVer.RowHeadersVisible = false;
            dgvVer.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dgvVer.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvVer.RowTemplate.Height = 29;
            dgvVer.Size = new Size(921, 557);
            dgvVer.TabIndex = 0;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(949, 757);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReportes";
            Text = "frmReportes";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvVer;
        private ButtomDesing btnGuardar;
        private ComboBox cbReporte;
        private Label lbl_cedula;
        private Label label4;
    }
}