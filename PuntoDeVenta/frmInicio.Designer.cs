using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    partial class frmInicio
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            dgvventasMensuales = new DataGridView();
            dgvProductoMensual = new DataGridView();
            dgvPagosemanal = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvventasMensuales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductoMensual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagosemanal).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 52);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(18, 0, 0, 0);
            label4.Size = new Size(830, 52);
            label4.TabIndex = 3;
            label4.Text = "Inicio";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 52);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(18, 15, 18, 15);
            panel3.Size = new Size(830, 516);
            panel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgvPagosemanal);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(20, 209);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(789, 290);
            panel6.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 0;
            label1.Text = "Pago Semanales";
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvProductoMensual);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(420, 17);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(389, 188);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 8);
            label3.Name = "label3";
            label3.Size = new Size(181, 21);
            label3.TabIndex = 3;
            label3.Text = "Top Producto Mensual";
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvventasMensuales);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(20, 17);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(389, 188);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 8);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 2;
            label2.Text = "Ventas mensuales";
            // 
            // dgvventasMensuales
            // 
            dgvventasMensuales.AllowUserToAddRows = false;
            dgvventasMensuales.AllowUserToResizeColumns = false;
            dgvventasMensuales.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dgvventasMensuales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvventasMensuales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvventasMensuales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvventasMensuales.BackgroundColor = Color.White;
            dgvventasMensuales.BorderStyle = BorderStyle.None;
            dgvventasMensuales.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvventasMensuales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvventasMensuales.ColumnHeadersHeight = 29;
            dgvventasMensuales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvventasMensuales.Cursor = Cursors.Hand;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvventasMensuales.DefaultCellStyle = dataGridViewCellStyle13;
            dgvventasMensuales.EnableHeadersVisualStyles = false;
            dgvventasMensuales.GridColor = Color.Black;
            dgvventasMensuales.Location = new Point(9, 31);
            dgvventasMensuales.Margin = new Padding(3, 2, 3, 2);
            dgvventasMensuales.MultiSelect = false;
            dgvventasMensuales.Name = "dgvventasMensuales";
            dgvventasMensuales.ReadOnly = true;
            dgvventasMensuales.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvventasMensuales.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvventasMensuales.RowHeadersVisible = false;
            dgvventasMensuales.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgvventasMensuales.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgvventasMensuales.RowTemplate.Height = 29;
            dgvventasMensuales.Size = new Size(368, 144);
            dgvventasMensuales.TabIndex = 4;
            // 
            // dgvProductoMensual
            // 
            dgvProductoMensual.AllowUserToAddRows = false;
            dgvProductoMensual.AllowUserToResizeColumns = false;
            dgvProductoMensual.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dgvProductoMensual.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvProductoMensual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductoMensual.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductoMensual.BackgroundColor = Color.White;
            dgvProductoMensual.BorderStyle = BorderStyle.None;
            dgvProductoMensual.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvProductoMensual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvProductoMensual.ColumnHeadersHeight = 29;
            dgvProductoMensual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductoMensual.Cursor = Cursors.Hand;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvProductoMensual.DefaultCellStyle = dataGridViewCellStyle8;
            dgvProductoMensual.EnableHeadersVisualStyles = false;
            dgvProductoMensual.GridColor = Color.Black;
            dgvProductoMensual.Location = new Point(9, 31);
            dgvProductoMensual.Margin = new Padding(3, 2, 3, 2);
            dgvProductoMensual.MultiSelect = false;
            dgvProductoMensual.Name = "dgvProductoMensual";
            dgvProductoMensual.ReadOnly = true;
            dgvProductoMensual.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvProductoMensual.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvProductoMensual.RowHeadersVisible = false;
            dgvProductoMensual.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvProductoMensual.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvProductoMensual.RowTemplate.Height = 29;
            dgvProductoMensual.Size = new Size(368, 144);
            dgvProductoMensual.TabIndex = 5;
            // 
            // dgvPagosemanal
            // 
            dgvPagosemanal.AllowUserToAddRows = false;
            dgvPagosemanal.AllowUserToResizeColumns = false;
            dgvPagosemanal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvPagosemanal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPagosemanal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagosemanal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPagosemanal.BackgroundColor = Color.White;
            dgvPagosemanal.BorderStyle = BorderStyle.None;
            dgvPagosemanal.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPagosemanal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPagosemanal.ColumnHeadersHeight = 29;
            dgvPagosemanal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPagosemanal.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPagosemanal.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPagosemanal.EnableHeadersVisualStyles = false;
            dgvPagosemanal.GridColor = Color.Black;
            dgvPagosemanal.Location = new Point(9, 31);
            dgvPagosemanal.Margin = new Padding(3, 2, 3, 2);
            dgvPagosemanal.MultiSelect = false;
            dgvPagosemanal.Name = "dgvPagosemanal";
            dgvPagosemanal.ReadOnly = true;
            dgvPagosemanal.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 183, 221);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPagosemanal.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPagosemanal.RowHeadersVisible = false;
            dgvPagosemanal.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPagosemanal.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvPagosemanal.RowTemplate.Height = 29;
            dgvPagosemanal.Size = new Size(768, 246);
            dgvPagosemanal.TabIndex = 5;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(830, 568);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmInicio";
            Text = "frmProductos";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvventasMensuales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductoMensual).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagosemanal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private DataGridView dgvPagosemanal;
        private DataGridView dgvProductoMensual;
        private DataGridView dgvventasMensuales;
    }
}