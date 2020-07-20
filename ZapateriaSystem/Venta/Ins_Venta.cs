using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Security.Cryptography.X509Certificates;

namespace ZapateriaSystem.Venta
{
    public partial class Ins_Venta : Form
    {
        Conexion conexion;
        private int state;
        private claseVenta venta;

        public Ins_Venta()
        {
            InitializeComponent();
            venta = new claseVenta();

            conexion = new Conexion();
        }

        /// <summary>
        /// Boton para minimizar
        /// </summary>


        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Boton para maximizar y minimizar
        /// </summary>

        private void button2_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                this.WindowState = FormWindowState.Normal;

                state = 1;
            }
            else
         if (state == 1)
            {
                this.WindowState = FormWindowState.Maximized;
                state = 0;
            }
        }

        /// <summary>
        /// Boton para cierre de la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        /// <summary>
        /// Limpiador de los textbox del formulario insertar venta
        /// </summary>
        private void LimpiarTextoDeDetalle()
        {
            lblNombreProducto.Text = "Nombre del Producto.";
            txtidproducto.Text = "";

            txtprecio.Text = "";
            txtcantidad.Text = "";
            txtdescuento.Text = "";

        }



        /// <summary>
        /// Se generan los detalles de la venta.
        /// </summary>

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            if (Validar() == true)
            {
                btnCancelar.Enabled = true;
                btnPago.Enabled = true;


                if (txtdescuento.Text != "")
                {
                    ///<summary>
                    ///Calculo del descuento
                    /// </summary>
                    double subventa;
                    double descuento;
                    subventa = (Convert.ToDouble(txtprecio.Text) * Convert.ToDouble(txtcantidad.Text));
                    descuento = ((Convert.ToDouble(txtdescuento.Text) / 100) * subventa);

                    venta.IdFactura = Convert.ToInt32(txtidfactura.Text);
                    venta.IdProducto = Convert.ToInt32(txtidproducto.Text);
                    venta.Precio = Convert.ToDouble(txtprecio.Text);
                    venta.Cantidades = Convert.ToInt32(txtcantidad.Text);
                    venta.Descuento = Convert.ToInt32(txtdescuento.Text);
                    venta.Total = Convert.ToDouble(subventa - descuento);
                }
                else
                {
                    //venta.IdVenta = Convert.ToInt32(txtidventa.Text);
                    venta.IdFactura = Convert.ToInt32(txtidfactura.Text);
                    venta.IdProducto = Convert.ToInt32(txtidproducto.Text);
                    venta.Precio = Convert.ToDouble(txtprecio.Text);
                    venta.Cantidades = Convert.ToInt32(txtcantidad.Text);

                    venta.Total = Convert.ToDouble(Convert.ToInt32(txtcantidad.Text) * Convert.ToInt32(txtprecio.Text));
                }

                if (venta.Insertar())
                {

                    DataTable Datos = conexion.consulta(String.Format("SELECT t1.idFactura as 'NumeroDeFactura', t2.NombreProducto as 'Producto', t1.precio as 'Precio', t1.Cantidad, t1.Descuento, t1.Total FROM detalledeventa t1 inner join producto t2  on t1.IdProducto = t2.IdProducto  where idFactura = {0};", venta.IdFactura));
                    dgvVenta.DataSource = Datos;
                    dgvVenta.Refresh();
                    lblTotalVenta.Text = Convert.ToString(conexion.consulta(string.Format("SELECT SUM(Total) from detalledeventa where IdFactura = {0};", Convert.ToInt32(txtidfactura.Text))).Rows[0][0].ToString());
                }
                else
                {
                    MessageBox.Show(string.Format("Error\n{0}", venta.Error.ToString()), "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Se cancelo la edición");
            }
            LimpiarTextoDeDetalle();
        }


        /// <summary>
        /// Validamos que los campos de empleado y cliente no esten vacios,
        /// en este caso ya se dejan 2 por defecto.
        /// </summary>
        /// <returns></returns>
        private Boolean ValidarVenta()
        {
            Boolean validarVenta = true;
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Ingrese un cliente", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                validarVenta = false;
            }
            else if (txtEmpleado.Text == "")
            {
                MessageBox.Show("Ingrese un empleado", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpleado.Focus();
                validarVenta = false;
            }
            else
                validarVenta = true;
            return validarVenta;


        }


        /// <summary>
        /// Valido que ninguno de los campos esten vacios.
        /// </summary>
        /// <returns></returns>

        private Boolean Validar()
        {
            Boolean validar = true;

            if (txtidfactura.Text == "")
            {
                MessageBox.Show("Ingrese el codigo de la factura", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtidfactura.Focus();
                validar = false;
            }
            else if (txtidproducto.Text == "")
            {
                MessageBox.Show("Ingrese el codigo del producto", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtidproducto.Focus();
                validar = false;
            }
            else if (txtprecio.Text == "")
            {
                MessageBox.Show("Ingrese el precio del producto", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtprecio.Focus();
                validar = false;
            }
            else if (txtcantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcantidad.Focus();
                validar = false;
            }

            else
                validar = true;
            return validar;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextoDeDetalle();



        }

        /// <summary>
        /// Aqui genero una factura para poder realizar una venta.
        /// Ojo: Cuando inicio el formulario
        /// </summary>

        private void Ins_Venta_Load(object sender, EventArgs e)
        {
            // panel13.BackColor = Color.FromArgb(90, Color.DarkRed);

            //Botones
            btnCancelar.Enabled = false;
            btnNueva.Enabled = false;
            btnFacturar.Enabled = false;
            btnPago.Enabled = false;

            venta.IdCliente = (Convert.ToString(txtCliente.Text));
            venta.IdEmpleado = (Convert.ToString(txtEmpleado.Text));



            if (venta.NumeroDeFolio())
            {

                txtidfactura.Text = Convert.ToString(venta.IdFactura);

            }
            else
            {
                MessageBox.Show(string.Format("Error\n{0}", venta.Error.ToString()), "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (venta.Eliminar() == true)
            {
                MessageBox.Show("La compra ha sido cancelada", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //venta.IdVenta = Convert.ToInt32(txtidventa.Text);
                LimpiarTextoDeDetalle();

                DataTable Datos = conexion.consulta(String.Format("SELECT t1.idFactura as 'NumeroDeFactura', t2.NombreProducto as 'Producto', t1.precio as 'Precio', t1.Cantidad, t1.Descuento, t1.Total FROM detalledeventa t1 inner join producto t2  on t1.IdProducto = t2.IdProducto  where idFactura = {0};", venta.IdFactura));
                dgvVenta.DataSource = Datos;
                dgvVenta.Refresh();

                //botones
                btnCancelar.Enabled = false;
                btnNueva.Enabled = false;
                btnFacturar.Enabled = false;
                btnPago.Enabled = false;
            }
        }


        /// <summary>
        /// Boton que manda la confirmacion del pago

        private void btnVender_Click(object sender, EventArgs e)
        {
            ValidarVenta();
            
            //btnFacturar.Enabled = true;
            //btnNueva.Enabled = true;
            Pago ventana = new Pago();
            AddOwnedForm(ventana);
            ventana.Show();
        }

        /// <summary>
        /// Cada vez que hay un cambio o se ingresa el id del producto
        /// el label del nombre se actulizara
        /// </summary>

        private void txtidproducto_TextChanged(object sender, EventArgs e)
        {
            if (txtidproducto.Text != "")
            {

                try
                {
                    lblNombreProducto.Text = Convert.ToString(conexion.consulta(string.Format("SELECT  NombreProducto from producto Where IdProducto={0};", Convert.ToInt32(txtidproducto.Text))).Rows[0][0].ToString());
                    txtprecio.Text = Convert.ToString(conexion.consulta(string.Format("SELECT PrecioUnitario from producto Where IdProducto={0};", Convert.ToInt32(txtidproducto.Text))).Rows[0][0].ToString());
                }
                catch (Exception)
                {
                    lblNombreProducto.Text = "No se encuentra.";

                }

            }


        }
        /// <summary>
        /// Habilitacion del txtBox de descuento
        /// </summary>

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtdescuento.Visible = true;
                panel10.Visible = true;
            }
            else
            {
                txtdescuento.Visible = false;
                panel10.Visible = false;
            }
        }


        /// <summary>
        /// Aqui genero una factura para poder realizar una venta.
        /// Ojo: Cuando inicio doy click en el boton nueva.
        /// </summary>

        private void btnNueva_Click(object sender, EventArgs e)
        {
            //Botones visibles
            btnPago.Enabled = false;
            btnCancelar.Enabled = false;
            btnFacturar.Enabled = false;

            //btnPago.Visible = false;
            //btnCancelar.Visible = false;


            venta.IdCliente = (Convert.ToString(txtCliente.Text));
            venta.IdEmpleado = (Convert.ToString(txtEmpleado.Text));

            //Visualizador de datos
            dgvVenta.DataSource = "";

            //Labels con informacion
            lblTotalVenta.Text = "0.00";
            lblTipoDePago.Text = "";
            lblRecibdo.Text = "0.00L";
            lblDevuelto.Text = "0.00L";


            if (venta.NumeroDeFolio())
            {

                txtidfactura.Text = Convert.ToString(venta.IdFactura);
                btnNueva.Enabled = false;
                //btnNueva.Visible = false;
                LimpiarTextoDeDetalle();


                //MessageBox.Show("Se genero una factura.", "venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Format("Error\n{0}", venta.Error.ToString()), "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Proceso de impresion de la factura
        /// </summary>

        //Boton de impresion 
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            /*
            printDocument1 = new PrintDocument();
            PrinterSettings printerSetting = new PrinterSettings();
            printDocument1.PrinterSettings = printerSetting;
            printDocument1.PrintPage += ImprimirFactura;
            printDocument1.Print();
        */
            try
            {
                printDocument1 = new System.Drawing.Printing.PrintDocument();
                PrinterSettings printerSetting = new PrinterSettings();
                printDocument1.PrinterSettings = printerSetting;
                printDocument1.PrintPage += ImprimirFactura;
                printDocument1.Print();
            }
            catch (Exception)
            {

                MessageBox.Show("Revisa que el documento este cerrrado o el codigo si lo tocaste.");
            }



        }

        //Contenido de la impresion 
        private void ImprimirFactura(object sender, PrintPageEventArgs e)
        {
            Font fuente = new Font("Courier New", 12);
            int ancho = 300;
            int y = 20;
            DateTime FechaDeFactura = DateTime.Today;
            StringFormat sf = new StringFormat();
            StringFormat rf = new StringFormat();

            //Para que se aliene el titulo al centro
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            //Alineacion a la derecha
            rf.LineAlignment = StringAlignment.Far;
            rf.Alignment = StringAlignment.Far;

            //y + 20 para que baje
            // Rectangle posicion x - y
            //Los primeros dos son donde empueza y los ultimos donde termina mi margen de 
            //impresion.

            //Impresion del encabezado
            e.Graphics.DrawString("Supreme", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50), sf);
            e.Graphics.DrawString("\n", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("----------------------------", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("#Factura: " + txtidfactura.Text, fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("Fecha: " + FechaDeFactura.ToShortDateString(), fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("\n", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("Cliente: " + txtCliente.Text, fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("Vendedor: " + txtEmpleado.Text, fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            e.Graphics.DrawString("\n", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            //Detalles de la venta
            e.Graphics.DrawString("Can Producto\t     Des Total", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));

            e.Graphics.DrawString("=== ============= === ======", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                e.Graphics.DrawString(Convert.ToString(row.Cells["Cantidad"].Value), fuente, Brushes.Black, new RectangleF(0, y += 20, 30, 50));
                e.Graphics.DrawString(Convert.ToString(row.Cells["Producto"].Value), fuente, Brushes.Black, new RectangleF(40, y, 140, 20));
                e.Graphics.DrawString(Convert.ToString(row.Cells["Descuento"].Value), fuente, Brushes.Black, new RectangleF(190, y, 30, 50));
                e.Graphics.DrawString(Convert.ToString(row.Cells["Total"].Value), fuente, Brushes.Black, new RectangleF(230, y, 70, 50));
                //e.Graphics.DrawString("\n", fuente, Brushes.Black, new RectangleF(0, y, ancho, 50));
            }
            e.Graphics.DrawString("=== ============ === =======", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
            //Final de ticket 

            if (lblTipoDePago.Text == "Contado")
            {
                e.Graphics.DrawString("Tipo de pago: " , fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
                e.Graphics.DrawString(lblTipoDePago.Text, fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
                
                e.Graphics.DrawString("Recibido: " + lblRecibdo.Text, fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50), rf);
                e.Graphics.DrawString("De vuelto: " + lblDevuelto.Text, fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50), rf);
               
                e.Graphics.DrawString("Total: " + lblTotalVenta.Text + "L", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50), rf);
                e.Graphics.DrawString("\n----------------------------", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
                e.Graphics.DrawString("\nGRACIAS POR SU COMPRA", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50), sf);
            }
            else
            {
                //e.Graphics.DrawString("\n", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
                e.Graphics.DrawString("Tipo de pago: ", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
                e.Graphics.DrawString(lblTipoDePago.Text, fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
                e.Graphics.DrawString("Total: " + lblTotalVenta.Text + "L", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50), rf);
                e.Graphics.DrawString("\n----------------------------", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50));
                e.Graphics.DrawString("\nGRACIAS POR SU COMPRA", fuente, Brushes.Black, new RectangleF(0, y += 20, ancho, 50), sf);

            }

        }

       



        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                //MessageBox.Show(Convert.ToString((row.Cells["Cantidad"].Value)));
              //MessageBox.Show(Convert.ToString(row.Cells["Producto"].Value).Length.Substring(0,9));
                //MessageBox.Show(Convert.ToString((row.Cells["Descuento"].Value)));
                //MessageBox.Show(Convert.ToString((row.Cells["Total"].Value)));

            }
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

    




    }
}
