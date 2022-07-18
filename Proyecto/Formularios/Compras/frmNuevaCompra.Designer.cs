namespace Proyecto.Formularios.Compras
{
    partial class frmNuevaCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.txtfecharegistro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtnombreproveedor = new System.Windows.Forms.TextBox();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.txtdocproveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnCrearCompra = new FontAwesome.Sharp.IconButton();
            this.btnCancelarCompra = new FontAwesome.Sharp.IconButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkGreen;
            this.label12.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(281, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 31);
            this.label12.TabIndex = 37;
            this.label12.Text = "Nueva Compra";
            // 
            // txtfecharegistro
            // 
            this.txtfecharegistro.Location = new System.Drawing.Point(598, 66);
            this.txtfecharegistro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfecharegistro.Name = "txtfecharegistro";
            this.txtfecharegistro.ReadOnly = true;
            this.txtfecharegistro.Size = new System.Drawing.Size(129, 20);
            this.txtfecharegistro.TabIndex = 100;
            this.txtfecharegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGreen;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(496, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 14);
            this.label11.TabIndex = 35;
            this.label11.Text = "Fecha Registro:";
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(322, 66);
            this.txtnumerodocumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.ReadOnly = true;
            this.txtnumerodocumento.Size = new System.Drawing.Size(138, 20);
            this.txtnumerodocumento.TabIndex = 34;
            this.txtnumerodocumento.Text = "Autogenerado";
            this.txtnumerodocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGreen;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(192, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 14);
            this.label10.TabIndex = 33;
            this.label10.Text = "Numero Documento:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(5, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(741, 101);
            this.label9.TabIndex = 31;
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(609, 517);
            this.txttotalpagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(129, 20);
            this.txttotalpagar.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 520);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 14);
            this.label8.TabIndex = 28;
            this.label8.Text = "Total a Pagar:";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Producto,
            this.Categoria,
            this.Medida,
            this.Cantidad,
            this.PrecioVenta,
            this.PrecioCompra,
            this.SubTotal,
            this.btneliminar});
            this.dgvdata.Location = new System.Drawing.Point(6, 16);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.Size = new System.Drawing.Size(728, 209);
            this.dgvdata.TabIndex = 14;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvdata);
            this.groupBox2.Location = new System.Drawing.Point(5, 270);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(741, 236);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpreciocompra);
            this.groupBox1.Controls.Add(this.btnbuscarproducto);
            this.groupBox1.Controls.Add(this.btnbuscarproveedor);
            this.groupBox1.Controls.Add(this.btnagregarproducto);
            this.groupBox1.Controls.Add(this.txtprecioventa);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.txtnombreproveedor);
            this.groupBox1.Controls.Add(this.txtcodproducto);
            this.groupBox1.Controls.Add(this.txtdocproveedor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(741, 155);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(496, 87);
            this.txtpreciocompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(227, 20);
            this.txtpreciocompra.TabIndex = 8;
            this.txtpreciocompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciocompra_KeyPress);
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproducto.IconSize = 20;
            this.btnbuscarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarproducto.Location = new System.Drawing.Point(286, 54);
            this.btnbuscarproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(80, 25);
            this.btnbuscarproducto.TabIndex = 5;
            this.btnbuscarproducto.Text = "Buscar";
            this.btnbuscarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // btnbuscarproveedor
            // 
            this.btnbuscarproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarproveedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.btnbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproveedor.IconSize = 20;
            this.btnbuscarproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarproveedor.Location = new System.Drawing.Point(286, 23);
            this.btnbuscarproveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnbuscarproveedor.Name = "btnbuscarproveedor";
            this.btnbuscarproveedor.Size = new System.Drawing.Size(80, 25);
            this.btnbuscarproveedor.TabIndex = 2;
            this.btnbuscarproveedor.Text = "Buscar";
            this.btnbuscarproveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarproveedor.UseVisualStyleBackColor = true;
            this.btnbuscarproveedor.Click += new System.EventHandler(this.btnbuscarproveedor_Click);
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnagregarproducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarproducto.IconSize = 20;
            this.btnagregarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregarproducto.Location = new System.Drawing.Point(496, 116);
            this.btnagregarproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(227, 25);
            this.btnagregarproducto.TabIndex = 10;
            this.btnagregarproducto.Text = "Agregar";
            this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregarproducto.UseVisualStyleBackColor = true;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(119, 118);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(154, 20);
            this.txtprecioventa.TabIndex = 9;
            this.txtprecioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioventa_KeyPress);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(119, 88);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(155, 20);
            this.txtcantidad.TabIndex = 7;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(496, 57);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(227, 20);
            this.txtproducto.TabIndex = 6;
            // 
            // txtnombreproveedor
            // 
            this.txtnombreproveedor.Location = new System.Drawing.Point(496, 25);
            this.txtnombreproveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnombreproveedor.Name = "txtnombreproveedor";
            this.txtnombreproveedor.ReadOnly = true;
            this.txtnombreproveedor.Size = new System.Drawing.Size(227, 20);
            this.txtnombreproveedor.TabIndex = 3;
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(119, 56);
            this.txtcodproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(154, 20);
            this.txtcodproducto.TabIndex = 4;
            this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown);
            // 
            // txtdocproveedor
            // 
            this.txtdocproveedor.Location = new System.Drawing.Point(119, 25);
            this.txtdocproveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdocproveedor.Name = "txtdocproveedor";
            this.txtdocproveedor.Size = new System.Drawing.Size(154, 20);
            this.txtdocproveedor.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio Compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cod. Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Proveedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doc. Proveedor:";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox1.BackgroundImage = global::Proyecto.Properties.Resources.logo;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 78;
            this.iconPictureBox1.Location = new System.Drawing.Point(14, 10);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(88, 78);
            this.iconPictureBox1.TabIndex = 32;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnCrearCompra
            // 
            this.btnCrearCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearCompra.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnCrearCompra.IconColor = System.Drawing.Color.LimeGreen;
            this.btnCrearCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearCompra.IconSize = 20;
            this.btnCrearCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearCompra.Location = new System.Drawing.Point(159, 514);
            this.btnCrearCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCrearCompra.Name = "btnCrearCompra";
            this.btnCrearCompra.Size = new System.Drawing.Size(162, 25);
            this.btnCrearCompra.TabIndex = 11;
            this.btnCrearCompra.Text = "Crear Compra";
            this.btnCrearCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearCompra.UseVisualStyleBackColor = true;
            this.btnCrearCompra.Click += new System.EventHandler(this.btnCrearCompra_Click);
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCompra.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelarCompra.IconColor = System.Drawing.Color.Red;
            this.btnCancelarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarCompra.IconSize = 20;
            this.btnCancelarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCompra.Location = new System.Drawing.Point(10, 514);
            this.btnCancelarCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(139, 25);
            this.btnCancelarCompra.TabIndex = 12;
            this.btnCancelarCompra.Text = "Cancelar Compra";
            this.btnCancelarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.FillWeight = 30F;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Categoria.FillWeight = 20F;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Visible = false;
            // 
            // Medida
            // 
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            this.Medida.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 70;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioCompra.FillWeight = 25F;
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecioCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubTotal.FillWeight = 25F;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SubTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Width = 35;
            // 
            // frmNuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 559);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtfecharegistro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtnumerodocumento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCrearCompra);
            this.Controls.Add(this.btnCancelarCompra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(768, 598);
            this.MinimumSize = new System.Drawing.Size(768, 598);
            this.Name = "frmNuevaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Nueva Compra :.";
            this.Load += new System.EventHandler(this.frmNuevaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtfecharegistro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnCrearCompra;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnCancelarCompra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtnombreproveedor;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.TextBox txtdocproveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}