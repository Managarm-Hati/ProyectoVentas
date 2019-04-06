namespace ejemplo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabC = new System.Windows.Forms.TabControl();
            this.tabVenta = new System.Windows.Forms.TabPage();
            this.lPeso = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.tbVenta = new System.Windows.Forms.TextBox();
            this.nVenta = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Fecha = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbRegistrar = new System.Windows.Forms.TabPage();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lCategoria = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lStock = new System.Windows.Forms.Label();
            this.lPrecioC = new System.Windows.Forms.Label();
            this.lNombredelArticulo = new System.Windows.Forms.Label();
            this.lCodigo = new System.Windows.Forms.Label();
            this.tabVer = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnListarNombre = new System.Windows.Forms.Button();
            this.btnListarTodo = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lVenta = new System.Windows.Forms.Label();
            this.cbxListarCategoria = new System.Windows.Forms.ComboBox();
            this.btnGuardarPDF = new System.Windows.Forms.Button();
            this.tabC.SuspendLayout();
            this.tabVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbRegistrar.SuspendLayout();
            this.tabVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabC
            // 
            this.tabC.Controls.Add(this.tabVenta);
            this.tabC.Controls.Add(this.tbRegistrar);
            this.tabC.Controls.Add(this.tabVer);
            this.tabC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabC.ItemSize = new System.Drawing.Size(80, 33);
            this.tabC.Location = new System.Drawing.Point(12, 58);
            this.tabC.Name = "tabC";
            this.tabC.SelectedIndex = 0;
            this.tabC.Size = new System.Drawing.Size(1005, 544);
            this.tabC.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabC.TabIndex = 1;
            // 
            // tabVenta
            // 
            this.tabVenta.Controls.Add(this.lPeso);
            this.tabVenta.Controls.Add(this.lPrecio);
            this.tabVenta.Controls.Add(this.lTotal);
            this.tabVenta.Controls.Add(this.tbVenta);
            this.tabVenta.Controls.Add(this.nVenta);
            this.tabVenta.Controls.Add(this.dateTimePicker1);
            this.tabVenta.Controls.Add(this.Fecha);
            this.tabVenta.Controls.Add(this.dataGridView1);
            this.tabVenta.Location = new System.Drawing.Point(4, 37);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenta.Size = new System.Drawing.Size(997, 503);
            this.tabVenta.TabIndex = 0;
            this.tabVenta.Text = "Venta";
            this.tabVenta.UseVisualStyleBackColor = true;
            // 
            // lPeso
            // 
            this.lPeso.AutoSize = true;
            this.lPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPeso.Location = new System.Drawing.Point(927, 469);
            this.lPeso.Name = "lPeso";
            this.lPeso.Size = new System.Drawing.Size(29, 31);
            this.lPeso.TabIndex = 6;
            this.lPeso.Text = "$";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(962, 469);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(29, 31);
            this.lPrecio.TabIndex = 5;
            this.lPrecio.Text = "0";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.Location = new System.Drawing.Point(833, 469);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(75, 31);
            this.lTotal.TabIndex = 3;
            this.lTotal.Text = "Total";
            // 
            // tbVenta
            // 
            this.tbVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVenta.Location = new System.Drawing.Point(98, 66);
            this.tbVenta.Name = "tbVenta";
            this.tbVenta.ReadOnly = true;
            this.tbVenta.Size = new System.Drawing.Size(58, 27);
            this.tbVenta.TabIndex = 4;
            this.tbVenta.Text = "0";
            this.tbVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nVenta
            // 
            this.nVenta.AutoSize = true;
            this.nVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nVenta.Location = new System.Drawing.Point(10, 66);
            this.nVenta.Name = "nVenta";
            this.nVenta.Size = new System.Drawing.Size(82, 22);
            this.nVenta.TabIndex = 3;
            this.nVenta.Text = "N° Venta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(346, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(7, 29);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(60, 22);
            this.Fecha.TabIndex = 1;
            this.Fecha.Text = "Fecha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(985, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbRegistrar
            // 
            this.tbRegistrar.Controls.Add(this.txtCategoria);
            this.tbRegistrar.Controls.Add(this.lCategoria);
            this.tbRegistrar.Controls.Add(this.btnActualizar);
            this.tbRegistrar.Controls.Add(this.btnEliminar);
            this.tbRegistrar.Controls.Add(this.btnRegistrar);
            this.tbRegistrar.Controls.Add(this.txtPrecio);
            this.tbRegistrar.Controls.Add(this.txtStock);
            this.tbRegistrar.Controls.Add(this.txtNombreArticulo);
            this.tbRegistrar.Controls.Add(this.txtCodigo);
            this.tbRegistrar.Controls.Add(this.lStock);
            this.tbRegistrar.Controls.Add(this.lPrecioC);
            this.tbRegistrar.Controls.Add(this.lNombredelArticulo);
            this.tbRegistrar.Controls.Add(this.lCodigo);
            this.tbRegistrar.Location = new System.Drawing.Point(4, 37);
            this.tbRegistrar.Name = "tbRegistrar";
            this.tbRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegistrar.Size = new System.Drawing.Size(997, 503);
            this.tbRegistrar.TabIndex = 1;
            this.tbRegistrar.Text = "Registrar";
            this.tbRegistrar.UseVisualStyleBackColor = true;
            this.tbRegistrar.Click += new System.EventHandler(this.tbRegistrar_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(232, 186);
            this.txtCategoria.MaxLength = 30;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(219, 27);
            this.txtCategoria.TabIndex = 7;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCategoria.Location = new System.Drawing.Point(10, 182);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(97, 25);
            this.lCategoria.TabIndex = 13;
            this.lCategoria.Text = "Categoria";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(420, 431);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(114, 34);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(610, 431);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 34);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(226, 431);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(126, 35);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(232, 317);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(173, 27);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Validated += new System.EventHandler(this.txtPrecio_Validated);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(232, 251);
            this.txtStock.MaxLength = 3;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(41, 27);
            this.txtStock.TabIndex = 8;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreArticulo.Location = new System.Drawing.Point(232, 112);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(383, 27);
            this.txtNombreArticulo.TabIndex = 6;
            this.txtNombreArticulo.TextChanged += new System.EventHandler(this.txtNombreArticulo_TextChanged);
            this.txtNombreArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreArticulo_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(232, 35);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 27);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lStock
            // 
            this.lStock.AutoSize = true;
            this.lStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStock.Location = new System.Drawing.Point(10, 251);
            this.lStock.Name = "lStock";
            this.lStock.Size = new System.Drawing.Size(62, 25);
            this.lStock.TabIndex = 3;
            this.lStock.Text = "Stock";
            // 
            // lPrecioC
            // 
            this.lPrecioC.AutoSize = true;
            this.lPrecioC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecioC.Location = new System.Drawing.Point(10, 317);
            this.lPrecioC.Name = "lPrecioC";
            this.lPrecioC.Size = new System.Drawing.Size(164, 25);
            this.lPrecioC.TabIndex = 2;
            this.lPrecioC.Text = "Precio de compra";
            // 
            // lNombredelArticulo
            // 
            this.lNombredelArticulo.AutoSize = true;
            this.lNombredelArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombredelArticulo.Location = new System.Drawing.Point(10, 112);
            this.lNombredelArticulo.Name = "lNombredelArticulo";
            this.lNombredelArticulo.Size = new System.Drawing.Size(182, 25);
            this.lNombredelArticulo.TabIndex = 1;
            this.lNombredelArticulo.Text = "Nombre del Articulo";
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCodigo.Location = new System.Drawing.Point(10, 35);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(75, 25);
            this.lCodigo.TabIndex = 0;
            this.lCodigo.Text = "Codigo";
            // 
            // tabVer
            // 
            this.tabVer.Controls.Add(this.btnGuardarPDF);
            this.tabVer.Controls.Add(this.cbxListarCategoria);
            this.tabVer.Controls.Add(this.btnGuardar);
            this.tabVer.Controls.Add(this.btnListarNombre);
            this.tabVer.Controls.Add(this.btnListarTodo);
            this.tabVer.Controls.Add(this.dataGridView2);
            this.tabVer.Location = new System.Drawing.Point(4, 37);
            this.tabVer.Name = "tabVer";
            this.tabVer.Padding = new System.Windows.Forms.Padding(3);
            this.tabVer.Size = new System.Drawing.Size(997, 503);
            this.tabVer.TabIndex = 2;
            this.tabVer.Text = "Ver ";
            this.tabVer.UseVisualStyleBackColor = true;
            this.tabVer.Click += new System.EventHandler(this.tabVer_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(684, 418);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 40);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guarda Excel";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnListarNombre
            // 
            this.btnListarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarNombre.Location = new System.Drawing.Point(155, 424);
            this.btnListarNombre.Name = "btnListarNombre";
            this.btnListarNombre.Size = new System.Drawing.Size(140, 40);
            this.btnListarNombre.TabIndex = 2;
            this.btnListarNombre.Text = "Listar Tipo";
            this.btnListarNombre.UseVisualStyleBackColor = true;
            this.btnListarNombre.Click += new System.EventHandler(this.btnListarNombre_Click);
            // 
            // btnListarTodo
            // 
            this.btnListarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodo.Location = new System.Drawing.Point(33, 424);
            this.btnListarTodo.Name = "btnListarTodo";
            this.btnListarTodo.Size = new System.Drawing.Size(116, 40);
            this.btnListarTodo.TabIndex = 1;
            this.btnListarTodo.Text = "Listar";
            this.btnListarTodo.UseVisualStyleBackColor = true;
            this.btnListarTodo.Click += new System.EventHandler(this.btnListarTodo_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridView2.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.Size = new System.Drawing.Size(985, 394);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.ColumnHeaderCellChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView2_ColumnHeaderCellChanged);
            this.dataGridView2.ColumnNameChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView2_ColumnNameChanged);
            // 
            // lVenta
            // 
            this.lVenta.AutoSize = true;
            this.lVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVenta.Location = new System.Drawing.Point(313, 9);
            this.lVenta.Name = "lVenta";
            this.lVenta.Size = new System.Drawing.Size(365, 46);
            this.lVenta.TabIndex = 2;
            this.lVenta.Text = "Ventas de Artículos";
            // 
            // cbxListarCategoria
            // 
            this.cbxListarCategoria.FormattingEnabled = true;
            this.cbxListarCategoria.Location = new System.Drawing.Point(301, 430);
            this.cbxListarCategoria.Name = "cbxListarCategoria";
            this.cbxListarCategoria.Size = new System.Drawing.Size(155, 28);
            this.cbxListarCategoria.TabIndex = 6;
            this.cbxListarCategoria.Text = "Categorias";
            // 
            // btnGuardarPDF
            // 
            this.btnGuardarPDF.Location = new System.Drawing.Point(821, 418);
            this.btnGuardarPDF.Name = "btnGuardarPDF";
            this.btnGuardarPDF.Size = new System.Drawing.Size(131, 40);
            this.btnGuardarPDF.TabIndex = 7;
            this.btnGuardarPDF.Text = "Guardar PDF";
            this.btnGuardarPDF.UseVisualStyleBackColor = true;
            this.btnGuardarPDF.Click += new System.EventHandler(this.btnGuardarPDF_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 623);
            this.Controls.Add(this.lVenta);
            this.Controls.Add(this.tabC);
            this.Name = "Form1";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabC.ResumeLayout(false);
            this.tabVenta.ResumeLayout(false);
            this.tabVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbRegistrar.ResumeLayout(false);
            this.tbRegistrar.PerformLayout();
            this.tabVer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabC;
        private System.Windows.Forms.TabPage tabVenta;
        private System.Windows.Forms.TabPage tbRegistrar;
        private System.Windows.Forms.TabPage tabVer;
        private System.Windows.Forms.TextBox tbVenta;
        private System.Windows.Forms.Label nVenta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lVenta;
        private System.Windows.Forms.Label lPeso;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lStock;
        private System.Windows.Forms.Label lPrecioC;
        private System.Windows.Forms.Label lNombredelArticulo;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnListarNombre;
        private System.Windows.Forms.Button btnListarTodo;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxListarCategoria;
        private System.Windows.Forms.Button btnGuardarPDF;
    }
}

