namespace PuntoDeVenta
{
    partial class frmVender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVender));
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            btnApartar = new ButtomDesing();
            btnVender = new ButtomDesing();
            panel3 = new Panel();
            groupBox5 = new GroupBox();
            dgvDetalledeventas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            CodigoBarra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Existencia = new DataGridViewTextBoxColumn();
            IVA = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            checkBox2 = new CheckBox();
            btnCancelar = new Button();
            btnQuitar = new Button();
            txtTotal = new TextBox();
            label13 = new Label();
            txtSubtotal = new TextBox();
            label11 = new Label();
            A = new GroupBox();
            btnAgregarProducto = new Button();
            btnBuscarProducto = new Button();
            txtStock = new TextBox();
            label10 = new Label();
            txtDescripcionProducto = new TextBox();
            label9 = new Label();
            txtPrecioUnitario = new TextBox();
            txtCantidadProducto = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            btnBuscarClientes = new Button();
            txtNombreVentas = new TextBox();
            txtIdentificacionVentas = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnApartado = new Panel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalledeventas).BeginInit();
            groupBox4.SuspendLayout();
            A.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 38);
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
            label4.Padding = new Padding(18, 0, 0, 0);
            label4.Size = new Size(830, 38);
            label4.TabIndex = 4;
            label4.Text = "Vender";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnApartar);
            panel2.Controls.Add(btnVender);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 516);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 52);
            panel2.TabIndex = 1;
            // 
            // btnApartar
            // 
            btnApartar.BackColor = Color.FromArgb(38, 70, 83);
            btnApartar.BackgroundColor = Color.FromArgb(38, 70, 83);
            btnApartar.BorderColor = Color.PaleVioletRed;
            btnApartar.BorderRadius = 20;
            btnApartar.BorderSize = 0;
            btnApartar.FlatAppearance.BorderSize = 0;
            btnApartar.FlatStyle = FlatStyle.Flat;
            btnApartar.ForeColor = Color.White;
            btnApartar.Location = new Point(554, 6);
            btnApartar.Margin = new Padding(3, 2, 3, 2);
            btnApartar.Name = "btnApartar";
            btnApartar.Size = new Size(126, 38);
            btnApartar.TabIndex = 3;
            btnApartar.Text = "Apartar";
            btnApartar.TextColor = Color.White;
            btnApartar.UseVisualStyleBackColor = false;
            btnApartar.Click += btnApartar_Click;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(38, 70, 83);
            btnVender.BackgroundColor = Color.FromArgb(38, 70, 83);
            btnVender.BorderColor = Color.PaleVioletRed;
            btnVender.BorderRadius = 20;
            btnVender.BorderSize = 0;
            btnVender.FlatAppearance.BorderSize = 0;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.ForeColor = Color.White;
            btnVender.Location = new Point(685, 6);
            btnVender.Margin = new Padding(3, 2, 3, 2);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(126, 38);
            btnVender.TabIndex = 2;
            btnVender.Text = "Vender";
            btnVender.TextColor = Color.White;
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox5);
            panel3.Controls.Add(groupBox4);
            panel3.Controls.Add(A);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 38);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(18, 15, 18, 15);
            panel3.Size = new Size(830, 478);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint_1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvDetalledeventas);
            groupBox5.Location = new Point(21, 208);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(606, 238);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Detalle de ventas";
            // 
            // dgvDetalledeventas
            // 
            dgvDetalledeventas.AllowUserToAddRows = false;
            dgvDetalledeventas.AllowUserToDeleteRows = false;
            dgvDetalledeventas.AllowUserToResizeColumns = false;
            dgvDetalledeventas.AllowUserToResizeRows = false;
            dgvDetalledeventas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalledeventas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetalledeventas.CausesValidation = false;
            dgvDetalledeventas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDetalledeventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalledeventas.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, CodigoBarra, PrecioVenta, Cantidad, Existencia, IVA });
            dgvDetalledeventas.Location = new Point(6, 26);
            dgvDetalledeventas.MultiSelect = false;
            dgvDetalledeventas.Name = "dgvDetalledeventas";
            dgvDetalledeventas.RowHeadersVisible = false;
            dgvDetalledeventas.RowHeadersWidth = 51;
            dgvDetalledeventas.RowTemplate.Height = 25;
            dgvDetalledeventas.Size = new Size(594, 192);
            dgvDetalledeventas.TabIndex = 0;
            dgvDetalledeventas.CellClick += dgvDetalledeventas_CellClick;
            dgvDetalledeventas.CellDoubleClick += dgvDetalledeventas_CellDoubleClick;
            dgvDetalledeventas.SelectionChanged += dgvDetalledeventas_SelectionChanged;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // CodigoBarra
            // 
            CodigoBarra.HeaderText = "CodigoBarra";
            CodigoBarra.MinimumWidth = 6;
            CodigoBarra.Name = "CodigoBarra";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PrecioVenta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // Existencia
            // 
            Existencia.HeaderText = "Existencia";
            Existencia.MinimumWidth = 6;
            Existencia.Name = "Existencia";
            // 
            // IVA
            // 
            IVA.HeaderText = "IVA";
            IVA.MinimumWidth = 6;
            IVA.Name = "IVA";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(btnCancelar);
            groupBox4.Controls.Add(btnQuitar);
            groupBox4.Controls.Add(txtTotal);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txtSubtotal);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(633, 208);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(185, 238);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Paga";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(14, 26);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(126, 19);
            checkBox2.TabIndex = 23;
            checkBox2.Text = "Agregar descuento";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Visible = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(98, 182);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 36);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(14, 182);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(78, 36);
            btnQuitar.TabIndex = 27;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(81, 153);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(95, 23);
            txtTotal.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(40, 156);
            label13.Name = "label13";
            label13.Size = new Size(35, 15);
            label13.TabIndex = 25;
            label13.Text = "Total:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(81, 124);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(95, 23);
            txtSubtotal.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 127);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 21;
            label11.Text = "Subtotal:";
            // 
            // A
            // 
            A.Controls.Add(btnAgregarProducto);
            A.Controls.Add(btnBuscarProducto);
            A.Controls.Add(txtStock);
            A.Controls.Add(label10);
            A.Controls.Add(txtDescripcionProducto);
            A.Controls.Add(label9);
            A.Controls.Add(txtPrecioUnitario);
            A.Controls.Add(txtCantidadProducto);
            A.Controls.Add(label7);
            A.Controls.Add(label6);
            A.Location = new Point(490, 45);
            A.Name = "A";
            A.Size = new Size(328, 157);
            A.TabIndex = 22;
            A.TabStop = false;
            A.Text = "Datos de producto";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.Transparent;
            btnAgregarProducto.Location = new Point(224, 112);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(79, 39);
            btnAgregarProducto.TabIndex = 23;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.Transparent;
            btnBuscarProducto.BackgroundImage = (Image)resources.GetObject("btnBuscarProducto.BackgroundImage");
            btnBuscarProducto.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscarProducto.Location = new Point(267, 54);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(36, 34);
            btnBuscarProducto.TabIndex = 23;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(86, 80);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(95, 23);
            txtStock.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 83);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 19;
            label10.Text = "Stock:";
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.Location = new Point(86, 22);
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(217, 23);
            txtDescripcionProducto.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 112);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 25;
            label9.Text = "Cantidad:";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(86, 51);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(95, 23);
            txtPrecioUnitario.TabIndex = 12;
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Location = new Point(86, 109);
            txtCantidadProducto.MaxLength = 10;
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(95, 23);
            txtCantidadProducto.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 25);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 9;
            label7.Text = "Descripcion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 54);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 11;
            label6.Text = "Precio Uni:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(btnBuscarClientes);
            groupBox1.Controls.Add(txtNombreVentas);
            groupBox1.Controls.Add(txtIdentificacionVentas);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(21, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 157);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(17, 132);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 19);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Consumidor final";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnBuscarClientes
            // 
            btnBuscarClientes.BackColor = Color.Transparent;
            btnBuscarClientes.Location = new Point(311, 22);
            btnBuscarClientes.Name = "btnBuscarClientes";
            btnBuscarClientes.Size = new Size(59, 23);
            btnBuscarClientes.TabIndex = 21;
            btnBuscarClientes.Text = "Buscar";
            btnBuscarClientes.UseVisualStyleBackColor = false;
            btnBuscarClientes.Click += btnBuscarClientes_Click;
            // 
            // txtNombreVentas
            // 
            txtNombreVentas.Location = new Point(66, 22);
            txtNombreVentas.Name = "txtNombreVentas";
            txtNombreVentas.Size = new Size(239, 23);
            txtNombreVentas.TabIndex = 6;
            txtNombreVentas.TextChanged += txtNombreVentas_TextChanged;
            // 
            // txtIdentificacionVentas
            // 
            txtIdentificacionVentas.Location = new Point(66, 51);
            txtIdentificacionVentas.Name = "txtIdentificacionVentas";
            txtIdentificacionVentas.Size = new Size(239, 23);
            txtIdentificacionVentas.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 54);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 7;
            label5.Text = "Identif:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 15);
            label2.Name = "label2";
            label2.Size = new Size(164, 21);
            label2.TabIndex = 11;
            label2.Text = "Informacion de ventas";
            // 
            // pnApartado
            // 
            pnApartado.BackColor = Color.White;
            pnApartado.Location = new Point(220, 37);
            pnApartado.Margin = new Padding(3, 2, 3, 2);
            pnApartado.Name = "pnApartado";
            pnApartado.Size = new Size(315, 51);
            pnApartado.TabIndex = 23;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // frmVender
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(830, 568);
            Controls.Add(pnApartado);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmVender";
            Text = "frmProductos";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalledeventas).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            A.ResumeLayout(false);
            A.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private ButtomDesing btnVender;
        private Panel panel3;
        private GroupBox groupBox4;
        private Button btnCancelar;
        private Button btnQuitar;
        public TextBox txtTotal;
        private Label label13;
        private TextBox txtSubtotal;
        private Label label11;
        private GroupBox A;
        private Label label10;
        private TextBox txtDescripcionProducto;
        private TextBox txtPrecioUnitario;
        private Label label7;
        private Label label6;
        private Label label9;
        private TextBox txtCantidadProducto;
        private GroupBox groupBox1;
        private Button btnBuscarClientes;
        private TextBox txtNombreVentas;
        private TextBox txtIdentificacionVentas;
        private Label label5;
        private Label label3;
        private Label label2;
        private GroupBox groupBox5;
        private TextBox txtStock;
        private Button btnBuscarProducto;
        private CheckBox checkBox1;
        public DataGridView dgvDetalledeventas;
        private Button btnAgregarProducto;
        private ButtomDesing btnApartar;
        private Panel pnApartado;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn CodigoBarra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Existencia;
        private DataGridViewTextBoxColumn IVA;
        private CheckBox checkBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}