﻿using System;
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
    public partial class Viw_Venta : Form
    {

        Conexion conexion;
        private int state;
        private claseVenta venta;
        private int codigo;
        public Viw_Venta()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Viw_Venta_Load(object sender, EventArgs e)
        {

            DataTable Datos = conexion.consulta(String.Format("SELECT p.idVenta as 'Numero de venta',a.idCliente as 'Cliente',a.idEmpleado as 'Empleado', SUM(p.Total) as 'Total' FROM DetalleDeVenta  as p INNER JOIN venta as a on p.idVenta = a.idVenta where p.idVenta > 0 GROUP BY p.idVenta ;"));
            VerVenta.DataSource = Datos;
            VerVenta.Refresh();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void VerVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
