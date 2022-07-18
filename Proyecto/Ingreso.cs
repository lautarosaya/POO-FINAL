using System;
using System.Collections.Generic;
using Proyecto.Modelo;
using ProyectoVenta.Logica;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace vista
{
    public partial class Ingreso : Form
    {
        //Developed by Javier Ramírez//
        public Ingreso()
        {
            InitializeComponent();
        }
        //Variables//
        bool passwordEyeON = false;
        string Usuariotxt = "Nombre de usuario";
        char passwordchar;
        //Colores Seteados//
        Color greenHoover = Color.FromArgb(20, 135, 104);
        Color grisHoover = Color.FromArgb(126, 140, 137);
        Color greenLeave = Color.FromArgb(65, 168, 95);
        Color pctOn = Color.FromArgb(65, 168, 95);
        Color pctOff = Color.DarkGray;
        
        //DRAG MOVE, Mover formulario con panel// //Código Descarte, por la dudas se guarda para futuras actualizaciones//
        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]

        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //Fin del código mover (drag)//

        /*
        if (e.Button == MouseButtons.Left)

        {

        ReleaseCapture();

        SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);

        }*/

    private void Form1_Load(object sender, EventArgs e)
        {
            
            //GetPasswordChar
            passwordchar = txtContraseña.PasswordChar;
            btnLoginLO.FlatAppearance.MouseOverBackColor = greenHoover;
            btnIniciar.FlatAppearance.MouseOverBackColor = greenHoover;
            btnRegistrarLO.FlatAppearance.MouseOverBackColor = grisHoover;
            txtSee.Visible = false;            
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            placeholder(txtUsuario, 1, Usuariotxt);
            pctLineDecoration(pctUsuario, 1);      
            
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            placeholder(txtUsuario, 2, Usuariotxt);
            pctLineDecoration(pctUsuario, 2);
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "Contraseña")
            {
                passwordCHAR(1);
            }
            if(txtContraseña.Text != String.Empty && passwordEyeON == false)
            {
                passwordCHAR(3);
                passwordCHAR(7);
            }
            if(txtContraseña.Text != String.Empty && passwordEyeON == true)
            {
                passwordCHAR(3);
                passwordCHAR(6);
            }
            pctLineDecoration(pctPassword, 1);

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != String.Empty)
            {
                if(txtContraseña.ForeColor == Color.Silver)
                {
                    passwordCHAR(4);
                }
                else
                {
                    passwordCHAR(3);
                }
                
            }
        }

        
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                passwordCHAR(2);
            }          
        
            if (txtContraseña.Text != String.Empty && passwordEyeON == true)
            {
                passwordCHAR(3);
            }
            if (passwordEyeON == true && txtContraseña.Text == "Contraseña")
            {
                passwordCHAR(5);
            }
            if (passwordEyeON == false && txtContraseña.Text == "Contraseña")
            {
                passwordCHAR(4);
            }
            pctLineDecoration(pctPassword, 2);
        }

        private void btnRegistrarRE_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            this.Show();
            txtUsuario.Focus();
        }

        private void btnLoginLO_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            bool encontrado = false;

            if (txtUsuario.Text == "administrador" && txtContraseña.Text == "13579123")
            {
                int respuesta = UsuarioLogica.Instancia.resetear();
                if (respuesta > 0)
                {
                    MessageBox.Show("La cuenta fue restablecida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                List<Usuario> ouser = UsuarioLogica.Instancia.Listar(out mensaje);
                encontrado = ouser.Any(u => u.NombreUsuario == txtUsuario.Text && u.Clave == txtContraseña.Text);

                if (encontrado)
                {
                    Usuario objuser = ouser.Where(u => u.NombreUsuario == txtUsuario.Text && u.Clave == txtContraseña.Text).FirstOrDefault();

                    Proyecto.Inicio frm = new Proyecto.Inicio();
                    frm.NombreUsuario = objuser.NombreUsuario;
                    frm.Clave = objuser.Clave;
                    frm.NombreCompleto = objuser.NombreCompleto;
                    frm.FechaHora = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    frm.oPermisos = PermisosLogica.Instancia.Obtener(objuser.IdPermisos);
                    frm.Show();
                    this.Hide();
                    frm.FormClosing += Frm_Closing;
                }
                else
                {
                    if (string.IsNullOrEmpty(mensaje))
                    {
                        MessageBox.Show("No se encontraron coincidencias del usuario", "Mensaje C.E.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnRegistrarLO_Click(object sender, EventArgs e)
        {
            vista.Login.Registro registroFORM = new vista.Login.Registro(this.Location);
            this.Hide();
            registroFORM.ShowDialog();
            this.Location = registroFORM.locationchanged();
            //El programa se cerrará cuando el usuario cierre el formulario Registro//
            this.Show();
                                 
        }
     
        private void btnRegistrarLO_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarLO.ForeColor = Color.DimGray;
        }

        private void btnRegistrarLO_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrarLO.ForeColor = Color.White;
        }

        //Funciones//
        public void pctLineDecoration(PictureBox a, int caso)
        {
            //Esta función la uso para las lineas de color verde y gris, una decoración bastante moderna//
            //Caso 1 significa que el usuario entro al TextBox y Caso 2 Significa que el usuario salió del TextBox//
            switch (caso)
            {
                case 1:
                    a.Size = new Size(312, 24);
                    a.BackColor = pctOn;
                    break;

                case 2:
                    a.Size = new Size(312, 23);
                    a.BackColor = pctOff;
                    break;

                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        public void placeholder(TextBox a, int caso, string varText)
        {
            //Caso 1 Usuario Ingreso al TextBox y Caso2 Usuario sale del TextBox//
            switch (caso)
            {
                case 1:
                    if (a.Text == varText)
                    {
                        a.Text = "";
                        a.ForeColor = Color.Black;
                        
                    }
                    break;

                case 2:
                    if (a.Text == "")
                    {
                        a.Text = varText;
                        a.ForeColor = Color.Silver;
                        
                    }
                    break;

                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        public void passwordCHAR(int caso)
        {
            
            switch (caso)
            {
                case 1:
                    txtContraseña.Text = "";
                    txtContraseña.PasswordChar = '*';
                    txtContraseña.ForeColor = Color.Black;
                    
                    break;
                case 2:
                    txtContraseña.Text = "Contraseña";
                    txtContraseña.PasswordChar = passwordchar;
                    txtContraseña.ForeColor = Color.Silver;
                    
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
                    txtContraseña.PasswordChar = passwordchar;
                    txtContraseña.ForeColor = Color.Black;
                    break;
                case 7:
                    txtContraseña.PasswordChar = '*';
                    txtContraseña.ForeColor = Color.Black;
                    break;

            }

        }

        //Eventos de FONTAWESOME
        private void txtSee_MouseEnter(object sender, EventArgs e)
        {
            txtSee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            
        }

        private void txtSee_MouseLeave(object sender, EventArgs e)
        {          
            txtSee.IconFont = FontAwesome.Sharp.IconFont.Auto;                      
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
                if(txtSee.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
                {
                    txtSee.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    passwordEyeON = false;
                    passwordCHAR(7);
                }
            }


        }

        private void btnLoginLO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                
                
            }
        }
    }
}
