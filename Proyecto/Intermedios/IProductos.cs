﻿using Proyecto.Formularios.Productos;
using System;
using System.Windows.Forms;

namespace Proyecto.Intermedios
{
    public partial class IProductos : Form
    {
        public Form FormularioVista { get; set; }
        public string _NombreUsuario { get; set; }
        public IProductos()
        {
            InitializeComponent();
        }

        private void IProductos_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevaproducto_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmProductos();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
