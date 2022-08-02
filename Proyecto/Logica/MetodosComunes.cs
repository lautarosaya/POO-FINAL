using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace COMUN
{
    static public class MetodosComunes
    {

        static public KeyPressEventArgs KeyPressPuntoyComa(KeyPressEventArgs e, string TEXTO)
        {

            if (e.KeyChar.ToString() == "." || e.KeyChar.ToString() == ",")
            {
                //si el texto ya contiene coma no lo pone
                if (TEXTO.Contains(",") == false && TEXTO.Length != 0)
                {
                    e.KeyChar = Convert.ToChar(",");
                }
                else
                {
                    //hace que no ponga nada
                    e.Handled = true;
                }

            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            return e;
        }

        static public KeyPressEventArgs KeyPressSiempreComa(KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "." || e.KeyChar.ToString() == ",")
            {
                e.KeyChar = Convert.ToChar(",");
            }
            return e;
        }

        static public KeyPressEventArgs KeyPressSoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            return e;
        }

        static public KeyPressEventArgs KeyPressNumerosIonMedio(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "-" || e.KeyChar.ToString() == "/")
            {
                if (e.KeyChar.ToString() == "-")
                {
                    e.KeyChar = Convert.ToChar("-");
                }
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            return e;
        }

        static public string FechaSola(DateTime fechaHora)
        {
            string dia = "";
            string mes = "";
            string año = fechaHora.Year.ToString();

            if (fechaHora.Month < 10)
            {
                mes = 0 + fechaHora.Month.ToString();
            }
            else
            {
                mes = fechaHora.Month.ToString();
            }

            if (fechaHora.Day < 10)
            {
                dia = 0 + fechaHora.Day.ToString();
            }
            else
            {
                dia = fechaHora.Day.ToString();
            }

            string fecha = dia + "/" + mes + "/" + año;

            return fecha;

        }

        static public string LeerMacAddress()
        {
            NetworkInterface[] nets = NetworkInterface.GetAllNetworkInterfaces();
            string mac = "";
            foreach (NetworkInterface adapter in nets)
            {
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    PhysicalAddress address = adapter.GetPhysicalAddress();
                    byte[] bytes = address.GetAddressBytes();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        mac += bytes[i].ToString("X2");
                        if (i != bytes.Length - 1)
                        {
                            mac += "-";
                        }
                    }
                }
            }
            return mac;
        }

        public static string Encriptar(string passVista)
        {
            string passEncriptado = string.Empty;
            SHA512 sha512 = SHA512.Create();

            UTF8Encoding encoding = new UTF8Encoding();

            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha512.ComputeHash(encoding.GetBytes(passVista));

            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x1}", stream[i]);
            }

            return passEncriptado = sb.ToString();
        }

        /// Encripta una cadena
        public static string EncriptarPassBD(string cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptarPassBD(string cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        public static string RetornaSoloNumeros(string codigoBarra)
        {
            codigoBarra = Regex.Replace(codigoBarra, @"([^0-9])", "");
            return codigoBarra;
        }

        public static string RetornaSoloLetras(string codigoBarra)
        {
            codigoBarra = Regex.Replace(codigoBarra, @"([^a-zA-Z])", "");
            return codigoBarra;
        }

        public static void IniciarCalculadora()
        {
            Process.Start("Calc.exe");
        }

        //comprueba si un codigo de barras es correcto para EAN
        public static bool ComprobarEAN(String ean)
        {
            //empezamos suponiendo que el codigo no
            //es correcto
            bool resultado = false;
            //Sólo comprobabos si la cadena está formada por
            //dígitos y su longitud es 8 o 13
            //if (EsSoloNumeros(ean) && (ean.Length == 8 || ean.Length == 13))
            if (EsSoloNumeros(ean) && (ean.Length == 13))
            {
                //Sumaremos los lugares pares por un lado y los
                //impares por otro
                int pares = 0;
                int impares = 0;
                //Recorrer toda la cadena excluyendo el último lugar
                for (int i = 0; i <= (ean.Length - 2); i++)
                {
                    if (i % 2 == 0) //Si lugar impar (empezamos por 0)
                        impares += int.Parse(ean.Substring(i, 1));
                    else
                        pares += int.Parse(ean.Substring(i, 1));
                }
                //En EAN13, los pares se multiplican por 3
                //En EAN8, son los impares
                if (ean.Length == 13)
                    pares *= 3;
                else
                    impares *= 3;
                int checksum = pares + impares;
                int digitoControl = 10 - (checksum % 10);
                //Si el digito de control es 10, entendemos 0
                if (digitoControl == 10)
                    digitoControl = 0;
                //Comprobar que el digito de control obtenido y el
                //de la cadena ean sean el mismo.
                resultado = (digitoControl ==
                            int.Parse(ean.Substring(ean.Length - 1, 1)));
            }
            return resultado;
        }

        //Método auxiliar para comprobar que una
        //cadena está formada sólo por dígitos
        public static bool EsSoloNumeros(String s)
        {
            bool resultado = true;
            int contador = 0;
            while (resultado && contador < s.Length)
            {
                resultado = resultado && (s[contador] >= '0' && s[contador] <= '9');
                contador++;
            }
            return resultado;
        }

        static public KeyPressEventArgs KeyPressSoloLetras(KeyPressEventArgs e, string TEXTO)
        {

            if (Char.IsLetter(e.KeyChar))//solo letras
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))//solo backspace, space, delete, etc.
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))// solo .:;,_- (simbolos de punt
            {
                e.Handled = false;
            }
            else if (Char.IsSymbol(e.KeyChar))//demas caracteres
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))//espacio
            {
                e.Handled = false;
            }
            else//que el resto no lo escriba
            {
                e.Handled = true;
            }
            return e;
        }

        static public bool ValidacionEMAIL(EventArgs e, string Mail)//validacion formato de direccion de e-mail
        {

            Regex mRegxExpression;

            if (Mail.Trim() != string.Empty)
            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(Mail.Trim()))
                {
                    //no es correcta
                    return false;
                }
                else
                {
                    //es correcta
                    return true;
                }

            }
            else
            {
                //no es correcta, esta vacia
                return false;
            }

        }

        static public bool ValidacionPASSWORD(string pass)//validacion formato de password
        {

            string password = pass;
            Regex len = new Regex("^.{6,15}$");
            Regex num = new Regex("\\d");
            Regex alpha = new Regex("\\D");

            if (len.IsMatch(password) && num.IsMatch(password) && alpha.IsMatch(password))
            {
                //Password Válido
                return true;
            }
            else
            {
                //Password Inválido
                return false;
            }

        }

        static public bool ValidacionPASSWORD2(string pass)//validacion formato de password
        {
            Regex Val = new Regex(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$");
            if (Val.IsMatch(pass))
            {
                //Password Válido
                return true;
            }
            else
            {
                //Password Inválido
                return false;
            }
        }

        static public bool ValidacionWWW(string web)//validacion formato de direccion web
        {

            Regex mRegxExpression;

            if (web.Trim() != string.Empty)
            {

                mRegxExpression = new Regex(@"\A[w]{3}(\.)[a-z0-9]+(\.)(com|net|info|org|edu|gob)\Z");

                if (!mRegxExpression.IsMatch(web.Trim()))
                {
                    //Direccion web incorrecta
                    return false;
                }
                else
                {
                    //Direccion Correcta
                    return true;
                }
            }
            else
            {
                //Direccion web incorrecta o vacia
                return false;
            }

        }

        static public bool ValidaURL(string url)
        {
            Uri uri = null;
            if (!Uri.TryCreate(url, UriKind.Absolute, out uri) || null == uri)
            {
                //URL incorrecta
                return false;
            }
            else
            {
                //URL Correcta
                return true;
            }
        }

        static public bool ValidaEdad(DateTime fechaNacimiento, int mayorA)
        {
            DateTime fecha = fechaNacimiento;
            DateTime fechaActual = DateTime.Parse(DateTime.Now.Date.ToShortDateString());

            int edad = fechaActual.Year - fecha.Year;

            if (edad >= mayorA)
            {
                //El usuario es mayor a la edad enviada
                return true;
            }
            else
            {
                //El usuario es menor a la edad enviada
                return false;
            }
        }

        static public bool ValidaDNI(string dni)
        {

            if (Regex.Match(dni, @"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z]$").Success == true)
            {
                //dni correcto
                return true;
            }
            else
            {
                //dni incorrecto
                return false;
            }
        }

        static public bool ValidatarjetaCredito(string tarjeta)
        {
            Regex Val = new Regex(@"^((67\d{2})|(4\d{3})|(5[1-5]\d{2})|(6011))(-?\s?\d{4}){3}|(3[4,7])\ d{2}-?\s?\d{6}-?\s?\d{5}$");
            if (Val.IsMatch(tarjeta))
            {
                //Tarjeta de credito Valida
                return true;
            }
            else
            {
                //Tarjeta de credito no valida
                return false;
            }
        }

        static public bool IsValidIp(string addr)
        {
            IPAddress ip;
            bool valid = !string.IsNullOrEmpty(addr) && IPAddress.TryParse(addr, out ip);
            return valid;
        }

        public static bool ValidaCuit(string cuit)
        {
            if (cuit == null)
            {
                return false;
            }
            //Quito los guiones, el cuit resultante debe tener 11 caracteres.
            cuit = cuit.Replace("-", string.Empty);
            if (cuit.Length != 11)
            {
                return false;
            }
            else
            {
                int calculado = CalcularDigitoCuit(cuit);
                int digito = int.Parse(cuit.Substring(10));
                return calculado == digito;
            }
        }

        public static int CalcularDigitoCuit(string cuit)
        {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;
            for (int i = 0; i < mult.Length; i++)
            {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }
            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }

        public static bool ValidaClavesIguales(string pass, string comprovacion)
        {
            if (pass == comprovacion)
            {
                //pass iguales
                return true;
            }
            else
            {
                //pas distintas
                return false;
            }
        }

        static public bool ValidaCodigoPostal(string cp)
        {
            Regex Val = new Regex(@"^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$");
            if (Val.IsMatch(cp))
            {
                //Codigo Postal correcto
                return true;
            }
            else
            {
                //Codigo postal incorrecto
                return false;
            }
        }

        static public bool ValidaNroTelefono(string telefono)
        {
            // NUMERO TELEFONO AUSTRALIANO
            Regex re = new Regex(@"^\(\d{2}\) \d{4} \d{4}$");
            if (!re.IsMatch(telefono))
            {
                //error "Debe ser (xx) xxxx xxxx"
                return false;
            }
            else
            {
                // NUMERO DE TELEFONO VALIDO 
                return true;
            }
        }

        #region LOG

        static public void RegistrarLog(string mensaje, string especificacion, string ruta)
        {

            string PATHLOG = @"C:\LogEjemplo\";
            string ARCHIVOLOG = "ArchivoLog" + Devuelveaaaammdd() + ".txt";

            StreamWriter sw;
            string pathCompleto = PATHLOG + @"\" + ARCHIVOLOG;
            var dirInfo = new DirectoryInfo(PATHLOG);
            if (!dirInfo.Exists)
            {
                Directory.CreateDirectory(PATHLOG);
            }

            if (File.Exists(pathCompleto))
            {
                sw = File.AppendText(pathCompleto);
            }
            else
            {
                sw = File.CreateText(pathCompleto);
            }
            sw.WriteLine("-------------------------------------------------------------------------------");
            sw.WriteLine("Se ha producido un error. " + DateTime.Now.ToString());
            sw.WriteLine("-------------------------------------------------------------------------------");
            sw.WriteLine("");
            sw.WriteLine("MENSAJE: " + mensaje);
            sw.WriteLine("ESPECIFICACION: " + especificacion);
            sw.WriteLine("RUTA: " + ruta);
            sw.Close();


            System.Text.StringBuilder CuerpoMail = new System.Text.StringBuilder();
            CuerpoMail.AppendLine("-------------------------------------------------------------------------------");
            CuerpoMail.AppendLine("Se ha producido un error. " + DateTime.Now.ToString());
            CuerpoMail.AppendLine("-------------------------------------------------------------------------------");
            CuerpoMail.AppendLine("");
            CuerpoMail.AppendLine("MENSAJE: " + mensaje);
            CuerpoMail.AppendLine("ESPECIFICACION: " + especificacion);
            CuerpoMail.AppendLine("RUTA: " + ruta);


            EnviarMail(CuerpoMail, "ERROR");
        }

        private static int Devuelveaaaammdd()
        {
            string aaaammddhhmmss = "";
            DateTime FechaNow = DateTime.Now;
            aaaammddhhmmss = FechaNow.ToString("yyyyMMdd");

            return Convert.ToInt32(aaaammddhhmmss);
        }

        #endregion

        #region MAIL

        public static bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public static void EnviarMail(StringBuilder CuerpoMail, string TIPO)
        {
            try
            {
                SmtpClient server = new SmtpClient("smtp.gmail.com", 587);

                server.Credentials = new System.Net.NetworkCredential("xxx@gmail.com", "xxxx");
                server.EnableSsl = true;
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                MailMessage correoElectronico = new MailMessage();

                string mailTo = "";
                string mailTo2 = "";
                switch (TIPO)
                {
                    case "ERROR": mailTo = "xxx@gmail.com"; mailTo2 = "xxx@gmail.com"; break;// a quien se lo envia. el para
                    case "EXITO": mailTo = "xxx@gmail.com"; mailTo2 = "xxx@gmail.com"; break;// a quien se lo envia. el para
                    case "ADVERTENCIA": mailTo = "xxx@gmail.com"; mailTo2 = "xxx@gmail.com"; break;// a quien se lo envia. el para
                    default:
                        break;
                }

                correoElectronico.Subject = "LOG: ";

                correoElectronico.To.Add(new MailAddress(mailTo));
                if (mailTo2 != "") correoElectronico.To.Add(new MailAddress(mailTo2));



                correoElectronico.From = new MailAddress("xxx@gmail.com.ar", "Supermercado");

                ///* Si deseamos Adjuntar algún archivo*/
                //correoElectronico.Attachments.Add(new Attachment(@ruta));

                CuerpoMail.AppendLine("-------------------------------------------------------------------------------");
                CuerpoMail.AppendLine("Enviado desde xxx@gmail.com.ar");
                CuerpoMail.AppendLine("-------------------------------------------------------------------------------");
                correoElectronico.Body = CuerpoMail.ToString();

                /* Enviar - MandarCorreo()*/
                server.Send(correoElectronico);

                //MessageBox.Show("El Mail se ha Enviado Correctamente", "Listo!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            catch (Exception)
            {
                return;
            }
        }

        public static bool funConexion()
        {
            System.Net.HttpWebRequest req;

            System.Net.HttpWebResponse res;

            try
            {
                req = (System.Net.HttpWebRequest)
                //probar con destelnorte.com.ar
                System.Net.WebRequest.Create(@"http://google.com ");

                res = (System.Net.HttpWebResponse)req.GetResponse();

                req.Abort();

                if (res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch// (System.Net.WebException e) 
            {
                return false;
            }
        }

        #endregion
    }
}
