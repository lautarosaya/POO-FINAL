using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using COMUN;

namespace vista.Login
{
    public partial class Registro : Form
    {
        //Developed by Javier Ramírez//
        public Registro(Point a)
        {
            InitializeComponent();
            location = a;
        }
        Point location,newlocation;
        char passwordchar;
        bool passwordEyeON = false;
        EventArgs v;
        //varText//
        string Nombretxt = "Nombre";
        string Apellidotxt = "Apellido";
        string Usuariotxt = "Nombre de Usuario";
        string Correotxt = "Correo Electronico";
        // // // // // // // // // // // // // //
        //Colores Set//
        Color pctOn = Color.FromArgb(65, 168, 95);
        Color pctOff = Color.DarkGray;
        // // // // // // // // // // // // // //

        private void pctBackRE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {           
            placeholder(txtUsuario,1,Usuariotxt);
            pctLineDecoration(pctUsuario, 1);

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            placeholder(txtUsuario,2,Usuariotxt);
            pctLineDecoration(pctUsuario, 2);
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                passwordCHAR(1);
            }
            if (txtContraseña.Text != String.Empty && passwordEyeON == false)
            {
                passwordCHAR(3);
                passwordCHAR(7);
            }
            if (txtContraseña.Text != String.Empty && passwordEyeON == true)
            {
                passwordCHAR(3);
                passwordCHAR(6);
            }

