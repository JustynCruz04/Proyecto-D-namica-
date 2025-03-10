namespace PuntoDeVenta
{
    partial class frmBuscarCombo
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
            dgvCombos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCombos).BeginInit();
            SuspendLayout();
            // 
            // dgvCombos
            // 
            dgvCombos.AllowUserToAddRows = false;
            dgvCombos.AllowUserToDeleteRows = false;
            dgvCombos.AllowUserToResizeColumns = false;
            dgvCombos.AllowUserToResizeRows = false;
            dgvCombos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCombos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCombos.CausesValidation = false;
            dgvCombos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCombos.ColumnHeadersVisible = false;
            dgvCombos.Location = new Point(12, 12);
            dgvCombos.Name = "dgvCombos";
            dgvCombos.ReadOnly = true;
            dgvCombos.RowHeadersVisible = false;
            dgvCombos.RowTemplate.Height = 25;
            dgvCombos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCombos.Size = new Size(776, 216);
            dgvCombos.TabIndex = 1;
            // 
            // frmBuscarCombo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 246);
            Controls.Add(dgvCombos);
            Name = "frmBuscarCombo";
            Text = "frmBuscarCombo";
            ((System.ComponentModel.ISupportInitialize)dgvCombos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCombos;
    }
}