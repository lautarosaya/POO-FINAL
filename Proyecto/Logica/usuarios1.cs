using System.Net.Mail;
using System.Text;
namespace Controladora
{
    public class usuarios1
    {
        public int identificador(string usuarios, string contrasena)
        {
            if (usuarios == "admin" && contrasena == "Osonegro123")
            {
                return 1;
            }
            return -1;
        }

        public MailMessage MailVerificar(string usuario_mail, string usuario_nombre, string usuario_apellido, int codigoazar)
        {
            MailMessage correo = new MailMessage();

            correo.To.Add(usuario_mail);
            correo.Subject = "Registro completo con exito";
            correo.SubjectEncoding = Encoding.UTF8;
            correo.Body = "<h2 style='color:#6bf286'>Sanchez Automotores\n</h2>" + "<h1>Sistema de confirmación de correo electronico</h1>\n\n\n" + "<p><b>Su código de verificación es: </b></p>" + codigoazar.ToString() + "<p>\nSí no reconoce está actividad, por favor ignorela.\nGracias.</p>";
            correo.BodyEncoding = Encoding.UTF8;
            correo.IsBodyHtml = true;
            correo.From = new MailAddress("sanchezautomotoroficial@outlook.com");

            return correo;
        }

        public MailMessage Mail_Registro(string usuario_mail, string usuario_nombre, string usuario_apellido, string usuario)
        {
            MailMessage correo = new MailMessage();

            correo.To.Add(usuario_mail);
            correo.Subject = "Registro completo con exito";
            correo.SubjectEncoding = Encoding.UTF8;
            correo.Body = "<h2 style='color:#6bf286'>Sanchez Automotores\n</h2>" + "<h1>¡Su registro fue exitoso!</h1>" + "<p><b>Muchas gracias por confiar en nosotros  </b></p>" + usuario_nombre + " " + usuario_apellido + ", su nombre de usuario es: " + usuario;
            correo.BodyEncoding = Encoding.UTF8;
            correo.IsBodyHtml = true;
            correo.From = new MailAddress("sanchezautomotoroficial@outlook.com");

            return correo;
        }

        public SmtpClient SmtpClient()
        {
            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Credentials = new System.Net.NetworkCredential("sanchezautomotoroficial@outlook.com", "sanchezautomotores1");

            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Host = "smtp.office365.com";

            return smtpClient;
        }


    }





}
