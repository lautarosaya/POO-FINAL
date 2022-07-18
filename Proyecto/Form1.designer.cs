namespace vista
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtSee = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarLO = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnLoginLO = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.pctPassword = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.txtSee);
            this.pnlLogin.Controls.Add(this.btnRegistrarLO);
            this.pnlLogin.Controls.Add(this.lblBienvenido);
            this.pnlLogin.Controls.Add(this.btnLoginLO);
            this.pnlLogin.Controls.Add(this.btnIniciar);
            this.pnlLogin.Controls.Add(this.txtContraseña);
            this.pnlLogin.Controls.Add(this.pctPassword);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.pctUsuario);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(402, 300);
            this.pnlLogin.TabIndex = 0;
            // 
            // txtSee
            // 
            this.txtSee.BackColor = System.Drawing.Color.Transparent;
            this.txtSee.FlatAppearance.BorderSize = 0;
            this.txtSee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSee.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.txtSee.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.txtSee.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.txtSee.IconSize = 33;
            this.txtSee.Location = new System.Drawing.Point(337, 195);
            this.txtSee.Name = "txtSee";
            this.txtSee.Size = new System.Drawing.Size(24, 22);
            this.txtSee.TabIndex = 1;
            this.txtSee.Tag = "Contraseña";
            this.txtSee.UseVisualStyleBackColor = false;
            this.txtSee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSee_MouseClick);
            this.txtSee.MouseEnter += new System.EventHandler(this.txtSee_MouseEnter);
            this.txtSee.MouseLeave += new System.EventHandler(this.txtSee_MouseLeave);
            // 
            // btnRegistrarLO
            // 
            this.btnRegistrarLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(153)))));
            this.btnRegistrarLO.FlatAppearance.BorderSize = 0;
            this.btnRegistrarLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarLO.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarLO.ForeColor = System.Drawing.Color.DimGray;
            this.btnRegistrarLO.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarLO.Name = "btnRegistrarLO";
            this.btnRegistrarLO.Size = new System.Drawing.Size(205, 60);
            this.btnRegistrarLO.TabIndex = 3;
            this.btnRegistrarLO.Text = "Registrar";
            this.btnRegistrarLO.UseVisualStyleBackColor = true;
            this.btnRegistrarLO.Click += new System.EventHandler(this.btnRegistrarLO_Click);
            this.btnRegistrarLO.MouseEnter += new System.EventHandler(this.btnRegistrarLO_MouseEnter);
            this.btnRegistrarLO.MouseLeave += new System.EventHandler(this.btnRegistrarLO_MouseLeave);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(118, 73);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(175, 38);
            this.lblBienvenido.TabIndex = 4;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // btnLoginLO
            // 
            this.btnLoginLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnLoginLO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnLoginLO.FlatAppearance.BorderSize = 0;
            this.btnLoginLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginLO.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginLO.ForeColor = System.Drawing.Color.White;
            this.btnLoginLO.Location = new System.Drawing.Point(49, 244);
            this.btnLoginLO.Name = "btnLoginLO";
            this.btnLoginLO.Size = new System.Drawing.Size(312, 38);
            this.btnLoginLO.TabIndex = 2;
            this.btnLoginLO.Text = "Ingresar";
            this.btnLoginLO.UseVisualStyleBackColor = false;
            this.btnLoginLO.Click += new System.EventHandler(this.btnLoginLO_Click);
            this.btnLoginLO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLoginLO_KeyPress);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIniciar.Location = new System.Drawing.Point(202, 0);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(200, 60);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.UseVisualStyleBackColor = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Silver;
            this.txtContraseña.Location = new System.Drawing.Point(49, 196);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(312, 22);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Tag = "Contraseña";
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLoginLO_KeyPress);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // pctPassword
            // 
            this.pctPassword.BackColor = System.Drawing.Color.DarkGray;
            this.pctPassword.Location = new System.Drawing.Point(49, 196);
            this.pctPassword.Name = "pctPassword";
            this.pctPassword.Size = new System.Drawing.Size(312, 23);
            this.pctPassword.TabIndex = 7;
            this.pctPassword.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(49, 136);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(312, 22);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Tag = "Usuario";
            this.txtUsuario.Text = "Nombre de usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLoginLO_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // pctUsuario
            // 
            this.pctUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.pctUsuario.Location = new System.Drawing.Point(49, 136);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(312, 23);
            this.pctUsuario.TabIndex = 6;
            this.pctUsuario.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 300);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnLoginLO;
        private System.Windows.Forms.Button btnRegistrarLO;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.PictureBox pctPassword;
        private FontAwesome.Sharp.IconButton txtSee;
    }
}

