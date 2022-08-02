using COMUN;
using Proyecto.Herrarmientas;
using Proyecto.Modelo;
using ProyectoVenta.Logica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto.Formularios.Mantenimiento
{
    public partial class frmMantUsuario_ : Form
    {

        public bool _modo_editar { get; set; }
        public Usuario _Usuario { get; set; }
        public frmMantUsuario_()
        {
            InitializeComponent();
        }
        bool passwordEyeON = false;
        char passwordchar;

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantUsuario__Load(object sender, EventArgs e)
        {
            cborol.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Administrador" });
            cborol.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Empleado" });
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;


            if (_modo_editar)
            {
                txtusuario.Text = _Usuario.NombreUsuario;
                txtnombre.Text = _Usuario.NombreCompleto;
                int encontrado = 0;
                foreach (OpcionCombo oc in cborol.Items)
                {
                    if (Convert.ToInt32(oc.Valor.ToString()) == _Usuario.IdPermisos)
                    {
                        break;
                    }
                    encontrado++;
                }
                cborol.SelectedIndex = encontrado;
                txtclave.Text = COMUN.MetodosComunes.DesEncriptarPassBD(_Usuario.Clave);
                txtconfirmarclave.Text = COMUN.MetodosComunes.DesEncriptarPassBD(_Usuario.Clave);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            lblresultado.Visible = true;
            string mensaje = string.Empty;

            if (txtusuario.Text.Trim() == "")
            {
                lblresultado.Text = "Debe ingresar el usuario";
                lblresultado.ForeColor = Color.Red;
                return;
            }
            if (txtnombre.Text.Trim() == "")
            {
                lblresultado.Text = "Debe ingresar el nombre";
                lblresultado.ForeColor = Color.Red;
                return;
            }

            if (txtclave.Text.Trim() == "" || txtconfirmarclave.Text.Trim() == "")
            {
                lblresultado.Text = "Debe ingresar las claves";
                lblresultado.ForeColor = Color.Red;
                return;
            }

            if (txtclave.Text.Trim() != txtconfirmarclave.Text.Trim())
            {
                lblresultado.Text = "Las contraseñas no coinciden";
                lblresultado.ForeColor = Color.Red;
                return;
            }

            if (_Usuario != null)
            {
                _Usuario.NombreUsuario = txtusuario.Text;
                _Usuario.NombreCompleto = txtnombre.Text;
                _Usuario.IdPermisos = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor.ToString());
                _Usuario.Descripcion = ((OpcionCombo)cborol.SelectedItem).Texto.ToString();
                _Usuario.Clave = MetodosComunes.EncriptarPassBD(txtclave.Text);
            }
            else
                _Usuario = new Usuario()
                {
                    IdUsuario = 0,
                    NombreUsuario = txtusuario.Text,
                    NombreCompleto = txtnombre.Text,
                    IdPermisos = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor.ToString()),
                    Descripcion = ((OpcionCombo)cborol.SelectedItem).Texto.ToString(),
                    Clave = MetodosComunes.EncriptarPassBD(txtclave.Text)
                };

            int existe = UsuarioLogica.Instancia.Existe(_Usuario.NombreUsuario, _Usuario.IdUsuario, out mensaje);
            if (existe > 0)
            {
                lblresultado.Text = mensaje;
                lblresultado.ForeColor = Color.Red;
                return;
            }

            if (!_modo_editar)
            {
                int idgenerado = UsuarioLogica.Instancia.Guardar(_Usuario, out mensaje);
                if (idgenerado > 0)
                {
                    _Usuario.IdUsuario = idgenerado;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblresultado.Text = mensaje;
                    lblresultado.ForeColor = Color.Red;
                }
            }
            else
            {
                int afectados = UsuarioLogica.Instancia.Editar(_Usuario, out mensaje);
                if (afectados > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblresultado.Text = mensaje;
                    lblresultado.ForeColor = Color.Red;
                }

            }
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSee_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSee.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                txtSee.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                passwordEyeON = true;
                passwordCHAR(6);
            }
            else
            {
                if (txtSee.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
                {
                    txtSee.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    passwordEyeON = false;
                    passwordCHAR(7);
                }
            }
            SendKeys.Send("+{TAB}");


        }
        private void txtSee_MouseEnter(object sender, EventArgs e)
        {
            txtSee.IconFont = FontAwesome.Sharp.IconFont.Solid;

        }

        private void txtSee_MouseLeave(object sender, EventArgs e)
        {
            txtSee.IconFont = FontAwesome.Sharp.IconFont.Auto;
        }

        private void txtclave_TextChanged_1(object sender, EventArgs e)
        {
            if (txtclave.Text != String.Empty)
            {
                if (txtclave.ForeColor == Color.Silver)
                {
                    passwordCHAR(4);
                }
                else
                {
                    passwordCHAR(3);
                }

            }
        }
         public void passwordCHAR(int caso)
        {

            switch (caso)
            {
                case 1:
                    txtclave.Text = "";
                    txtclave.PasswordChar = '*';
                    txtclave.ForeColor = Color.Black;

                    break;
                case 2:
                    txtclave.Text = "Contraseña";
                    txtclave.PasswordChar = passwordchar;
                    txtclave.ForeColor = Color.Silver;

                    break;
                case 3:
                    txtSee.Visible = true;
                    break;
                case 4:
                    txtSee.Visible = false;
                    break;
                case 5:
                    txtSee.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    passwordEyeON = false;
                    txtSee.Visible = false;
                    break;
                case 6:
                    txtclave.PasswordChar = passwordchar;
                    txtclave.ForeColor = Color.Black;
                    break;
                case 7:
                    txtclave.PasswordChar = '*';
                    txtclave.ForeColor = Color.Black;
                    break;

            }

        }

        public void passwordCHAR2(int caso)
        {

            switch (caso)
            {
                case 1:
                    txtconfirmarclave.Text = "";
                    txtconfirmarclave.PasswordChar = '*';
                    txtconfirmarclave.ForeColor = Color.Black;

                    break;
                case 2:
                    txtconfirmarclave.Text = "Contraseña";
                    txtconfirmarclave.PasswordChar = passwordchar;
                    txtconfirmarclave.ForeColor = Color.Silver;

                    break;
                case 3:
                    txtSee.Visible = true;
                    break;
                case 4:
                    txtSee.Visible = false;
                    break;
                case 5:
                    txtSee.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    passwordEyeON = false;
                    txtSee.Visible = false;
                    break;
                case 6:
                    txtconfirmarclave.PasswordChar = passwordchar;
                    txtconfirmarclave.ForeColor = Color.Black;
                    break;
                case 7:
                    txtconfirmarclave.PasswordChar = '*';
                    txtconfirmarclave.ForeColor = Color.Black;
                    break;

            }

        }
        private void iconButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSee2.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                txtSee2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                passwordEyeON = true;
                passwordCHAR2(6);
            }
            else
            {
                if (txtSee2.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
                {
                    txtSee2.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    passwordEyeON = false;
                    passwordCHAR2(7);
                }
            }
            SendKeys.Send("+{TAB}");

        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            txtSee2.IconFont = FontAwesome.Sharp.IconFont.Solid;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            txtSee2.IconFont = FontAwesome.Sharp.IconFont.Auto;

        }

        private void txtconfirmarclave_TextChanged(object sender, EventArgs e)
        {
            if (txtconfirmarclave.Text != String.Empty)
            {
                if (txtconfirmarclave.ForeColor == Color.Silver)
                {
                    passwordCHAR2(4);
                }
                else
                {
                    passwordCHAR2(3);
                }

            }
        }
    }
}
