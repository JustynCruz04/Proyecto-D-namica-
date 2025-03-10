namespace PuntoDeVenta
{
    partial class frmPromociones
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
            cbTipoPromocion = new ComboBox();
            dgvTipoPromocion = new DataGridView();
            label1 = new Label();
            dtpFechaInicio = new DateTimePicker();
            btnGuardarPromocion = new Button();
            btnCancelarOperacion = new Button();
            label2 = new Label();
            label3 = new Label();
            dtpFechaFin = new DateTimePicker();
            nudDescuento = new NumericUpDown();
            label5 = new Label();
            txtProducto1 = new TextBox();
            txtProducto2 = new TextBox();
            ckHabilitarCombinacion = new CheckBox();
            dgvTablaPromociones = new DataGridView();
            txtCliente = new TextBox();
            txtProducto = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            txtPrecioVenta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTipoPromocion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTablaPromociones).BeginInit();
            SuspendLayout();
            // 
            // cbTipoPromocion
            // 
            cbTipoPromocion.FormattingEnabled = true;
            cbTipoPromocion.Location = new Point(235, 41);
            cbTipoPromocion.Name = "cbTipoPromocion";
            cbTipoPromocion.Size = new Size(121, 23);
            cbTipoPromocion.TabIndex = 0;
            cbTipoPromocion.SelectedIndexChanged += cbTipoPromocion_SelectedIndexChanged;
            // 
            // dgvTipoPromocion
            // 
            dgvTipoPromocion.AllowUserToAddRows = false;
            dgvTipoPromocion.AllowUserToDeleteRows = false;
            dgvTipoPromocion.BorderStyle = BorderStyle.Fixed3D;
            dgvTipoPromocion.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTipoPromocion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoPromocion.Location = new Point(518, 41);
            dgvTipoPromocion.Name = "dgvTipoPromocion";
            dgvTipoPromocion.ReadOnly = true;
            dgvTipoPromocion.RowHeadersVisible = false;
            dgvTipoPromocion.RowTemplate.Height = 25;
            dgvTipoPromocion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipoPromocion.Size = new Size(121, 179);
            dgvTipoPromocion.TabIndex = 1;
            dgvTipoPromocion.CellContentClick += dgvTipoPromocion_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 49);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccionar Tipo de Promocion:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Enabled = false;
            dtpFechaInicio.Location = new Point(156, 70);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 23);
            dtpFechaInicio.TabIndex = 3;
            // 
            // btnGuardarPromocion
            // 
            btnGuardarPromocion.Location = new Point(721, 415);
            btnGuardarPromocion.Name = "btnGuardarPromocion";
            btnGuardarPromocion.Size = new Size(75, 23);
            btnGuardarPromocion.TabIndex = 4;
            btnGuardarPromocion.Text = "Guardar";
            btnGuardarPromocion.UseVisualStyleBackColor = true;
            btnGuardarPromocion.Click += btnGuardarPromocion_Click;
            // 
            // btnCancelarOperacion
            // 
            btnCancelarOperacion.Location = new Point(805, 415);
            btnCancelarOperacion.Name = "btnCancelarOperacion";
            btnCancelarOperacion.Size = new Size(75, 23);
            btnCancelarOperacion.TabIndex = 5;
            btnCancelarOperacion.Text = "Cancelar";
            btnCancelarOperacion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 78);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 6;
            label2.Text = "Fecha de Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 107);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha de Caducidad:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(156, 99);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 23);
            dtpFechaFin.TabIndex = 8;
            // 
            // nudDescuento
            // 
            nudDescuento.Location = new Point(148, 212);
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(120, 23);
            nudDescuento.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 214);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 12;
            label5.Text = "Descuento:";
            // 
            // txtProducto1
            // 
            txtProducto1.Location = new Point(200, 128);
            txtProducto1.Name = "txtProducto1";
            txtProducto1.Size = new Size(100, 23);
            txtProducto1.TabIndex = 14;
            // 
            // txtProducto2
            // 
            txtProducto2.Location = new Point(306, 128);
            txtProducto2.Name = "txtProducto2";
            txtProducto2.Size = new Size(100, 23);
            txtProducto2.TabIndex = 15;
            // 
            // ckHabilitarCombinacion
            // 
            ckHabilitarCombinacion.AutoSize = true;
            ckHabilitarCombinacion.Location = new Point(20, 132);
            ckHabilitarCombinacion.Name = "ckHabilitarCombinacion";
            ckHabilitarCombinacion.Size = new Size(174, 19);
            ckHabilitarCombinacion.TabIndex = 16;
            ckHabilitarCombinacion.Text = "Combinacion de Productos:";
            ckHabilitarCombinacion.UseVisualStyleBackColor = true;
            // 
            // dgvTablaPromociones
            // 
            dgvTablaPromociones.AllowUserToAddRows = false;
            dgvTablaPromociones.AllowUserToDeleteRows = false;
            dgvTablaPromociones.BorderStyle = BorderStyle.Fixed3D;
            dgvTablaPromociones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTablaPromociones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaPromociones.Location = new Point(12, 286);
            dgvTablaPromociones.Name = "dgvTablaPromociones";
            dgvTablaPromociones.ReadOnly = true;
            dgvTablaPromociones.RowHeadersVisible = false;
            dgvTablaPromociones.RowTemplate.Height = 25;
            dgvTablaPromociones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTablaPromociones.Size = new Size(861, 94);
            dgvTablaPromociones.TabIndex = 17;
            dgvTablaPromociones.CellContentClick += dgvTablaPromociones_CellContentClick;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(148, 155);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(74, 23);
            txtCliente.TabIndex = 18;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(148, 185);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(74, 23);
            txtProducto.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 159);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 20;
            label6.Text = "Nombre Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 188);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 21;
            label7.Text = "Nombre Producto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(247, 159);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 22;
            label8.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(365, 157);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 188);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 24;
            label4.Text = "Precio de Venta:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(365, 186);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 25;
            // 
            // frmPromociones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 450);
            Controls.Add(txtPrecioVenta);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtProducto);
            Controls.Add(txtCliente);
            Controls.Add(dgvTablaPromociones);
            Controls.Add(ckHabilitarCombinacion);
            Controls.Add(txtProducto2);
            Controls.Add(txtProducto1);
            Controls.Add(label5);
            Controls.Add(nudDescuento);
            Controls.Add(dtpFechaFin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancelarOperacion);
            Controls.Add(btnGuardarPromocion);
            Controls.Add(dtpFechaInicio);
            Controls.Add(label1);
            Controls.Add(dgvTipoPromocion);
            Controls.Add(cbTipoPromocion);
            Name = "frmPromociones";
            Text = "frmPromociones";
            Load += frmPromociones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTipoPromocion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTablaPromociones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTipoPromocion;
        private DataGridView dgvTipoPromocion;
        private Label label1;
        private DateTimePicker dtpFechaInicio;
        private Button btnGuardarPromocion;
        private Button btnCancelarOperacion;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaFin;
        private NumericUpDown nudDescuento;
        private Label label5;
        private TextBox txtProducto1;
        private TextBox txtProducto2;
        private CheckBox ckHabilitarCombinacion;
        private DataGridView dgvTablaPromociones;
        private TextBox txtCliente;
        private TextBox txtProducto;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDescripcion;
        private Label label4;
        private TextBox txtPrecioVenta;
    }
}