using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapateriaSystem.Cliente
{
    public class claseCliente
    {
        private Conexion conexion;
        private string idCliente;
        private string nombreCliente;
        private string correoCliente;
        private string telefonoCliente;
        private string perfilInstagram;
        private DateTime cumpleaniosCliente;
        private string ciudadCliente;
      
        private MySqlException error;

        public claseCliente() 
        {
            idCliente = "";
            nombreCliente = "";
            correoCliente = "";
            telefonoCliente = "";
            perfilInstagram = "";
            cumpleaniosCliente = DateTime.Today;
            ciudadCliente = "";

            conexion = new Conexion();
        }
        
        public claseCliente(string i, string n, string c, string te, string pf, DateTime cum, string ci)
        {
            idCliente = i;
            nombreCliente = n;
            correoCliente = c;
            telefonoCliente = te;
            perfilInstagram = pf;
            cumpleaniosCliente = cum;
            ciudadCliente = ci;
         
            conexion = new Conexion();
        }

        public Boolean Guardar()
        {
            if (conexion.IUD(string.Format("INSERT INTO cliente (IdCliente, Nombre, Correo, Telefono, PerfilInstagram, Cumpleaños, Ciudad) VALUES ('{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", idCliente, nombreCliente, correoCliente, telefonoCliente, perfilInstagram, cumpleaniosCliente.ToString("yyyy-MM-dd"), ciudadCliente)))
            {
                return true;
            }
            else
            {
                error = conexion.Error;
                return false;
            }
        }

        public List<claseCliente>  MostrarCliente()
        {
            List<claseCliente> clientes = new List<claseCliente>();
            try
            {


                return clientes;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public claseCliente BuscarID(string id)
        {
            claseCliente cliente = new claseCliente();
            //IdCliente, Nombre, Correo, Telefono, PerfilInstagram, Cumpleaños, Ciudad, TonoDeBase, TonoDePolvo, TipoDeCuties
            DataTable t1 = conexion.consulta(string.Format("SELECT * FROM cliente where IdCliente='{0}'", id));
            if (t1.Rows.Count > 0)
            {
                cliente.idCliente =     t1.Rows[0][0].ToString();
                cliente.nombreCliente = t1.Rows[0][1].ToString();
                cliente.correoCliente = t1.Rows[0][2].ToString();
                cliente.telefonoCliente = t1.Rows[0][3].ToString();
                cliente.perfilInstagram = t1.Rows[0][4].ToString();
                cliente.cumpleaniosCliente = Convert.ToDateTime(t1.Rows[0][5].ToString());
                cliente.ciudadCliente = t1.Rows[0][6].ToString();
            }
            return cliente;

        }

        public void Modificar(claseCliente cliente)
        {
            string id;

            id = cliente.idCliente;
            if (conexion.IUD(string.Format("UPDATE cliente " +
                                            "SET " +
                                            "Nombre='{0}', " +
                                            "Correo='{1}', " +
                                            "Telefono='{2}'," +
                                            "PerfilInstagram='{3}', " +
                                            "Cumpleaños='{4}', " +
                                            "Ciudad='{5}'" +
                                            "WHERE IdCliente='{6}';",
                                            cliente.NombreCliente, cliente.CorreoCliente, cliente.TelefonoCliente, cliente.PerfilInstagram, cliente.CumpleanosCliente.ToString("yyyy-MM-dd"), cliente.CiudadCliente, cliente.IdCliente)))
            {
                MessageBox.Show("Se actulizaron los datos de: " + Convert.ToString(id));
            }
        }

        public void Eliminar(claseCliente cliente)
        {
            string id;

            id = cliente.idCliente;
            if (conexion.IUD(string.Format("DELETE FROM cliente WHERE IdCliente='{0}';", cliente.idCliente)))
            {
                MessageBox.Show("Se elimino el cliente: " + Convert.ToString(id));
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

        public string NombreCliente
        {
            get
            {
                return nombreCliente;
            }
            set
            {
                nombreCliente = value;
            }
        }

        public string CorreoCliente
        {
            get
            {
                return correoCliente;
            }
            set
            {
                correoCliente = value;
            }
        }
        public string TelefonoCliente
        {
            get
            {
                return telefonoCliente;
            }
            set
            {
                telefonoCliente = value;
            }
        }

        
        public string PerfilInstagram
        {
            get
            {
                return perfilInstagram;
            }
            set
            {
                perfilInstagram = value;
            }
        }

        public DateTime CumpleanosCliente
        {
            get
            {
                return cumpleaniosCliente;
            }
            set
            {
                cumpleaniosCliente = value.Date;
            }
        }

        public string CiudadCliente
        {
            get
            {
                return ciudadCliente;
            }
            set
            {
                ciudadCliente = value;
            }
        }

        public MySqlException Error
        {
            get { return error; }
        }


    }
}
