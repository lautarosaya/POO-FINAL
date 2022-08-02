using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Net;
using COMUN;
using System.Text.RegularExpressions;

namespace COMUN.Tests
{

    public class MetodosComunesTests
    {
        public void IniciarCalculadoraTest()
        {
            Process.Start("Calc.exe");
        }
    }
}