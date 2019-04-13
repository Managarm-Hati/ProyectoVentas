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
            this.tbVenta = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lPeso
            // 
            this.lPeso.AutoSize = true;
            this.lPeso.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPeso.ForeColor = System.Drawing.Color.White;
            this.lPeso.Location = new System.Drawing.Point(942, 253);
            this.lPeso.Name = "lPeso";
            this.lPeso.Size = new System.Drawing.Size(21, 23);
            this.lPeso.TabIndex = 14;
            this.lPeso.Text = "$";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.ForeColor = System.Drawing.Color.White;
            this.lPrecio.Location = new System.Drawing.Point(977, 253);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(21, 23);
            this.lPrecio.TabIndex = 13;
            this.lPrecio.Text = "0";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.ForeColor = System.Drawing.Color.White;
            this.lTotal.Location = new System.Drawing.Point(856, 253);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(57, 23);
            this.lTotal.TabIndex = 10;
            this.lTotal.Text = "Total";
            // 
            // tbVenta
            // 
            this.tbVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVenta.Location = new System.Drawing.Point(136, 27);
            this.tbVenta.Name = "tbVenta";
            this.tbVenta.ReadOnly = true;
            this.tbVenta.Size = new System.Drawing.Size(58, 27);
            this.tbVenta.TabIndex = 12;
            this.tbVenta.Text = "0";
            this.tbVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtAgrePorCode.Location = new System.Drawing.Point(97, 91);
            this.txtAgrePorCode.Name = "txtAgrePorCode";
            this.txtAgrePorCode.Size = new System.Drawing.Size(154, 23);
            this.txtAgrePorCode.TabIndex = 17;
            this.txtAgrePorCode.TextChanged += new System.EventHandler(this.txtAgrePorCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo";
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(685, 121);
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
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre";
            // 
            // txtAgreNombre
            // 
            this.txtAgreNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgreNombre.Location = new System.Drawing.Point(97, 128);
            this.txtAgreNombre.Name = "txtAgreNombre";
            this.txtAgreNombre.ReadOnly = true;
            this.txtAgreNombre.Size = new System.Drawing.Size(154, 23);
            this.txtAgreNombre.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(487, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Stock";
            // 
            // txtAgreStock
            // 
            this.txtAgreStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgreStock.Location = new System.Drawing.Point(528, 123);
            this.txtAgreStock.Name = "txtAgreStock";
            this.txtAgreStock.Size = new System.Drawing.Size(39, 23);
            this.txtAgreStock.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(285, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Precio";
            // 
            // txtAgrePrecio
            // 
            this.txtAgrePrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgrePrecio.Location = new System.Drawing.Point(342, 127);
            this.txtAgrePrecio.Name = "txtAgrePrecio";
            this.txtAgrePrecio.ReadOnly = true;
            this.txtAgrePrecio.Size = new System.Drawing.Size(119, 23);
            this.txtAgrePrecio.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(270, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Categoria";
            // 
            // txtAgreCategoria
            // 
            this.txtAgreCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgreCategoria.Location = new System.Drawing.Point(342, 90);
            this.txtAgreCategoria.Name = "txtAgreCategoria";
            this.txtAgreCategoria.ReadOnly = true;
            this.txtAgreCategoria.Size = new System.Drawing.Size(119, 23);
            this.txtAgreCategoria.TabIndex = 26;
            // 
            // btnAgreBuscar
            // 
            this.btnAgreBuscar.Location = new System.Drawing.Point(592, 120);
            this.btnAgreBuscar.Name = "btnAgreBuscar";
            this.btnAgreBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnAgreBuscar.TabIndex = 28;
            this.btnAgreBuscar.Text = "Buscar";
            this.btnAgreBuscar.UseVisualStyleBackColor = true;
            this.btnAgreBuscar.Click += new System.EventHandler(this.btnAgreBuscar_Click);
            // 
            // btnSacarVenta
            // 
            this.btnSacarVenta.Location = new System.Drawing.Point(741, 121);
            this.btnSacarVenta.Name = "btnSacarVenta";
            this.btnSacarVenta.Size = new System.Drawing.Size(50, 22);
            this.btnSacarVenta.TabIndex = 29;
            this.btnSacarVenta.Text = "-";
            this.btnSacarVenta.UseVisualStyleBackColor = true;
            this.btnSacarVenta.Click += new System.EventHandler(this.btnSacarVenta_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(710, 523);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 23);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "Finalizar Venta";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1080, 603);
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
            this.Controls.Add(this.tbVenta);
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
        private System.Windows.Forms.TextBox tbVenta;
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
    }
}