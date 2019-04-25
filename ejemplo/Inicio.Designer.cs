namespace ejemplo
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lPeso = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.nVenta = new System.Windows.Forms.Label();
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAgrePorCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgreNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgreStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAgrePrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgreCategoria = new System.Windows.Forms.TextBox();
            this.btnAgreBuscar = new System.Windows.Forms.Button();
            this.btnSacarVenta = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbCanidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lPeso
            // 
            this.lPeso.AutoSize = true;
            this.lPeso.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPeso.ForeColor = System.Drawing.Color.White;
            this.lPeso.Location = new System.Drawing.Point(897, 191);
            this.lPeso.Name = "lPeso";
            this.lPeso.Size = new System.Drawing.Size(22, 24);
            this.lPeso.TabIndex = 14;
            this.lPeso.Text = "$";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.ForeColor = System.Drawing.Color.White;
            this.lPrecio.Location = new System.Drawing.Point(942, 191);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(22, 24);
            this.lPrecio.TabIndex = 13;
            this.lPrecio.Text = "0";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.ForeColor = System.Drawing.Color.White;
            this.lTotal.Location = new System.Drawing.Point(833, 191);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(58, 24);
            this.lTotal.TabIndex = 10;
            this.lTotal.Text = "Total";
            // 
            // nVenta
            // 
            this.nVenta.AutoSize = true;
            this.nVenta.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nVenta.ForeColor = System.Drawing.Color.White;
            this.nVenta.Location = new System.Drawing.Point(30, 27);
            this.nVenta.Name = "nVenta";
            this.nVenta.Size = new System.Drawing.Size(100, 23);
            this.nVenta.TabIndex = 11;
            this.nVenta.Text = "N° Venta";
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenta.Location = new System.Drawing.Point(34, 168);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.Size = new System.Drawing.Size(781, 337);
            this.dataGridViewVenta.TabIndex = 7;
            this.dataGridViewVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVenta_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1030, 567);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtAgrePorCode
            // 
            this.txtAgrePorCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgrePorCode.Location = new System.Drawing.Point(110, 91);
            this.txtAgrePorCode.Name = "txtAgrePorCode";
            this.txtAgrePorCode.Size = new System.Drawing.Size(154, 23);
            this.txtAgrePorCode.TabIndex = 17;
            this.txtAgrePorCode.TextChanged += new System.EventHandler(this.txtAgrePorCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo";
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(709, 129);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(50, 22);
            this.btnAgregarVenta.TabIndex = 19;
            this.btnAgregarVenta.Text = "+";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre";
            // 
            // txtAgreNombre
            // 
            this.txtAgreNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgreNombre.Location = new System.Drawing.Point(110, 128);
            this.txtAgreNombre.Name = "txtAgreNombre";
            this.txtAgreNombre.ReadOnly = true;
            this.txtAgreNombre.Size = new System.Drawing.Size(154, 23);
            this.txtAgreNombre.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(562, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Stock";
            // 
            // txtAgreStock
            // 
            this.txtAgreStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgreStock.Location = new System.Drawing.Point(615, 92);
            this.txtAgreStock.Name = "txtAgreStock";
            this.txtAgreStock.ReadOnly = true;
            this.txtAgreStock.Size = new System.Drawing.Size(39, 23);
            this.txtAgreStock.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(314, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Precio";
            // 
            // txtAgrePrecio
            // 
            this.txtAgrePrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgrePrecio.Location = new System.Drawing.Point(377, 127);
            this.txtAgrePrecio.Name = "txtAgrePrecio";
            this.txtAgrePrecio.ReadOnly = true;
            this.txtAgrePrecio.Size = new System.Drawing.Size(119, 23);
            this.txtAgrePrecio.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(299, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Categoria";
            // 
            // txtAgreCategoria
            // 
            this.txtAgreCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgreCategoria.Location = new System.Drawing.Point(377, 90);
            this.txtAgreCategoria.Name = "txtAgreCategoria";
            this.txtAgreCategoria.ReadOnly = true;
            this.txtAgreCategoria.Size = new System.Drawing.Size(119, 23);
            this.txtAgreCategoria.TabIndex = 26;
            // 
            // btnAgreBuscar
            // 
            this.btnAgreBuscar.Location = new System.Drawing.Point(709, 94);
            this.btnAgreBuscar.Name = "btnAgreBuscar";
            this.btnAgreBuscar.Size = new System.Drawing.Size(106, 23);
            this.btnAgreBuscar.TabIndex = 28;
            this.btnAgreBuscar.Text = "Buscar";
            this.btnAgreBuscar.UseVisualStyleBackColor = true;
            this.btnAgreBuscar.Click += new System.EventHandler(this.btnAgreBuscar_Click);
            // 
            // btnSacarVenta
            // 
            this.btnSacarVenta.Location = new System.Drawing.Point(765, 129);
            this.btnSacarVenta.Name = "btnSacarVenta";
            this.btnSacarVenta.Size = new System.Drawing.Size(50, 22);
            this.btnSacarVenta.TabIndex = 29;
            this.btnSacarVenta.Text = "-";
            this.btnSacarVenta.UseVisualStyleBackColor = true;
            this.btnSacarVenta.Click += new System.EventHandler(this.btnSacarVenta_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(849, 482);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(219, 23);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "Finalizar Venta";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(833, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cancela con:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(833, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "Su vuelto es de:";
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.ForeColor = System.Drawing.Color.White;
            this.lblVuelto.Location = new System.Drawing.Point(988, 395);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(19, 21);
            this.lblVuelto.TabIndex = 34;
            this.lblVuelto.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(967, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "$";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(962, 253);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVenta.ForeColor = System.Drawing.Color.White;
            this.lblNumeroVenta.Location = new System.Drawing.Point(150, 27);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(21, 23);
            this.lblNumeroVenta.TabIndex = 37;
            this.lblNumeroVenta.Text = "1";
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Location = new System.Drawing.Point(888, 27);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(138, 23);
            this.btnCerrarCaja.TabIndex = 38;
            this.btnCerrarCaja.Text = "Cerrar Caja";
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(962, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 24);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar Monto";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbCanidad
            // 
            this.txbCanidad.Location = new System.Drawing.Point(615, 133);
            this.txbCanidad.Name = "txbCanidad";
            this.txbCanidad.Size = new System.Drawing.Size(39, 20);
            this.txbCanidad.TabIndex = 41;
            this.txbCanidad.TextChanged += new System.EventHandler(this.txbCanidad_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(534, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Cantidad";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1080, 603);
            this.Controls.Add(this.txbCanidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.lblNumeroVenta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblVuelto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSacarVenta);
            this.Controls.Add(this.btnAgreBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAgreCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAgrePrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAgreStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAgreNombre);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAgrePorCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lPeso);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.nVenta);
            this.Controls.Add(this.dataGridViewVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPeso;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label nVenta;
        private System.Windows.Forms.DataGridView dataGridViewVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAgrePorCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgreNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAgreStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAgrePrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAgreCategoria;
        private System.Windows.Forms.Button btnAgreBuscar;
        private System.Windows.Forms.Button btnSacarVenta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbCanidad;
        private System.Windows.Forms.Label label8;
    }
}