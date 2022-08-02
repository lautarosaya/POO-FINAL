using System;
using System.Windows.Forms;

namespace Proyecto.Formularios.Modales
{
    public partial class mdCompraExitosa : Form
    {
        public string _numerodocumento { get; set; }
        public mdCompraExitosa()
        {
            InitializeComponent();
        }

        private void mdCompraExitosa_Load(object sender, EventArgs e)
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
