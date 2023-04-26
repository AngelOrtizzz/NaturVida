using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class facturas : Form
    {
        cn_producto producto = new cn_producto();
        cn_Factura factura = new cn_Factura();
        ce_detallefac oce_detfactura = new ce_detallefac();
        ce_factura oce_Factura = new ce_factura();

        public facturas()
        {
            InitializeComponent();
        }
        #region metodos
        public void DGVColumnas()
        {
            dgvFactura.ColumnCount = 6;
            dgvFactura.Columns[0].Name = "#FACTURA";
            dgvFactura.Columns[1].Name = "FECHA";
            dgvFactura.Columns[2].Name = "CLIENTE";
            dgvFactura.Columns[3].Name = "PRODUCTO";
            dgvFactura.Columns[4].Name = "CANTIDAD";
            dgvFactura.Columns[5].Name = "SUBTOTAL";
        }
        public void AGGDatos()
        {
            string[] datos = new string[6];
            datos[0] = txtFactura.Text;
            datos[1] = dtp_FECHA.Value.ToLongDateString();
            datos[2] = cb_cliente.Text;
            datos[3] = cb_producto.Text;
            datos[4] = txtCantidad.Text;
            int valorProducto = Convert.ToInt32(cb_producto.SelectedValue);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int subtotal = valorProducto * cantidad;
            datos[5] = subtotal.ToString();

            dgvFactura.Rows.Add(datos);

            //cb_producto.SelectedIndex = -1;
            //txtCantidad.Clear();
        }

        #endregion
        private void facturas_Load(object sender, EventArgs e)
        {
            DGVColumnas();

            factura.AutoNUMERICO();
            txtFactura.Text = (ce_global.AutoNUM).ToString();

            cb_producto.DataSource = producto.MostrarProd();
            cb_producto.ValueMember = "Valor_Unidad";
            cb_producto.DisplayMember = "Codigo";

            cb_cliente.DataSource = factura.MostarClientes();
            cb_cliente.ValueMember = "Documento";
            cb_cliente.DisplayMember = "Documento";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AGGDatos();
            int total = 0;
            foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                total += Convert.ToInt32(row.Cells["SUBTOTAL"].Value);
            }
            txtTotal.Text = total.ToString();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            oce_Factura.Fecha = Convert.ToDateTime(dtp_FECHA.Text);
            oce_Factura.Documento_Cliente = Convert.ToInt32(cb_cliente.Text);
            oce_Factura.Codigo_Vendedor = ce_global.Codigo;
            oce_detfactura.Numero_Factura = Convert.ToInt32(txtFactura.Text);
            oce_detfactura.Codigo_Productos = Convert.ToInt32(cb_producto.Text);
            oce_detfactura.Cantidad = Convert.ToInt32(txtCantidad.Text);
            ce_global.ValorUnidad = Convert.ToInt32(cb_producto.SelectedValue);
            oce_detfactura.Valor_Unidad = ce_global.ValorUnidad;
            try
            {
                factura.CrearFactura(oce_Factura);

                bandera = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

            if (bandera == true)
            {
                factura.FacturaDetalle(oce_detfactura);
                MessageBox.Show("Factura Exitosa.");
            }
        }

        private void cb_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
