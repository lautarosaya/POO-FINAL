using ClosedXML.Excel;
using Proyecto.Herrarmientas;
using Proyecto.Modelo;
using ProyectoVenta.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Formularios.Compras
{
    public partial class frmListaCompras : Form
    {
        public frmListaCompras()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaCompras_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn cl in dgvdata.Columns)
            {
                if (cl.Visible == true && cl.Name != "btnseleccionar")
                {
                    cbobuscar.Items.Add(new OpcionCombo() { Valor = cl.Name, Texto = cl.HeaderText });
                }
            }
            cbobuscar.DisplayMember = "Texto";
            cbobuscar.ValueMember = "Valor";
            cbobuscar.SelectedIndex = 0;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dgvdata.Rows.Clear();

            DateTime dt1 = Convert.ToDateTime(txtfechainicio.Value.ToString("dd/MM/yyyy"));
            DateTime dt2 = Convert.ToDateTime(txtfechafin.Value.ToString("dd/MM/yyyy"));
            List<VistaCompra> lista = CompraLogica.Instancia.Resumen(dt1.ToString("yyyy-MM-dd", new CultureInfo("en-US")), dt2.ToString("yyyy-MM-dd", new CultureInfo("en-US")));

            foreach (VistaCompra vr in lista)
            {

                dgvdata.Rows.Add(new object[] {
                    vr.FechaRegistro,
                    vr.NumeroDocumento,
                    vr.UsuarioRegistro,
                    vr.NombreProveedor,
                    vr.MontoTotal,
                    vr.CodigoProducto,
                    vr.DescripcionProducto,
                    vr.CategoriaProducto,
                    vr.MedidaProducto,
                    vr.PrecioVenta,
                    vr.PrecioCompra,
                    vr.Cantidad,
                    vr.SubTotal
                });
            }
        }

        private void btnbusqueda_Click(object sender, EventArgs e)
        {

            string columnaFiltro = ((OpcionCombo)cbobuscar.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar.Text.ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
