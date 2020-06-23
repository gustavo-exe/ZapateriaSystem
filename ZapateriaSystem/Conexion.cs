﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ZapateriaSystem
{
    class Conexion
    {
        private MySqlConnection conexion;
        private string bd;
        private string servidor;
        private string usuario;
        private string pass;
        private MySqlException error;

        public Conexion()
        {
            //Elias

            bd = "zapateriabd";
            servidor = "127.0.0.1";
            usuario = "root";
            pass = "12345678";

            
            conexion = new MySqlConnection();                                                                                                                                                                               
        }

        public Conexion(string b, string se, string u, string p)
        {
            bd = b;
            servidor = se;
            usuario = u;
            pass = p;
            conexion = new MySqlConnection();
        }
        public void conectar()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.ConnectionString = string.Format("Database={0};Server={1};Uid={2};Pwd={3};SslMode=none", bd, servidor, usuario, pass);
                    conexion.Open();
                }
                else
                {
                    conexion.Close();
                    conexion.ConnectionString = string.Format("Database={0};Server={1};Uid={2};Pwd={3};SslMode=none", bd, servidor, usuario, pass);
                    conexion.Open();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(string.Format("Error: \n{0}", ex.ToString()), "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public DataTable consulta(string sql)
        {
            DataTable t = new DataTable();
            conectar();
            MySqlCommand comando = conexion.CreateCommand();
            MySqlDataAdapter adptador = new MySqlDataAdapter();
            try
            {
                comando.Connection = conexion;
                comando.CommandText = sql;
                adptador.SelectCommand = comando;
                adptador.Fill(t);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(string.Format("Error: \n{0}", ex.ToString()), "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return t;
        }
        public Boolean IUD(string sql)
        {
            conectar();
            MySqlCommand comando = conexion.CreateCommand();
            try
            {
                comando.Connection = conexion;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                error = ex;
                return false;
            }
        }
        public MySqlException Error
        {
            get { return error; }
        }

    }
}
