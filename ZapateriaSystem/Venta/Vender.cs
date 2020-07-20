using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapateriaSystem.Venta
{
    public partial class Pago : Form
    {
        Conexion conexion;
        private int click;
        public Pago()
        {
            InitializeComponent();
            conexion = new Conexion();
            claseVenta venta = new claseVenta();



        }

        private void Vender_Load(object sender, EventArgs e)
        {
            lblCliente.Text = Convert.ToString(conexion.consulta(string.Format("select  idCliente from detalledeventa t1 INNER JOIN factura t2 Where t1.idFactura = t2.idFactura order by iddetalledeventa desc limit 1 ;")).Rows[0][0].ToString());
            lblEmpleado.Text = Convert.ToString(conexion.consulta(string.Format("select  idEmpleado from detalledeventa t1 INNER JOIN factura t2 Where t1.idFactura = t2.idFactura order by iddetalledeventa desc limit 1 ;")).Rows[0][0].ToString());
            lblIdFactura.Text = Convert.ToString(conexion.consulta(string.Format("select  t1.idFactura from detalledeventa t1 INNER JOIN factura t2 Where t1.idFactura = t2.idFactura order by iddetalledeventa desc limit 1 ;")).Rows[0][0].ToString());
            
            lblTotal.Text = Convert.ToString(conexion.consulta(string.Format("SELECT SUM(Total) from detalledeventa where IdFactura = {0};",Convert.ToInt32(lblIdFactura.Text))).Rows[0][0].ToString());

            //lblCliente.da
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (Validar()==true)
            {
                      
            
                claseVenta venta = new claseVenta();

                venta.IdCliente = Convert.ToString(lblCliente.Text);

                venta.IdEmpleado = Convert.ToString(lblEmpleado.Text);
                venta.IdFactura = Convert.ToInt32(lblIdFactura.Text);
                venta.Total = Convert.ToDouble(lblTotal.Text);
                venta.TipoDePago = Convert.ToString(listTipoDePago.Text);
                //venta.GenerarVenta();

                if (venta.GenerarVenta())
                {
                    //Instancio mi ventana padre
                    Ins_Venta m = Owner as Ins_Venta;

                    //Habilitar botones de padre
                    m.btnFacturar.Enabled = true;
                    m.btnNueva.Enabled = true;

                    //Compartir datos al formulario de punto de venta

                    string send;
                    
                   
                    if (txtCapital.Text != "" && txtVuelto.Text != "")
                    {
                        //Capital
                        send = txtCapital.Text;
                         m.lblRecibdo.Text = send+"L";

                        //Vuelto
                        send = txtVuelto.Text;
                        m.lblDevuelto.Text = send + "L";
                    }
                    
                    //Tipo de pago
                    send = listTipoDePago.Text;
                    m.lblTipoDePago.Text = send ;


                    MessageBox.Show("Venta realizada.");

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error al guardar.");
                }
                
            }
            
        }
        
        private Boolean Validar()
        {
            Boolean validar = true;
            if (click == 0)
            {
                //MessageBox.Show(Convert.ToString(Click));
                MessageBox.Show("Debes seleccionar un item de la lista.");
                return false;
            }

            return validar;
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void listTipoDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(listTipoDePago.Text) == "Contado")
                {
                txtCapital.Visible = true;
                lblCapital.Visible = true;

                lblVuelto.Visible = true;
                txtVuelto.Visible = true;

                }

            if (Convert.ToString(listTipoDePago.Text) == "Tarjeta")
            {
                txtCapital.Visible = false;
                lblCapital.Visible = false; 

                lblVuelto.Visible = false;
                txtVuelto.Visible = false;

            }


        }

        private void txtCapital_TextChanged(object sender, EventArgs e)
        {
            try
            {
                        if (txtCapital.Text != "")
                        {
                            double capital = Convert.ToDouble(txtCapital.Text);
                            double monto = Convert.ToDouble(lblTotal.Text);
                            double vuelto = 0;


                            vuelto = monto - capital;
                            if (vuelto <= -1)
                            {
                                vuelto = vuelto * -1;
                                txtVuelto.Text = Convert.ToString(vuelto);

                                
                            }
                            else
                            {
                                txtVuelto.Text = Convert.ToString(vuelto);
                            }
                        }
            }
            catch (Exception)
            {

                txtVuelto.Text = "0";
            }
            

        }

        private void listTipoDePago_Click(object sender, EventArgs e)
        {
            click=1;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }

}
