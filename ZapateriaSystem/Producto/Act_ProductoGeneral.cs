using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZapateriaSystem.Producto_General;

namespace ZapateriaSystem
{
    public partial class Act_ProductoGeneral : Form
    {
        private int state;
        Conexion conexion;
        private claseProductoGeneral productoGeneral = new claseProductoGeneral();
        private int click;

        public Act_ProductoGeneral()
        {
            InitializeComponent();
            conexion = new Conexion();
            click = 0;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Act_ProductoGeneral_Load(object sender, EventArgs e)
        {
            //LISTA
            CargarDatosDeLaLista();
            //TEXTBOX
            VaciarTextBox();
        }
        private void CargarDatosDeLaLista()
        {
            DataTable datos = conexion.consulta(String.Format("Select IdProducto FROM producto;"));
            ListaDeProductoGeneral.DisplayMember = "IdProducto";
            ListaDeProductoGeneral.DataSource = datos;
        }
        private void VaciarTextBox()
        {
            txtNombre.Text = "";
            txtxMarca.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtidProveedor.Text = "";
            txtTalla.Text = "";
            txtColor.Text = "";
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (click == 0)
            {
                MessageBox.Show("Debes seleccionar un item de la lista.");
            }

            else
            {
                //MessageBox.Show(Convert.ToString(ListaDeEmpleados.SelectedIndices.Count));
                try
                {
                    productoGeneral = ObetenerValoresDeLosText();

                    //Llamo al metodo de modificar(DELETE)
                    productoGeneral.Eliminar(productoGeneral);

                    CargarDatosDeLaLista();

                    VaciarTextBox();

                    click = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            btnInsertar.Visible = true;
            btnEliminar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnInsertar.Visible = true;
            btnEliminar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                productoGeneral = ObetenerValoresDeLosText();

                //Llamo al metodo de modificar(UPDATE)
                productoGeneral.Modificar(productoGeneral);

                //Mostrar los botones y paneles a su estado natural
                btnInsertar.Visible = true;
                btnEliminar.Visible = true;


                //Restauro el valor de click para cuando se realiza otra seleccion la evalue
                click = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private claseProductoGeneral ObetenerValoresDeLosText()
        {
            claseProductoGeneral productoGeneral = new claseProductoGeneral();
            productoGeneral.IdCodigoDeBarra = Convert.ToInt32(ListaDeProductoGeneral.Text);
            productoGeneral.proveedor = Convert.ToInt32(txtidProveedor.Text);
            productoGeneral.nombreProducto = txtNombre.Text.ToString();
            productoGeneral.marca = txtxMarca.Text.ToString();

            productoGeneral.TallaNumero = txtTalla.Text.ToString();
            productoGeneral.Color = txtColor.Text.ToString();

            productoGeneral.precioUnitario = txtPrecio.Text.ToString();
            productoGeneral.cantidad = txtCantidad.Text.ToString();
            productoGeneral.descripcion = txtDescripcion.Text.ToString();
            

            

            return productoGeneral;
        }

        private void ListaDeProductoGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                productoGeneral = productoGeneral.BuscarID(Convert.ToInt32(ListaDeProductoGeneral.Text));


                ValoresParaLosTextDesdeObejto(productoGeneral);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ValoresParaLosTextDesdeObejto(claseProductoGeneral productoGeneral)
        {
            txtidProveedor.Text = productoGeneral.proveedor.ToString();
            txtNombre.Text = productoGeneral.nombreProducto;
            txtxMarca.Text = productoGeneral.marca;
            txtPrecio.Text = productoGeneral.precioUnitario;
            txtCantidad.Text = productoGeneral.cantidad;
            txtDescripcion.Text = productoGeneral.descripcion;
            

            txtColor.Text = productoGeneral.Color.ToString();
            txtTalla.Text = productoGeneral.TallaNumero.ToString();


        }

        private void ListaDeProductoGeneral_Click(object sender, EventArgs e)
        {
            click = 1;
        }

        //INSERTAR
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (click == 0)
            {
                //MessageBox.Show(Convert.ToString(Click));
                MessageBox.Show("Debes seleccionar un item de la lista.");
            }

            else
            {
                //Cambiar estado de los botones y cambiar el color de los paneles
                btnInsertar.Visible = false;
                btnEliminar.Visible = false;

            }
        }
    }
}
