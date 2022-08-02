﻿using System;
using System.Windows.Forms;

namespace Proyecto.Formularios.Modales
{
    public partial class mdVentaExitosa : Form
    {
        public string _numerodocumento { get; set; }
        public mdVentaExitosa()
        {
            InitializeComponent();
        }

        private void mdVentaExitosa_Load(object sender, EventArgs e)
        {
            txtnumerodocumento.Text = _numerodocumento;
            txtnumerodocumento.Focus();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
