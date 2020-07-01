using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapateriaSystem.Venta
{
    class claseVenta
    {
        private Conexion conexion;
        private int idVenta;
        private int idFactura;
        private string idCliente;
        private string idEmpleado;
  
        private int idProducto;
        private double precio;
        private int cantidades;
        private int descuento;
        private double total;
        private string tipoDePago;
        private MySqlException error;

        //Constructor
        public claseVenta()
        {
            idCliente = "";
            idEmpleado = "";
 
            idProducto = 0;
            precio = 0.0;
            cantidades = 0;
            descuento = 0;
            total = 0.0;
            tipoDePago = "";
            conexion = new Conexion();
        }

        //Inicilizador
        public claseVenta(string a, string b, int c, double d, int e, int f,double t,string tp)
        {
            idCliente = a;
            idEmpleado = b;

            idProducto = c;
            precio = d;
            cantidades = e;
            descuento = f;
            total = t;
            tipoDePago = tp;
            conexion = new Conexion();
        }

        public string TipoDePago
        {
            get { return tipoDePago; }
            set { tipoDePago = value; }
        }

        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
        public int IdVenta
        {
            get
            {
                return idVenta;
            }
            set
            {
                idVenta = value;
            }
        }
        public int IdFactura
        {
            get
            {
                return idFactura;
            }
            set
            {
                idFactura = value;
            }
        }
        public string IdCliente
        {
            get
            {
                return idCliente;
            }
            set
            {
                idCliente = value;
            }
        }

        public string IdEmpleado
        {
            get
            {
                return idEmpleado;
            }
            set
            {
                idEmpleado = value;
            }
        }


        public int IdProducto
        {
            get
            {
                return idProducto;
            }
            set
            {
                idProducto = value;
            }
        }
        public double Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }
        public int Cantidades
        {
            get
            {
                return cantidades;
            }
            set
            {
                cantidades = value;
            }
        }
        public int Descuento
        {
            get
            {
                return descuento;
            }
            set
            {
                descuento = value;
            }
        }

        public MySqlException Error
        {
            get { return error; }
        }
        /// <summary>
        /// Esta funcion es para generar una venta es decir el pago.
        /// </summary>
        /// <returns></returns>

        public Boolean GenerarVenta()
        {

            /*Inserta datos en la tabla de detalle de venta */
            Boolean r = false;
            r = conexion.IUD(String.Format("insert into venta (idCliente, idEmpleado, idFactura, Total, TipoDePago) value('{0}','{1}',{2},{3},'{4}');", idCliente, idEmpleado, idFactura, Total, tipoDePago));
            return r;
        
        }


        /// <summary>
        /// Insertamos en la base en la tabla detallede venta todo lo que 
        /// viene del fomrulario de insertar venta.
        /// </summary>
        /// <returns></returns>
        public Boolean Insertar()
        {
           
            /*Inserta datos en la tabla de detalle de venta */
            if (conexion.IUD(string.Format("insert into detalledeventa(idFactura,idProducto, precio,Cantidad,Descuento ,Total) value({0},{1},{2},{3},{4},{5});", idFactura, idProducto, precio, cantidades, descuento,total)))
            {
                return true;
            }
            else
            {
                error = conexion.Error;
                return false;
            }
        }

       
        /// <summary>
        /// Esta funcion esta mal nombrda, pero funciona para
        /// insertar una factura y generar el folio.
        /// </summary>
        /// <returns></returns>
        public Boolean Venta()
        {
            if (conexion.IUD(string.Format("insert into factura(IdEmpleado,idCliente) value('{0}','{1}')", idEmpleado,idCliente)))
            {
                IdFactura = Convert.ToInt32(conexion.consulta(string.Format("SELECT MAX(IdFactura) from Factura")).Rows[0][0].ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
 
        /// <summary>
        /// Comprobamos que todo se logre eliminar.
        /// 
        /// Recordar revisar la revision de esta funcion.
        /// </summary>
        /// <returns></returns>
        public Boolean Eliminar()
        {

            if (conexion.IUD(string.Format("DELETE FROM DetalleDeVenta WHERE idVenta='{0}'", IdVenta)))
            {
                
            }
            else
            {
                error = conexion.Error;
            }


            if (conexion.IUD(string.Format("DELETE FROM Venta WHERE idVenta='{0}'", IdVenta)))
            {

            }
            else
            {
                error = conexion.Error;
            }

            if (conexion.IUD(string.Format("DELETE FROM factura WHERE IdFactura='{0}'", IdFactura)))
            {
          
              
                return true;
            }
            else
            {
                error = conexion.Error;
                return false;
            }
        }

    }
}

