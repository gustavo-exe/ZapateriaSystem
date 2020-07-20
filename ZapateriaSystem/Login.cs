using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapateriaSystem
{
    public partial class Login : Form
    {
        /// <summary>
        ///    Instanciar objetos
        /// </summary>
        IniciarSecion empleado = new IniciarSecion();
        Conexion conexion = new Conexion();

        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void txtContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void txtContraseña_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtContraseña.Text = "";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtContraseña.Text == "" && txtUsuario.Text == "")
            {
                MessageBox.Show("Campos vacios.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    
                    IniciarSecion login = empleado.BucarUsuario(txtUsuario.Text);

                    if (login.Password == txtContraseña.Text)
                    {
                        //MessageBox.Show("Bienvenido al sistema.");

                        conexion.conectar();

                        this.Hide();
                        FormPrincipal ventana = new FormPrincipal();
                        ventana.Show();

                    }
                    else { MessageBox.Show("Los datos ingresados son incorrectos."); }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
