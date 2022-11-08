using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;

namespace GenesysGym
{
    internal class DataConnection
    {
        private static MySqlConnection msConnection;

        private static MySqlConnection ConexaoBanco()
        {
            string connection_mysql = @"Server=localhost;Database=GenesysGym;Uid=root;Pwd='1234'";

            MySqlConnection msConnection = new MySqlConnection();
            msConnection.ConnectionString = connection_mysql;
            msConnection.Open();

            return msConnection;
        }


        public static DataTable ObterTodosUsuarios()
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuarios";
                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                msdAdapter.Fill(dt);
                vcon.Close();

                return dt;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable consulta(string sql)
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();                
                cmd.CommandText = sql;
                msdAdapter = new MySqlDataAdapter (cmd.CommandText, vcon);
                msdAdapter.Fill(dt);
                vcon.Close();
                return dt;                
            }
            catch (Exception ex)
            {
                throw ex; 
            }

        }


        // FUNÇÕES DA TELA NOVO USER
        public static void NovoUsuario(Usuario user)
        {
            if(existeUserName(user))
            {
                MessageBox.Show("Username já existe!");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO usuarios (nome_user, username, senha_user, status_user, nivel_user) VALUES (@nome, @username, @password, @status, @nivel)";

                cmd.Parameters.AddWithValue("@nome", user.nome);
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@status", user.status);
                cmd.Parameters.AddWithValue("@nivel", user.nivel);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Novo Usuário Cadastrado!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário!");
            }
        }


        public static bool existeUserName(Usuario user)
        {
            bool res;
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT username FROM usuarios WHERE username='"+user.username+"'";
            msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
            msdAdapter.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }
        // FIM DAS FUNÇÕES TELA NOVO USER
        //
        //
        //
        // FUNÇÕES DA TELA GESTÃO DE USUARIOS

        public static DataTable ObterUsuariosIdNome()
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_user as 'ID Usuário', nome_user as 'Nome Usuário' FROM usuarios";
                msdAdapter = new MySqlDataAdapter(cmd.CommandText, vcon);
                msdAdapter.Fill(dt);
                vcon.Close();

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // FIM DAS FUNÇOES TELA GESTÃO USUARIOS
    }   

}
