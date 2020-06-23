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
    public partial class Vender : Form
    {
        Conexion conexion;
        public Vender()
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
            
            if(Validar()==true)
            {
                MessageBox.Show(Convert.ToString(lblCliente.Text));

            
            
                claseVenta venta = new claseVenta();

                venta.IdCliente = Convert.ToString(lblCliente.Text);

                venta.IdEmpleado = Convert.ToString(lblEmpleado.Text);
                venta.IdFactura = Convert.ToInt32(lblIdFactura.Text);
                venta.Total = Convert.ToInt32(lblTotal.Text);
                venta.TipoDePago = Convert.ToString(listTipoDePago.Text);
                //venta.GenerarVenta();
                if (venta.GenerarVenta())
                {
                    MessageBox.Show("Venta realizada.");
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
         
            return validar;
        }

    }

}
