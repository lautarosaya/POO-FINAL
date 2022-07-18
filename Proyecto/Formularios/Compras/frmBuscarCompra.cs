using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Proyecto.Modelo;
using ProyectoVenta.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Formularios.Compras
{
    public partial class frmBuscarCompra : Form
    {
        public frmBuscarCompra()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBuscarCompra_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscarcompra();
        }

        private void buscarcompra() {
            if (txtbusqueda.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el numero de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Compra obj = CompraLogica.Instancia.Obtener(txtbusqueda.Text);

            if (obj != null)
            {
                txtfecharegistro.Text = obj.FechaRegistro;
                txtnumerodocumento.Text = obj.NumeroDocumento;
                txtusuarioregistro.Text = obj.UsuarioRegistro;
                txtdocproveedor.Text = obj.DocumentoProveedor;
                txtnombreproveedor.Text = obj.NombreProveedor;

                List<DetalleCompra> olista = CompraLogica.Instancia.ListarDetalle(obj.IdCompra);
                dgvdata.Rows.Clear();
                foreach (DetalleCompra de in olista)
                {
                    dgvdata.Rows.Add(new object[] { de.DescripcionProducto, de.Cantidad, de.PrecioCompra, de.SubTotal });
                }

                lbltotal.Text = obj.MontoTotal;
            }
            else
            {
                limpiar();
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbusqueda.Select();
            }
        }

        private void limpiar(bool busqueda=false)
        {
            if(busqueda)
                txtbusqueda.Text = "";

            txtnumerodocumento.Text = "";
            txtfecharegistro.Text = "";
            txtusuarioregistro.Text = "";
            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";
            dgvdata.Rows.Clear();
            lbltotal.Text = "0.00";
            txtbusqueda.Select();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            limpiar(true);
        }

        private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buscarcompra();
            }
        }
    }
}
