using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaDePagamento.services
{
    internal class ConnectDatabase
    {
        public MySqlConnection connect()
        {
            try
            {
                string strConexao = "server=127.0.0.1;uid=root;pwd=Samuel13@;database=folhadepagamento";
                MySqlConnection conexao = new MySqlConnection(strConexao);
                conexao.Open();

                //MySqlCommand comm = conexao.CreateCommand();
                //comm.CommandText = "INSERT INTO teste(id,nome) VALUES(@id, @nome)";
                //comm.Parameters.AddWithValue("@id", "2");
                //comm.Parameters.AddWithValue("@nome", "Gabr");
                //comm.ExecuteNonQuery();

                //MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM tbFuncionario", conexao);
                //MySqlDataReader reader = sqlCommand.ExecuteReader();


                //while (reader.Read())
                //{
                //    MessageBox.Show($"{reader["id"]} ==d> {reader["nome"]}");
                //}
                return conexao;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}



