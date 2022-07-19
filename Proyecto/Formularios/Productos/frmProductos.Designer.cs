namespace Proyecto.Formularios.Productos
{
    partial class frmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbobuscar = new System.Windows.Forms.ComboBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnuevoproducto = new FontAwesome.Sharp.IconButton();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.btnborrar = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // cbobuscar
            // 
            this.cbobuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobuscar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobuscar.FormattingEnabled = true;
            this.cbobuscar.Location = new System.Drawing.Point(810, 137);
            this.cbobuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbobuscar.Name = "cbobuscar";
            this.cbobuscar.Size = new System.Drawing.Size(168, 22);
            this.cbobuscar.TabIndex = 131;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(986, 137);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(157, 21);
            this.txtbuscar.TabIndex = 132;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(722, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 139;
            this.label12.Text = "Buscar por:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(12, 103);
=======
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.label7.Location = new System.Drawing.Point(14, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
>>>>>>> 50b76aa3203047a73b6815ae331d10802c2b000b
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 15);
            this.label7.TabIndex = 138;
            this.label7.Text = "LISTA DE PRODUCTOS";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Producto,
            this.Categoria,
            this.Medida,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Stock,
            this.btneditar,
            this.btneliminar});
            this.dgvdata.Location = new System.Drawing.Point(18, 168);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.Size = new System.Drawing.Size(1224, 420);
            this.dgvdata.TabIndex = 137;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(1247, 44);
            this.label2.TabIndex = 136;
            this.label2.Text = "Productos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1247, 553);
            this.label1.TabIndex = 135;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1227, 11);
            this.groupBox1.TabIndex = 194;
            this.groupBox1.TabStop = false;
            // 
            // btnnuevoproducto
            // 
            this.btnnuevoproducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnnuevoproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevoproducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnuevoproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnnuevoproducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.btnnuevoproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnnuevoproducto.IconSize = 17;
            this.btnnuevoproducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnnuevoproducto.Location = new System.Drawing.Point(18, 64);
            this.btnnuevoproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnnuevoproducto.Name = "btnnuevoproducto";
            this.btnnuevoproducto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnnuevoproducto.Size = new System.Drawing.Size(138, 23);
            this.btnnuevoproducto.TabIndex = 195;
            this.btnnuevoproducto.Text = "Nuevo Producto";
            this.btnnuevoproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevoproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevoproducto.UseVisualStyleBackColor = false;
            this.btnnuevoproducto.Click += new System.EventHandler(this.btnnuevoproducto_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnsalir.IconSize = 24;
            this.btnsalir.Location = new System.Drawing.Point(1168, 10);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(80, 33);
            this.btnsalir.TabIndex = 140;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnborrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrar.IconSize = 20;
            this.btnborrar.Location = new System.Drawing.Point(1198, 137);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnborrar.Size = new System.Drawing.Size(43, 23);
            this.btnborrar.TabIndex = 134;
            this.btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 18;
            this.btnbuscar.Location = new System.Drawing.Point(1150, 137);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnbuscar.Size = new System.Drawing.Size(43, 23);
            this.btnbuscar.TabIndex = 133;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Codigo.Width = 120;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Categoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Categoria.Width = 140;
            // 
            // Medida
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Medida.DefaultCellStyle = dataGridViewCellStyle5;
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            this.Medida.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Medida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Medida.Width = 130;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecioCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecioVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Stock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btneditar
            // 
            this.btneditar.HeaderText = "";
            this.btneditar.Name = "btneditar";
            this.btneditar.ReadOnly = true;
            this.btneditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btneditar.Width = 35;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btneliminar.Width = 35;
            // 
<<<<<<< HEAD
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(156)))), ((int)(((byte)(114)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(1069, 41);
            this.label2.TabIndex = 136;
            this.label2.Text = "Productos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1069, 514);
            this.label1.TabIndex = 135;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 10);
            this.groupBox1.TabIndex = 194;
            this.groupBox1.TabStop = false;
            // 
            // btnnuevoproducto
            // 
            this.btnnuevoproducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnnuevoproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevoproducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnuevoproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnnuevoproducto.IconColor = System.Drawing.Color.LimeGreen;
            this.btnnuevoproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnnuevoproducto.IconSize = 17;
            this.btnnuevoproducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnnuevoproducto.Location = new System.Drawing.Point(15, 59);
            this.btnnuevoproducto.Name = "btnnuevoproducto";
            this.btnnuevoproducto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnnuevoproducto.Size = new System.Drawing.Size(118, 21);
            this.btnnuevoproducto.TabIndex = 195;
            this.btnnuevoproducto.Text = "Nuevo Producto";
            this.btnnuevoproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevoproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevoproducto.UseVisualStyleBackColor = false;
            this.btnnuevoproducto.Click += new System.EventHandler(this.btnnuevoproducto_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(156)))), ((int)(((byte)(114)))));
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnsalir.IconSize = 24;
            this.btnsalir.Location = new System.Drawing.Point(1001, 9);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(69, 31);
            this.btnsalir.TabIndex = 140;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnborrar.IconColor = System.Drawing.Color.Teal;
            this.btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrar.IconSize = 20;
            this.btnborrar.Location = new System.Drawing.Point(1027, 127);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnborrar.Size = new System.Drawing.Size(37, 21);
            this.btnborrar.TabIndex = 134;
            this.btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.Teal;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 18;
            this.btnbuscar.Location = new System.Drawing.Point(986, 127);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnbuscar.Size = new System.Drawing.Size(37, 21);
            this.btnbuscar.TabIndex = 133;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
=======
>>>>>>> 50b76aa3203047a73b6815ae331d10802c2b000b
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 606);
            this.Controls.Add(this.btnnuevoproducto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.cbobuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1274, 645);
            this.MinimumSize = new System.Drawing.Size(1274, 645);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Productos :.";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnnuevoproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewButtonColumn btneditar;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}