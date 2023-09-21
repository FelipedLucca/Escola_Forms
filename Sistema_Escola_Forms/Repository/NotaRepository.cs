                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using Sistema_Escola_Forms.Entidades;
using System.Data;
using Sistema_Escola_Forms.Entities;
using Sistema_Escola_Forms.Model;

namespace Sistema_Escola_Forms.Repository
{
    internal class NotaRepository
    {
        MySqlCommand sql;
        Connection con = new Connection();

         public DataTable ListarNota()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT*FROM notas", con.conectar);
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro : " + ex.Message);
                throw ex;
            }
        }
        public void SalvarNota(Nota nota)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO notas(nota01, nota02, nota03, nota04, média) VALUES(@nota01, @nota02, @nota03, @nota04, @média) ", con.conectar);
                sql.Parameters.AddWithValue("@nota01", nota.Nota1);
                sql.Parameters.AddWithValue("@nota02", nota.Nota2);
                sql.Parameters.AddWithValue("@nota03", nota.Nota3);
                sql.Parameters.AddWithValue("@nota04", nota.Nota4);
                sql.Parameters.AddWithValue("@média", nota.media);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar" + ex.Message);
                con.FecharConexao();
                throw ex;
            }
        }
    }
}
