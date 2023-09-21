using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Escola_Forms
{
    internal class Connection
    {
        string conexao = "SERVER=localhost; DATABASE=escola; UID=root; PWD=xd123";
        public  MySqlConnection conectar = null;
        MySqlCommand sql = null;
        
        public void AbrirConexao()
        {
            try
            {
                conectar = new MySqlConnection(conexao);
                conectar.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void FecharConexao()
        {
            try
            {
                conectar = new MySqlConnection(conexao);
                conectar.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
