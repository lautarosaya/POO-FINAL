using COMUN;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace vista.Login
{
    public partial class CodigoConfirmacion : Form
    {
        //Developed by Javier Ramírez//

        public CodigoConfirmacion(int codigoazar, string usuario, string mail)
        {
            InitializeComponent();
            CodigoAzar = codigoazar;
            Usuario = usuario;
            Mail = mail;
        }
        int CodigoAzar;
        string Usuario, Mail;
        bool confirmacion = false;

        //DRAG MOVE, Mover formulario con panel// //Código Descarte, por la dudas se guarda para futuras actualizaciones//
        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]

        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //Fin del código mover (drag)//


        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosComunes.KeyPressSoloNumeros(e);
            //Aquí usamos los tabIndex como identificadores//
            TextBox a = new TextBox();
            a = sender as TextBox;
            identificadorText(a, e);

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            string codigo = txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text;
            if (codigo == CodigoAzar.ToString())
            {
                confirmacion = true;
                this.Close();
            }
            else
            {
                confirmacion = false;
            }

        }

#pragma warning disable IDE1006 // Estilos de nombres
        private void pnlLabel_MouseDown(object sender, MouseEventArgs e)
#pragma warning restore IDE1006 // Estilos de nombres
        {
            if (e.Button == MouseButtons.Left)

            {

                ReleaseCapture();

                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void CodigoConfirmacion_Load(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            lblMail.Text = lblMail.Text + ": " + Mail;
            lblUsuario.Text = lblUsuario.Text + ": " + Usuario;
            ICOBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 177, 136);
            ICOBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 177, 136);
        }



        public void identificadorText(TextBox a, KeyPressEventArgs e)
        {
            switch (a.TabIndex)
            {
                case 0:
                    if (char.IsNumber(e.KeyChar))
                    {
                        SendKeys.Send("{TAB}");
                    }
                    break;
                case 1:
                    if (char.IsNumber(e.KeyChar))
                    {
                        SendKeys.Send("{TAB}");
                    }
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        SendKeys.Send("+{TAB}");
                    }
                    break;
                case 2:
                    if (char.IsNumber(e.KeyChar))
                    {
                        SendKeys.Send("{TAB}");
                    }
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        SendKeys.Send("+{TAB}");
                    }
                    break;
                case 3:
                    if (char.IsNumber(e.KeyChar))
                    {
                        SendKeys.Send("{TAB}");
                    }
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        SendKeys.Send("+{TAB}");
                    }
                    break;
                case 4:
                    if (e.KeyChar == (char)Keys.Back)
                    {
                        SendKeys.Send("+{TAB}");
                    }
                    break;
            }
        }

        private void ICOBack_MouseEnter(object sender, EventArgs e)
        {
            ICOBack.IconColor = Color.Yellow;
        }

        private void ICOBack_MouseLeave(object sender, EventArgs e)
        {
            ICOBack.IconColor = Color.PaleGoldenrod;
        }

        private void ICOBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Confirmacion()
        {
            return confirmacion;
        }
    }
}
