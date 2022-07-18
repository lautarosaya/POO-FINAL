namespace vista.Login
{
    partial class CodigoConfirmacion
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
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.ICOBack = new FontAwesome.Sharp.IconButton();
            this.lblVerificar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlLabel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLabel
            // 
            this.pnlLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.pnlLabel.Controls.Add(this.ICOBack);
            this.pnlLabel.Controls.Add(this.lblVerificar);
            this.pnlLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.pnlLabel.Location = new System.Drawing.Point(0, 0);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(663, 60);
            this.pnlLabel.TabIndex = 0;
            this.pnlLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLabel_MouseDown);
            // 
            // ICOBack
            // 
            this.ICOBack.BackColor = System.Drawing.Color.Transparent;
            this.ICOBack.FlatAppearance.BorderSize = 0;
            this.ICOBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICOBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ICOBack.IconColor = System.Drawing.Color.PaleGoldenrod;
            this.ICOBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICOBack.IconSize = 40;
            this.ICOBack.Location = new System.Drawing.Point(16, 12);
            this.ICOBack.Name = "ICOBack";
            this.ICOBack.Size = new System.Drawing.Size(40, 38);
            this.ICOBack.TabIndex = 6;
            this.ICOBack.UseVisualStyleBackColor = false;
            this.ICOBack.Click += new System.EventHandler(this.ICOBack_Click);
            this.ICOBack.MouseEnter += new System.EventHandler(this.ICOBack_MouseEnter);
            this.ICOBack.MouseLeave += new System.EventHandler(this.ICOBack_MouseLeave);
            // 
            // lblVerificar
            // 
            this.lblVerificar.AutoSize = true;
            this.lblVerificar.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificar.ForeColor = System.Drawing.Color.White;
            this.lblVerificar.Location = new System.Drawing.Point(190, 11);
            this.lblVerificar.Name = "lblVerificar";
            this.lblVerificar.Size = new System.Drawing.Size(282, 38);
            this.lblVerificar.TabIndex = 5;
            this.lblVerificar.Text = "Verificar su cuenta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblInformacion);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 103);
            this.panel1.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Georgia", 13F);
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(12, 67);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 21);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.Black;
            this.lblInformacion.Location = new System.Drawing.Point(6, 3);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(258, 23);
            this.lblInformacion.TabIndex = 6;
            this.lblInformacion.Text = "Información de tu cuenta";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Georgia", 13F);
            this.lblMail.ForeColor = System.Drawing.Color.Black;
            this.lblMail.Location = new System.Drawing.Point(12, 35);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(157, 21);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Correo electronico";
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.txt1.Font = new System.Drawing.Font("Consolas", 40F);
            this.txt1.Location = new System.Drawing.Point(3, 1);
            this.txt1.MaxLength = 1;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(124, 70);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "1";
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.txt2.Font = new System.Drawing.Font("Consolas", 40F);
            this.txt2.Location = new System.Drawing.Point(133, 1);
            this.txt2.MaxLength = 1;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(124, 70);
            this.txt2.TabIndex = 1;
            this.txt2.Text = "1";
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt2.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.txt4.Font = new System.Drawing.Font("Consolas", 40F);
            this.txt4.Location = new System.Drawing.Point(393, 1);
            this.txt4.MaxLength = 1;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(124, 70);
            this.txt4.TabIndex = 3;
            this.txt4.Text = "1";
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt5
            // 
            this.txt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.txt5.Font = new System.Drawing.Font("Consolas", 40F);
            this.txt5.Location = new System.Drawing.Point(527, 1);
            this.txt5.MaxLength = 1;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(124, 70);
            this.txt5.TabIndex = 4;
            this.txt5.Text = "1";
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt5.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            this.txt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.txt3.Font = new System.Drawing.Font("Consolas", 40F);
            this.txt3.Location = new System.Drawing.Point(263, 1);
            this.txt3.MaxLength = 1;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(124, 70);
            this.txt3.TabIndex = 2;
            this.txt3.Text = "1";
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt3.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.txt3);
            this.panel2.Controls.Add(this.txt5);
            this.panel2.Controls.Add(this.txt1);
            this.panel2.Controls.Add(this.txt2);
            this.panel2.Controls.Add(this.txt4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 74);
            this.panel2.TabIndex = 7;
            // 
            // CodigoConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 240);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CodigoConfirmacion";
            this.Text = "Confirmación";
            this.Load += new System.EventHandler(this.CodigoConfirmacion_Load);
            this.pnlLabel.ResumeLayout(false);
            this.pnlLabel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.Label lblVerificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ICOBack;
    }
}