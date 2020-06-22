using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapateriaSystem.Producto_General
{
    public partial class Ins_ProductoGeneral : Form
    {   
        private int state;

        public Ins_ProductoGeneral()
        {
            InitializeComponent();
     
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
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


        

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                claseProductoGeneral productoGeneral = new claseProductoGeneral();
                
                productoGeneral.proveedor = Convert.ToInt32(txtidProveedor.Text);

                productoGeneral.nombreProducto = Convert.ToString(txtNombre.Text);
                productoGeneral.marca = Convert.ToString(txtMarca.Text);
                productoGeneral.precioUnitario = Convert.ToString((Convert.ToInt32(txtPrecio.Text)));
                productoGeneral.cantidad = Convert.ToString((Convert.ToInt32(txtCantidad.Text)));
                productoGeneral.descripcion = Convert.ToString(txtDescripcion.Text);

                productoGeneral.TallaNumero = Convert.ToString(txtTalla.Text);
                productoGeneral.Color = Convert.ToString(txtColor.Text);
                

                if (productoGeneral.Guardar())
                {
                    MessageBox.Show("Producto ingresado");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al Insertar.");
                }
            }          

        }

        private Boolean Validar()
        {
            Boolean validar = true;
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Escriba el nombre del Producto General", "Producto General", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                validar = false;
            }
            else if (txtMarca.Text == "")
            {
                MessageBox.Show("Escriba la marca del Producto General", "Producto General", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                validar = false;
            }
            else if (txtPrecio.Text == "")
            {
                MessageBox.Show("Escriba el precio del Producto General", "Producto General", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                validar = false;
            }
            else if (txtCantidad.Text == "")
            {
                MessageBox.Show("Escriba la cantidad de Producto General", "Producto General", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                validar = false;
            }
            else if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Escriba la descripcion del Producto General", "Producto General", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                validar = false;
            }
            else if (txtidProveedor.Text == "")
            {
                MessageBox.Show("Escriba el codigo del Proveedor", "Producto General", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtidProveedor.Focus();
                validar = false;
            }
            else
                validar = true;
            return validar;

        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtidProveedor.Text = "";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

