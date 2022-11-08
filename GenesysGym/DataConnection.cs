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
                using (var cmd = ConexaoBanco().CreateCommand()) 
                {
                    cmd.CommandText = "SELECT * FROM usuarios";
                    msdAdapter = new MySqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    msdAdapter.Fill(dt);
                    ConexaoBanco().Close();

                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static DataTable consulta(string sql)
        {
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    msdAdapter = new MySqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    msdAdapter.Fill(dt);
                    ConexaoBanco().Close();

                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
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
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO usuarios (nome_user, username, senha_user, status_user, nivel_user) VALUES (@nome, @username, @password, @status, @nivel)";

                cmd.Parameters.AddWithValue("@nome", user.nome);
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@status", user.status);
                cmd.Parameters.AddWithValue("@nivel", user.nivel);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Novo Usuário Cadastrado!");
                ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário!");
                ConexaoBanco().Close();
            }
        }


        public static bool existeUserName(Usuario user)
        {
            bool res;
            MySqlDataAdapter msdAdapter = null;
            DataTable dt = new DataTable();

            var cmd=ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT username FROM usuarios WHERE username='"+user.username+"'";
            msdAdapter = new MySqlDataAdapter(cmd.CommandText, ConexaoBanco());
            msdAdapter.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }






        // FIM DAS FUNÇÕES TELA NOVO USER
    }   

}
