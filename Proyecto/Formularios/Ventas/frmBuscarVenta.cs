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

namespace Proyecto.Formularios.Ventas
{
    public partial class frmBuscarVenta : Form
    {
        public frmBuscarVenta()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBuscarVenta_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscarcompra();
        }

        private void buscarcompra()
        {
            if (txtbusqueda.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el numero de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Venta obj = VentaLogica.Instancia.Obtener(txtbusqueda.Text);

            if (obj != null)
            {
                txtfecharegistro.Text = obj.FechaRegistro;
                txtnumerodocumento.Text = obj.NumeroDocumento;
                txtusuarioregistro.Text = obj.UsuarioRegistro;
                txtdoccliente.Text = obj.DocumentoCliente;
                txtnombrecliente.Text = obj.NombreCliente;

                List<DetalleVenta> olista = VentaLogica.Instancia.ListarDetalle(obj.IdVenta);
                dgvdata.Rows.Clear();
                foreach (DetalleVenta de in olista)
                {
                    dgvdata.Rows.Add(new object[] { de.DescripcionProducto, de.Cantidad, de.PrecioVenta, de.SubTotal });
                }

                lbltotal.Text = obj.MontoTotal;
                lblpagocon.Text = obj.PagoCon;
                lblcambio.Text = obj.Cambio;
            }
            else
            {
                limpiar();
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbusqueda.Select();
            }
        }

        private void limpiar(bool busqueda = false)
        {
            if (busqueda)
                txtbusqueda.Text = "";

            txtnumerodocumento.Text = "";
            txtfecharegistro.Text = "";
            txtusuarioregistro.Text = "";
            txtdoccliente.Text = "";
            txtnombrecliente.Text = "";
            dgvdata.Rows.Clear();
            lbltotal.Text = "0.00";
            lblpagocon.Text = "0.00";
            lblcambio.Text = "0.00";
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
        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
