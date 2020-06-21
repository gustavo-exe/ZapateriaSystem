using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZapateriaSystem.Empleado;
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
    }
}
