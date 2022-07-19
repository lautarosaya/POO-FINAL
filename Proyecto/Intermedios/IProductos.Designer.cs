namespace Proyecto.Intermedios
{
    partial class IProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new FontAwesome.Sharp.IconButton();
            this.btnnuevaproducto = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 296);
            this.label1.TabIndex = 14;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(107)))), ((int)(((byte)(78)))));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
<<<<<<< HEAD
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
=======
            this.btncerrar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
>>>>>>> 50b76aa3203047a73b6815ae331d10802c2b000b
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btncerrar.IconColor = System.Drawing.Color.White;
            this.btncerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrar.Location = new System.Drawing.Point(41, 191);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Padding = new System.Windows.Forms.Padding(60, 3, 0, 0);
            this.btncerrar.Size = new System.Drawing.Size(247, 55);
            this.btncerrar.TabIndex = 13;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnnuevaproducto
            // 
            this.btnnuevaproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(107)))), ((int)(((byte)(78)))));
            this.btnnuevaproducto.Cursor = System.Windows.Forms.Cursors.Hand;
<<<<<<< HEAD
            this.btnnuevaproducto.FlatAppearance.BorderSize = 0;
            this.btnnuevaproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
=======
            this.btnnuevaproducto.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
>>>>>>> 50b76aa3203047a73b6815ae331d10802c2b000b
            this.btnnuevaproducto.ForeColor = System.Drawing.Color.White;
            this.btnnuevaproducto.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnnuevaproducto.IconColor = System.Drawing.Color.White;
            this.btnnuevaproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnnuevaproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevaproducto.Location = new System.Drawing.Point(41, 92);
            this.btnnuevaproducto.Name = "btnnuevaproducto";
            this.btnnuevaproducto.Padding = new System.Windows.Forms.Padding(60, 3, 0, 0);
            this.btnnuevaproducto.Size = new System.Drawing.Size(247, 55);
            this.btnnuevaproducto.TabIndex = 10;
            this.btnnuevaproducto.Text = "Nuevo Producto";
            this.btnnuevaproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevaproducto.UseVisualStyleBackColor = false;
            this.btnnuevaproducto.Click += new System.EventHandler(this.btnnuevaproducto_Click);
            // 
            // IProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(322, 314);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnnuevaproducto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(322, 314);
            this.MaximumSize = new System.Drawing.Size(322, 314);
            this.MinimumSize = new System.Drawing.Size(322, 314);
            this.Name = "IProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IProductos";
            this.Load += new System.EventHandler(this.IProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btncerrar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnnuevaproducto;
    }
}