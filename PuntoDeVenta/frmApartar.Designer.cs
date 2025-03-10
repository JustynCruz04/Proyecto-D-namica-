namespace PuntoDeVenta
{
    partial class frmApartar
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
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAnticipo = new TextBox();
            lbMonto = new Label();
            lbProducto = new Label();
            lbCliente = new Label();
            lbRestante = new Label();
            label10 = new Label();
            lbFechaActual = new Label();
            label12 = new Label();
            label14 = new Label();
            dtFinal = new DateTimePicker();
            cbTipoPago = new ComboBox();
            label13 = new Label();
            label15 = new Label();
            lbTotal = new Label();
            label17 = new Label();
            label19 = new Label();
            label20 = new Label();
            cbCaja = new ComboBox();
            btnCancelar = new Button();
            txtTAG = new TextBox();
            lbSemanal = new Label();
            label7 = new Label();
            lbCuotas = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(38, 70, 83);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(11, 505);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 29);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(376, 51);
            label1.TabIndex = 2;
            label1.Text = "Producto a apartar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 88);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 10);
            label2.Size = new Size(61, 30);
            label2.TabIndex = 3;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 118);
            label3.Margin = new Padding(3, 0, 3, 10);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 148);
            label4.Margin = new Padding(3, 0, 3, 10);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 5;
            label4.Text = "Monto total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 178);
            label5.Margin = new Padding(3, 0, 3, 10);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 6;
            label5.Text = "Anticipo a abonar:";
            // 
            // txtAnticipo
            // 
            txtAnticipo.Location = new Point(155, 171);
            txtAnticipo.Name = "txtAnticipo";
            txtAnticipo.Size = new Size(232, 27);
            txtAnticipo.TabIndex = 7;
            txtAnticipo.TextChanged += txtAnticipo_TextChanged;
            txtAnticipo.KeyPress += txtAnticipo_KeyPress;
            // 
            // lbMonto
            // 
            lbMonto.AutoSize = true;
            lbMonto.Location = new Point(109, 148);
            lbMonto.Margin = new Padding(3, 0, 3, 10);
            lbMonto.Name = "lbMonto";
            lbMonto.Size = new Size(91, 20);
            lbMonto.TabIndex = 8;
            lbMonto.Text = "Monto total:";
            // 
            // lbProducto
            // 
            lbProducto.Location = new Point(94, 118);
            lbProducto.Margin = new Padding(3, 0, 3, 10);
            lbProducto.Name = "lbProducto";
            lbProducto.Size = new Size(293, 20);
            lbProducto.TabIndex = 9;
            lbProducto.Text = "Monto total:";
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Location = new Point(78, 88);
            lbCliente.Margin = new Padding(3, 0, 3, 10);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(91, 20);
            lbCliente.TabIndex = 10;
            lbCliente.Text = "Monto total:";
            // 
            // lbRestante
            // 
            lbRestante.AutoSize = true;
            lbRestante.Location = new Point(150, 208);
            lbRestante.Margin = new Padding(3, 0, 3, 10);
            lbRestante.Name = "lbRestante";
            lbRestante.Size = new Size(91, 20);
            lbRestante.TabIndex = 12;
            lbRestante.Text = "Monto total:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 208);
            label10.Margin = new Padding(3, 0, 3, 10);
            label10.Name = "label10";
            label10.Size = new Size(132, 20);
            label10.TabIndex = 11;
            label10.Text = "Restante a pagar:";
            // 
            // lbFechaActual
            // 
            lbFechaActual.AutoSize = true;
            lbFechaActual.Location = new Point(117, 238);
            lbFechaActual.Margin = new Padding(3, 0, 3, 10);
            lbFechaActual.Name = "lbFechaActual";
            lbFechaActual.Size = new Size(91, 20);
            lbFechaActual.TabIndex = 14;
            lbFechaActual.Text = "Monto total:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(12, 238);
            label12.Margin = new Padding(3, 0, 3, 10);
            label12.Name = "label12";
            label12.Size = new Size(99, 20);
            label12.TabIndex = 13;
            label12.Text = "Fecha actual:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(12, 268);
            label14.Margin = new Padding(3, 0, 3, 10);
            label14.Name = "label14";
            label14.Size = new Size(143, 20);
            label14.TabIndex = 15;
            label14.Text = "Fecha vencimiento:";
            // 
            // dtFinal
            // 
            dtFinal.CustomFormat = "dd/MM/yyyy";
            dtFinal.Location = new Point(161, 261);
            dtFinal.Name = "dtFinal";
            dtFinal.Size = new Size(226, 27);
            dtFinal.TabIndex = 16;
            dtFinal.Value = new DateTime(2024, 9, 8, 0, 0, 0, 0);
            dtFinal.ValueChanged += dtFinal_ValueChanged;
            // 
            // cbTipoPago
            // 
            cbTipoPago.FormattingEnabled = true;
            cbTipoPago.Items.AddRange(new object[] { "Efectivo", "Credito", "Transferencia", "Deposito" });
            cbTipoPago.Location = new Point(122, 294);
            cbTipoPago.Name = "cbTipoPago";
            cbTipoPago.Size = new Size(151, 28);
            cbTipoPago.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(12, 302);
            label13.Margin = new Padding(3, 0, 3, 10);
            label13.Name = "label13";
            label13.Size = new Size(104, 20);
            label13.TabIndex = 18;
            label13.Text = "Tipo de pago:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(12, 335);
            label15.Margin = new Padding(3, 0, 3, 10);
            label15.Name = "label15";
            label15.Size = new Size(61, 20);
            label15.TabIndex = 19;
            label15.Text = "Cuotas:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(123, 365);
            lbTotal.Margin = new Padding(3, 0, 3, 10);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(91, 20);
            lbTotal.TabIndex = 22;
            lbTotal.Text = "Monto total:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(12, 365);
            label17.Margin = new Padding(3, 0, 3, 10);
            label17.Name = "label17";
            label17.Size = new Size(105, 20);
            label17.TabIndex = 21;
            label17.Text = "Total a pagar:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(12, 395);
            label19.Margin = new Padding(3, 0, 3, 10);
            label19.Name = "label19";
            label19.Size = new Size(43, 20);
            label19.TabIndex = 23;
            label19.Text = "TAG:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(11, 429);
            label20.Margin = new Padding(3, 0, 3, 10);
            label20.Name = "label20";
            label20.Size = new Size(58, 20);
            label20.TabIndex = 26;
            label20.Text = "CajaID:";
            // 
            // cbCaja
            // 
            cbCaja.FormattingEnabled = true;
            cbCaja.Location = new Point(75, 421);
            cbCaja.Name = "cbCaja";
            cbCaja.Size = new Size(151, 28);
            cbCaja.TabIndex = 25;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(100, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(213, 505);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(174, 29);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTAG
            // 
            txtTAG.Location = new Point(61, 388);
            txtTAG.Name = "txtTAG";
            txtTAG.Size = new Size(232, 27);
            txtTAG.TabIndex = 28;
            // 
            // lbSemanal
            // 
            lbSemanal.AutoSize = true;
            lbSemanal.Location = new Point(90, 459);
            lbSemanal.Margin = new Padding(3, 0, 3, 10);
            lbSemanal.Name = "lbSemanal";
            lbSemanal.Size = new Size(91, 20);
            lbSemanal.TabIndex = 30;
            lbSemanal.Text = "Monto total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 459);
            label7.Margin = new Padding(3, 0, 3, 10);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 29;
            label7.Text = "Semanal:";
            // 
            // lbCuotas
            // 
            lbCuotas.AutoSize = true;
            lbCuotas.Location = new Point(79, 335);
            lbCuotas.Margin = new Padding(3, 0, 3, 10);
            lbCuotas.Name = "lbCuotas";
            lbCuotas.Size = new Size(91, 20);
            lbCuotas.TabIndex = 31;
            lbCuotas.Text = "Monto total:";
            // 
            // frmApartar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(400, 550);
            Controls.Add(lbCuotas);
            Controls.Add(lbSemanal);
            Controls.Add(label7);
            Controls.Add(txtTAG);
            Controls.Add(btnCancelar);
            Controls.Add(label20);
            Controls.Add(cbCaja);
            Controls.Add(label19);
            Controls.Add(lbTotal);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(cbTipoPago);
            Controls.Add(dtFinal);
            Controls.Add(label14);
            Controls.Add(lbFechaActual);
            Controls.Add(label12);
            Controls.Add(lbRestante);
            Controls.Add(label10);
            Controls.Add(lbCliente);
            Controls.Add(lbProducto);
            Controls.Add(lbMonto);
            Controls.Add(txtAnticipo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmApartar";
            Text = "frmApartar";
            Paint += frmApartar_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAnticipo;
        private Label lbMonto;
        private Label lbProducto;
        private Label lbCliente;
        private Label lbRestante;
        private Label label10;
        private Label lbFechaActual;
        private Label label12;
        private Label label14;
        private DateTimePicker dtFinal;
        private ComboBox cbTipoPago;
        private Label label13;
        private Label label15;
        private Label lbTotal;
        private Label label17;
        private Label label19;
        private Label label20;
        private ComboBox cbCaja;
        private Button btnCancelar;
        private TextBox txtTAG;
        private Label lbSemanal;
        private Label label7;
        private Label lbCuotas;
    }
}