            pctLineDecoration(pctContraseña, 1);
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != String.Empty)
            {
                if (txtContraseña.ForeColor == Color.Silver)
                {
                    passwordCHAR(4);
                }
                else
                {
                    passwordCHAR(3);
                }
            }
            if(txtContraseña.Text != "Contraseña" && txtContraseña.ForeColor != Color.Silver)
            {
                if (COMUN.MetodosComunes.ValidacionPASSWORD(txtContraseña.Text))
                {
                    pctLineDecoration(pctContraseña, 1);
                }
                else
                {
                    pctLineDecoration(pctContraseña, 3);
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
            pctLineDecoration(pctContraseña, 2);
        }
            
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            placeholder(txtApellido, 1, Apellidotxt);
            pctLineDecoration(pctApellido, 1);
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            placeholder(txtApellido, 2, Apellidotxt);
            pctLineDecoration(pctApellido, 2);
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            placeholder(txtNombre, 1, Nombretxt);
            pctLineDecoration(pctNombre, 1);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            placeholder(txtNombre,2, Nombretxt);
            pctLineDecoration(pctNombre, 2);
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            placeholder(txtMail,1,Correotxt);
            pctLineDecoration(pctCorreo, 1);
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            placeholder(txtMail, 2, Correotxt);
            pctLineDecoration(pctCorreo, 2);
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

        public void pctLineDecoration(PictureBox a, int caso)
        {
            //Esta función la uso para las lineas de color verde y gris, una decoración bastante moderna//
            //Caso 1 significa que el usuario entro al TextBox y Caso 2 Significa que el usuario salió del TextBox//
            switch (caso)
            {
                case 1:
                    int i = a.Size.Width;
                    a.Size = new Size(i, 24);
                    a.BackColor = pctOn;
                    break;

                case 2:
                    int j = a.Size.Width;
                    a.Size = new Size(j, 23);
                    a.BackColor = pctOff;
                    break;
                case 3:
                    int k = a.Size.Width;
                    a.Size = new Size(k, 24);
                    a.BackColor = Color.Red;
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginLO_Click(object sender, EventArgs e)
        {
            
            Controladora.usuarios1 controladora = new Controladora.usuarios1();
            //Envio de Mail, utilizando mail Corporativo de nuestra empresa//
            //Variables mail, nombre, apellido//
            bool Nombre = Revisar(txtNombre);
            bool Apellido = Revisar(txtApellido);
            bool Usuario = Revisar(txtUsuario);
            bool Contraseña = Revisar(txtContraseña);
            bool Correo = Revisar(txtMail);

            if (Nombre && Apellido && Usuario && Contraseña && Correo)
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string mail = txtMail.Text;
                string usuario = txtUsuario.Text;
                Random r = new Random();
                int codigoVER = r.Next(10000, 99999);               
                CodigoConfirmacion formConfirmacion = new CodigoConfirmacion(codigoVER,usuario,mail);
                try
                {
                    SmtpClient cliente = controladora.SmtpClient();

                    MailMessage correo = controladora.MailVerificar(mail, nombre, apellido, codigoVER);

                    cliente.Send(correo);
                }
                catch (Exception ex)
                {
                    DialogResult dialog = MessageBox.Show(ex.Message, "Se produjo un error al enviar el código de verificación, por favor revisar si escribio bien su correo electronico.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                formConfirmacion.ShowDialog();
                //La función Confirmacion() sirve para saber si el usuario ingreso el codigo correcto
                
                if (formConfirmacion.Confirmacion())
                {
                    try
                    {
                        SmtpClient cliente = controladora.SmtpClient();

                        MailMessage correo = controladora.Mail_Registro(mail, nombre, apellido, usuario);
                        cliente.Send(correo);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        DialogResult dialog = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, corregir los errores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txtSee_MouseEnter(object sender, EventArgs e)
        {
            txtSee.IconFont = FontAwesome.Sharp.IconFont.Solid;
        }

        private void txtSee_MouseLeave(object sender, EventArgs e)
        {
            txtSee.IconFont = FontAwesome.Sharp.IconFont.Regular;
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
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            txtSee.Visible = false;
            this.Location = location;
        }

        private void Registro_LocationChanged(object sender, EventArgs e)
        {
            newlocation = this.Location;
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            v = e;
            if(txtMail.Text != Correotxt && txtMail.ForeColor != Color.Silver)
            {
                if (COMUN.MetodosComunes.ValidacionEMAIL(e, txtMail.Text))
                {
                    pctLineDecoration(pctCorreo, 1);
                }
                else
                {
                    pctLineDecoration(pctCorreo, 3);
                }
            }
        }

        public Point locationchanged()
        {
            return newlocation;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != Usuariotxt && txtUsuario.ForeColor != Color.Silver)
            {
                if (COMUN.MetodosComunes.ValidacionPASSWORD(txtUsuario.Text))
                {
                    pctLineDecoration(pctUsuario, 1);
                }
                else
                {
                    pctLineDecoration(pctUsuario, 3);
                }

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosComunes.KeyPressSoloLetras(e, "s");
        }

        private void btnRegistrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Controladora.usuarios1 usuarios = new Controladora.usuarios1();
                switch (usuarios.identificador(txtUsuario.Text, txtContraseña.Text))
                {
                    
                }
            }
        }

        public bool Revisar(TextBox a)
        {
            //Aquí para automatizar el programa, utilizamos los TabsIndex de nuestro TextBox//
             //Entonces esto nos permite identificar cada TextBox//
            switch (a.TabIndex)
            {
                case 0:
                    if(a.Text != Nombretxt && a.ForeColor != Color.Silver)
                    {
                        return true;
                    }
                    else
                    {
                        pctLineDecoration(pctNombre, 3);
                        return false;
                    }
                    break;
                case 1:
                    if (a.Text != Apellidotxt && a.ForeColor != Color.Silver)
                    {
                        return true;
                    }
                    else
                    {
                        pctLineDecoration(pctApellido, 3);
                        return false;
                    }
                    break;
                case 2:
                    if (a.Text != Usuariotxt && a.ForeColor != Color.Silver)
                    {
                        if (COMUN.MetodosComunes.ValidacionPASSWORD(a.Text))
                        {                      
                            return true;
                        }
                        else
                        {
                            pctLineDecoration(pctUsuario, 3);
                            return false;
                        }
                    }
                    else
                    {
                        pctLineDecoration(pctUsuario, 3);
                        return false;
                    }
                    break;
                case 3:
                    if (a.Text != "Contraseña" && a.ForeColor != Color.Silver)
                    {
                        if (COMUN.MetodosComunes.ValidacionPASSWORD(a.Text))
                        {
                            return true;
                        }
                        else
                        {
                            pctLineDecoration(pctContraseña, 3);
                            return false;
                        }
                    }
                    else
                    {
                        pctLineDecoration(pctContraseña, 3);
                        return false;
                    }
                    break;
                case 4:
                    if (a.Text != Correotxt && a.ForeColor != Color.Silver)
                    {
                        
                        if (COMUN.MetodosComunes.ValidacionEMAIL(v,a.Text))
                        {
                        return true;
                        }
                        else
                        {
                            pctLineDecoration(pctCorreo, 3);
                            return false;
                        }
                    }
                    else
                    {
                        pctLineDecoration(pctCorreo, 3);
                        return false;
                    }
                    break;
                default:
                    MessageBox.Show("Error");
                    return false;
                    break;
            }
            return false;
        }
    }
}
/*
try
{
    SmtpClient cliente = controladora.SmtpClient();

    MailMessage correo = controladora.Mail_Registro(mail, nombre, apellido);

    cliente.Send(correo);
}
catch (Exception ex)
{
    DialogResult dialog = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

}
*/