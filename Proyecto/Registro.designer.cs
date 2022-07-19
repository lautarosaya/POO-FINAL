namespace vista.Login
{
    partial class Registro
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtSee = new FontAwesome.Sharp.IconButton();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pctNombre = new System.Windows.Forms.PictureBox();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.pctCorreo = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.pctApellido = new System.Windows.Forms.PictureBox();
            this.pctContraseña = new System.Windows.Forms.PictureBox();
            this.btnRegistrarLO = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.pnl1);
            this.pnlLogin.Controls.Add(this.btnRegistrarLO);
            this.pnlLogin.Controls.Add(this.btnIniciar);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(445, 334);
            this.pnlLogin.TabIndex = 11;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.lblresultado);
            this.pnl1.Controls.Add(this.txtSee);
            this.pnl1.Controls.Add(this.lblBienvenido);
            this.pnl1.Controls.Add(this.btnRegistrar);
            this.pnl1.Controls.Add(this.txtUsuario);
            this.pnl1.Controls.Add(this.txtNombre);
            this.pnl1.Controls.Add(this.pctNombre);
            this.pnl1.Controls.Add(this.pctUsuario);
            this.pnl1.Controls.Add(this.txtMail);
            this.pnl1.Controls.Add(this.pctCorreo);
            this.pnl1.Controls.Add(this.txtContraseña);
            this.pnl1.Controls.Add(this.txtApellido);
            this.pnl1.Controls.Add(this.pctApellido);
            this.pnl1.Controls.Add(this.pctContraseña);
            this.pnl1.Location = new System.Drawing.Point(3, 66);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(442, 265);
            this.pnl1.TabIndex = 7;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(404, 9);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 13);
            this.lblresultado.TabIndex = 10;
            this.lblresultado.Visible = false;
            // 
            // txtSee
            // 
            this.txtSee.FlatAppearance.BorderSize = 0;
            this.txtSee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSee.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.txtSee.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(137)))));
            this.txtSee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtSee.IconSize = 33;
            this.txtSee.Location = new System.Drawing.Point(415, 118);
            this.txtSee.Name = "txtSee";
            this.txtSee.Size = new System.Drawing.Size(24, 24);
            this.txtSee.TabIndex = 3;
            this.txtSee.Tag = "Contraseña";
            this.txtSee.UseVisualStyleBackColor = true;
            this.txtSee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSee_MouseClick);
            this.txtSee.MouseEnter += new System.EventHandler(this.txtSee_MouseEnter);
            this.txtSee.MouseLeave += new System.EventHandler(this.txtSee_MouseLeave);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(134, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(175, 38);
            this.lblBienvenido.TabIndex = 4;
            this.lblBienvenido.Text = "Registrarse";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(65, 208);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(312, 48);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnLoginLO_Click);
            this.btnRegistrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRegistrar_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(3, 119);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(201, 22);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Nombre de Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRegistrar_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Silver;
            this.txtNombre.Location = new System.Drawing.Point(3, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRegistrar_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // pctNombre
            // 
            this.pctNombre.BackColor = System.Drawing.Color.DarkGray;
            this.pctNombre.Location = new System.Drawing.Point(3, 72);
            this.pctNombre.Name = "pctNombre";
            this.pctNombre.Size = new System.Drawing.Size(201, 23);
            this.pctNombre.TabIndex = 7;
            this.pctNombre.TabStop = false;
            // 
            // pctUsuario
            // 
            this.pctUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.pctUsuario.Location = new System.Drawing.Point(3, 119);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(201, 23);
            this.pctUsuario.TabIndex = 7;
            this.pctUsuario.TabStop = false;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.Color.Silver;
            this.txtMail.Location = new System.Drawing.Point(49, 165);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(344, 22);
            this.txtMail.TabIndex = 4;
            this.txtMail.Text = "Correo Electronico";
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRegistrar_KeyPress);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // pctCorreo
            // 
            this.pctCorreo.BackColor = System.Drawing.Color.DarkGray;
            this.pctCorreo.Location = new System.Drawing.Point(49, 165);
            this.pctCorreo.Name = "pctCorreo";
            this.pctCorreo.Size = new System.Drawing.Size(344, 23);
            this.pctCorreo.TabIndex = 7;
            this.pctCorreo.TabStop = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Silver;
            this.txtContraseña.Location = new System.Drawing.Point(238, 120);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(201, 22);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Tag = "Contraseña";
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRegistrar_KeyPress);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Silver;
            this.txtApellido.Location = new System.Drawing.Point(238, 72);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(201, 22);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRegistrar_KeyPress);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // pctApellido
            // 
            this.pctApellido.BackColor = System.Drawing.Color.DarkGray;
            this.pctApellido.Location = new System.Drawing.Point(238, 72);
            this.pctApellido.Name = "pctApellido";
            this.pctApellido.Size = new System.Drawing.Size(201, 23);
            this.pctApellido.TabIndex = 7;
            this.pctApellido.TabStop = false;
            // 
            // pctContraseña
            // 
            this.pctContraseña.BackColor = System.Drawing.Color.DarkGray;
            this.pctContraseña.Location = new System.Drawing.Point(238, 120);
            this.pctContraseña.Name = "pctContraseña";
            this.pctContraseña.Size = new System.Drawing.Size(201, 23);
            this.pctContraseña.TabIndex = 7;
            this.pctContraseña.TabStop = false;
            // 
            // btnRegistrarLO
            // 
            this.btnRegistrarLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnRegistrarLO.FlatAppearance.BorderSize = 0;
            this.btnRegistrarLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarLO.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarLO.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarLO.Location = new System.Drawing.Point(12, 12);
            this.btnRegistrarLO.Name = "btnRegistrarLO";
            this.btnRegistrarLO.Size = new System.Drawing.Size(218, 48);
            this.btnRegistrarLO.TabIndex = 3;
            this.btnRegistrarLO.Text = "Registrar";
            this.btnRegistrarLO.UseVisualStyleBackColor = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(156)))), ((int)(((byte)(153)))));
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.DimGray;
            this.btnIniciar.Location = new System.Drawing.Point(227, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(206, 48);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 334);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Registro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.LocationChanged += new System.EventHandler(this.Registro_LocationChanged);
            this.pnlLogin.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContraseña)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnRegistrarLO;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pctNombre;
        private System.Windows.Forms.PictureBox pctApellido;
        private System.Windows.Forms.PictureBox pctContraseña;
        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.PictureBox pctCorreo;
        private FontAwesome.Sharp.IconButton txtSee;
        private System.Windows.Forms.Label lblresultado;
    }
}