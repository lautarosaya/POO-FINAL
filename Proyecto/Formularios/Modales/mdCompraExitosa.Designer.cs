namespace Proyecto.Formularios.Modales
{
    partial class mdCompraExitosa
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaceptar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Highlight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 50;
            this.iconPictureBox1.Location = new System.Drawing.Point(15, 30);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(54, 50);
            this.iconPictureBox1.TabIndex = 85;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 14);
            this.label2.TabIndex = 84;
            this.label2.Text = "Numero de documento generado:";
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(79, 58);
            this.txtnumerodocumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.ReadOnly = true;
            this.txtnumerodocumento.Size = new System.Drawing.Size(190, 20);
            this.txtnumerodocumento.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 82;
            this.label1.Text = "Compra Registrada!";
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnaceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnaceptar.ForeColor = System.Drawing.Color.Black;
            this.btnaceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnaceptar.IconColor = System.Drawing.Color.Black;
            this.btnaceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnaceptar.IconSize = 20;
            this.btnaceptar.Location = new System.Drawing.Point(173, 87);
            this.btnaceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(97, 25);
            this.btnaceptar.TabIndex = 81;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // mdCompraExitosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 124);
            this.ControlBox = false;
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumerodocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaceptar);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(301, 163);
            this.MinimumSize = new System.Drawing.Size(301, 163);
            this.Name = "mdCompraExitosa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Mensaje :.";
            this.Load += new System.EventHandler(this.mdCompraExitosa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnaceptar;
    }
}