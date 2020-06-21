﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaSystem.Cliente
{
    public class claseInstagram
    {
        private Conexion conexion;
        private int idInstagram;
        private string idCliente;
        private string usuario;
        private string url;
        private MySqlException error;

        public claseInstagram()
        {
            idInstagram = 0;
            idCliente = "";
            usuario = "";
            url = "";

            conexion = new Conexion();
        }

        public claseInstagram(string ic, string u, string c)
        {
            idInstagram = 0;
            idCliente = ic;
            usuario = u;
            url = c;
            conexion = new Conexion();
        }

        public int IdInstagram
        {
            get
            {
                return idInstagram;
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

        public string Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }
        public MySqlException Error
        {
            get { return error; }
        }


        public Boolean mostrarUsuario()
        {
            if (conexion.IUD(string.Format("SELECT * FROM makeuppruebas.Instagram")))
            {
                return true;
            }
            else
            {
                error = conexion.Error;
                return false;
            }
        }

        public claseInstagram BuscarURL(string user)
        {
            claseInstagram instagram = new claseInstagram();

            DataTable Tabla = conexion.consulta(string.Format("SELECT URL FROM instagram WHERE Usuario='{0}';", user));
            if (Tabla.Rows.Count > 0)
            {
                instagram.url = Tabla.Rows[0][0].ToString();
                //MessageBox.Show("Si hay");
            }
            return instagram;

        }

    }
}
