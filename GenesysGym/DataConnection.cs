using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

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
    }
}
