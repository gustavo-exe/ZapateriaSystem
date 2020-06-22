using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ZapateriaSystem.Producto_General
{
    class claseProductoGeneral
    {
        private Conexion conexion;
        private int idCodigoDeBarra;
        private string NombreProducto;
        private string Marca;
        private string PrecioUnitario;
        private string Cantidad;
        private string Descripcion;
        private int idProveedor;
        private string talla;
        private string color;
        private MySqlException error;

        public claseProductoGeneral()
        {
            idCodigoDeBarra = 0;
            NombreProducto = "";
            Marca = "";
            PrecioUnitario = "";
            Cantidad = "";
            Descripcion = "";
            idProveedor = 0;
            talla = "";
            color = "";
            conexion = new Conexion();
        }

        public claseProductoGeneral(int c, string n, string m, string p, string ca, string d, int pr, string tll, string col)
        {
            c = idCodigoDeBarra;
            n = NombreProducto;
            m = Marca;
            p = PrecioUnitario;
            ca = Cantidad;
            d = Descripcion;
            pr = idProveedor;
            tll= talla;
            col = color;
            conexion = new Conexion();
        }

        public string TallaNumero
        {
            get { return talla; }
            set { talla = value;}
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public int IdCodigoDeBarra
        {
            get
            {
                return idCodigoDeBarra;
            }
            set
            {
                idCodigoDeBarra = value;
            }
        }
        public string nombreProducto
        {
            get
            {
                return NombreProducto;
            }
            set
            {
                NombreProducto = value;
            }
        }
        public string marca
        {
            get
            {
                return Marca;
            }
            set
            {
                Marca = value;
            }
        }
        public string precioUnitario
        {
            get
            {
                return PrecioUnitario;
            }
            set
            {
                PrecioUnitario = value;
            }
        }
        public string cantidad
        {
            get
            {
                return Cantidad;
            }
            set
            {
                Cantidad = value;
            }
        }
        public string descripcion
        {
            get
            {
                return Descripcion;
            }
            set
            {
                Descripcion = value;
            }
        }

        public int proveedor
        {
            get
            {
                return idProveedor;
            }
            set
            {
                idProveedor = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean r = false;
            //r = conexion.IUD(String.Format(" INSERT INTO `zapateriabd`.`producto` (idProveedor, NombreProducto, Marca, Talla, Color, PrecioUnitario, Cantidad, Descripcion) VALUES (1,'J','J','K','J','8','12','KKK');"));
            r = conexion.IUD(String.Format("INSERT INTO producto (idProveedor, NombreProducto, Marca, Talla, Color, PrecioUnitario, Cantidad, Descripcion) VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}');", idProveedor, NombreProducto, Marca, TallaNumero,Color,PrecioUnitario, Cantidad, Descripcion));
            return r;
        }

        public List<claseProductoGeneral> MostrarProductoGeneral()
        {
            List<claseProductoGeneral> productoGeneral = new List<claseProductoGeneral>();
            try
            {


                return productoGeneral;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public claseProductoGeneral BuscarID(int id)
        {
            claseProductoGeneral productoGeneral = new claseProductoGeneral();

            //NombreProducto,Marca,PrecioUnitario,Cantidad,Descripcion
            DataTable t1 = conexion.consulta(string.Format("SELECT idProveedor, NombreProducto, Marca, Talla, Color, PrecioUnitario, Cantidad, Descripcion FROM producto where IdProducto={0};", id));
            if (t1.Rows.Count > 0)
            {
                
               
                productoGeneral.idProveedor = Convert.ToInt32(t1.Rows[0][0].ToString());
                productoGeneral.NombreProducto = t1.Rows[0][1].ToString();
                productoGeneral.Marca = t1.Rows[0][2].ToString();
                productoGeneral.TallaNumero = t1.Rows[0][3].ToString();
                productoGeneral.Color = t1.Rows[0][4].ToString();
                productoGeneral.PrecioUnitario = t1.Rows[0][5].ToString();
                productoGeneral.Cantidad = t1.Rows[0][6].ToString();
                productoGeneral.Descripcion = t1.Rows[0][7].ToString();
                

            }
            return productoGeneral;
        }

        public void Modificar(claseProductoGeneral productoGeneral)
        {
            int id;
            id = productoGeneral.idCodigoDeBarra;

            if (conexion.IUD(string.Format("UPDATE producto SET idProveedor={0} " +
                                                             ", NombreProducto='{1}'" +
                                                             ", Marca='{2}'" +
                                                             ", Talla = '{3}'"+
                                                             ", Color = '{4}'"+
                                                             ", PrecioUnitario='{5}'" +
                                                             ", Cantidad='{6}'" +
                                                             ", Descripcion='{7}'" +
                                                             "WHERE IdProducto={8}", productoGeneral.idProveedor, productoGeneral.NombreProducto, 
                                                                                          productoGeneral.Marca, productoGeneral.TallaNumero,productoGeneral.Color,
                                                                                          productoGeneral.PrecioUnitario, productoGeneral.Cantidad,
                                                                                          productoGeneral.Descripcion, productoGeneral.idCodigoDeBarra)))
            {
                MessageBox.Show("Se actulizaron los datos de: " + Convert.ToString(id));
            }

        }

        public void Eliminar(claseProductoGeneral pro)
        {
            int id;


            id = pro.idCodigoDeBarra;
            if (conexion.IUD(string.Format("DELETE FROM producto WHERE IdProducto={0};", idCodigoDeBarra)))
            {
                MessageBox.Show("Se elimino el producto: " + Convert.ToString(id));
            }
            
        }
       
        public MySqlException Error
        {
            get { return error; }
        }

    }
}
