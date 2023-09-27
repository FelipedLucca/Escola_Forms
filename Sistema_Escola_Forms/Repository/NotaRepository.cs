using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;
using Sistema_Escola_Forms.Entities;
namespace Sistema_Escola_Forms.Repository
{
    internal class NotaRepository
    {
        MySqlCommand sql;
        Connection con = new Connection();

        public DataTable NotaAluno()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT a.ra, a.nome, a.sala FROM alunos a INNER JOIN professor p ON a.sala = p.classe; ", con.conectar);
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

        public DataTable Buscar(string professor_classe)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand( "SELECT A.nome, A.ra, A.sala, P.codigo, P.materia FROM alunos A INNER JOIN professor P on A.sala = P.classe WHERE P.classe = @professor_classe", con.conectar);
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.SelectCommand = sql;
                sql.Parameters.AddWithValue("@professor_classe", professor_classe);
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
            catch (Exception)
            {
               
                con.FecharConexao();
                throw ;
            }
        }
    }   
}


