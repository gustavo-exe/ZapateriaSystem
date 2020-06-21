﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapateriaSystem.Cliente
{
    public partial class Ver_Datos_Cliente : Form
    {
        private int state;
       // private claseListaCliente clientes;
        //private claseCliente cliente;
        Conexion conexion;
        public Ver_Datos_Cliente()
        {
            InitializeComponent();
          //  clientes = new claseListaCliente();
            //cliente = new claseCliente();
            conexion = new Conexion();
            // Cargar_Datos();
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
            this.Close();
        }

        

      /*  private void Cargar_Datos()
        {
            string sql = "";

            sql = string.Format("SELECT * FROM cliente");
            DataTable t1 = clientes.SQL(sql);
            dvDatosCliente.DataSource = t1;
            dvDatosCliente.Refresh();

        }

            */
       /* private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            usuarioInstagram.IdCliente = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            usuarioInstagram.Usuario = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            usuarioInstagram.Url = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }*/

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*public claseCliente Cliente
        {
            get { return cliente; }
        }*/

        private void Ver_Datos_Cliente_Load(object sender, EventArgs e)
        {
            DataTable Datos = conexion.consulta(String.Format("SELECT IdCliente, Nombre, Correo, Telefono, PerfilInstagram, Cumpleaños, Ciudad, TonoDeBase as 'Tono de base', TonoDePolvo as 'Tono de polvo', TipoDeCuties as 'Tipo de cuties' FROM cliente;"));
            dvDatosCliente.DataSource = Datos;
            dvDatosCliente.Refresh();
        }

        private void dvDatosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
