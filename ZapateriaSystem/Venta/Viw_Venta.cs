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

            DataTable Datos = conexion.consulta(String.Format("SELECT * FROM venta;"));
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
