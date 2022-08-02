using Proyecto.Formularios.Ventas;
using System;
using System.Windows.Forms;

namespace Proyecto.Intermedios
{
    public partial class IVentas : Form
    {
        public Form FormularioVista { get; set; }
        public string _NombreUsuario { get; set; }
        public IVentas()
        {
            InitializeComponent();
        }

        private void IVentas_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevaventa_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmNuevaVenta(_NombreUsuario);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnbuscarventa_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmBuscarVenta();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnlistaventas_Click(object sender, EventArgs e)
        {
            FormularioVista = new frmListaVentas();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
