using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZapateriaSystem.Cliente;
using ZapateriaSystem.Empleado;
using ZapateriaSystem.Producto_General;

using ZapateriaSystem.Proveedor;
using ZapateriaSystem.Venta;


namespace ZapateriaSystem
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            MdiClient oMDI;

            //recorremos todos los controles hijos del formulario
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Intentamos castear el objeto MdiClient
                    oMDI = (MdiClient)ctl;

                    // Cuando sea casteado con éxito, podremos cambiar el color así
                    oMDI.BackColor = Color.White;
                }
                catch (InvalidCastException )
                {
                    // No hacemos nada cuando el control no sea tupo MdiClient
                }
            }

        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString() +" "+ DateTime.Now.ToShortTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ins_Empleado ventana = new Ins_Empleado();
            ventana.MdiParent = this;
            ventana.Show();
        }


        private void VerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Viw_Empleado ventana = new Viw_Empleado();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void actulizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Act_Empleado ventana = new Act_Empleado();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void insertarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            Ins_Venta ventana = new Ins_Venta();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void VisualizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viw_Venta ventana = new Viw_Venta();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void perfilesDeInstaramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void insertarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Ins_Cliente ventana = new Ins_Cliente();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void actulizarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Act_Cliente ventana = new Act_Cliente();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ver_Datos_Cliente ventana = new Ver_Datos_Cliente();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ver_PerfilInstagram ventana = new Ver_PerfilInstagram();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void insertarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ins_ProductoGeneral ventana = new Ins_ProductoGeneral();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void actulizarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Act_ProductoGeneral ventana = new Act_ProductoGeneral();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void listaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_ProductoGeneral ventana = new View_ProductoGeneral();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void insertarProveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ins_Proveedor ventana = new Ins_Proveedor();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void actulizarProveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Act_Proveedor ventana = new Act_Proveedor();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void listaProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProveedor ventana = new ViewProveedor();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void ClienteToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            ClienteToolStripMenuItem.BackColor = Color.DarkRed;

          
            CambioDeColorNegro(ProductoToolStripMenuItem);
            CambioDeColorNegro(EmpleadoToolStripMenuItem);
            CambioDeColorNegro(proveedorToolStripMenuItem);
            CambioDeColorNegro(VentaoolStripMenuItem);

        }

        private void CambioDeColorNegro (ToolStripMenuItem tool)
        {
            tool.BackColor = Color.Black;
        }

        private void ClienteToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void EmpleadoToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            EmpleadoToolStripMenuItem.BackColor = Color.DarkRed;

            CambioDeColorNegro(proveedorToolStripMenuItem);
            CambioDeColorNegro(ProductoToolStripMenuItem);
            CambioDeColorNegro(ClienteToolStripMenuItem);
  
            CambioDeColorNegro(VentaoolStripMenuItem);

        }

        private void ProductoToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            ProductoToolStripMenuItem.BackColor = Color.DarkRed;

            CambioDeColorNegro(proveedorToolStripMenuItem);
            CambioDeColorNegro(EmpleadoToolStripMenuItem);
            CambioDeColorNegro(ClienteToolStripMenuItem);
        
            CambioDeColorNegro(VentaoolStripMenuItem);

        }

        private void proveedorToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            proveedorToolStripMenuItem.BackColor = Color.DarkRed;

            CambioDeColorNegro(ProductoToolStripMenuItem);
            CambioDeColorNegro(EmpleadoToolStripMenuItem);
            CambioDeColorNegro(ClienteToolStripMenuItem);
           
            CambioDeColorNegro(VentaoolStripMenuItem);

        }

        private void VentaoolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            VentaoolStripMenuItem.BackColor = Color.DarkRed;

            CambioDeColorNegro(ProductoToolStripMenuItem);
            CambioDeColorNegro(EmpleadoToolStripMenuItem);
            CambioDeColorNegro(ClienteToolStripMenuItem);
            CambioDeColorNegro(proveedorToolStripMenuItem);
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
