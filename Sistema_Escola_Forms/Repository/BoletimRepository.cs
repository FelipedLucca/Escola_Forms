using MySql.Data.MySqlClient;
using Sistema_Escola_Forms.Entities;
using System.Data;

namespace Sistema_Escola_Forms.Repository
{
    public class BoletimRepository
    {
        MySqlCommand sql;
        Connection con = new Connection();

        public DataTable NotaAluno()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT a.ra, a.nome, a.classe, b.nota1, b.nota2, b.nota3, b.nota4 FROM aluno a INNER JOIN professor p ON a.classe = p.classe left JOIN boletim b on b.fk_id_aluno = a.ra; ", con.conectar);
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
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
            catch
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
            }
        }

        public DataTable Buscar(string professor_classe)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT A.nome, A.ra, A.classe, P.codigo, P.materia FROM aluno A INNER JOIN professor P on A.classe = P.classe WHERE P.classe = @professor_classe", con.conectar);
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                da.SelectCommand = sql;
                sql.Parameters.AddWithValue("@professor_classe", professor_classe);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
            }
        }

        public void SalvarNota(Boletim nota)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO boletim(nota1, nota2, nota3, nota4, media, fk_id_aluno, situacao) VALUES(@nota1, @nota2, @nota3, @nota4, @media, @fk_id_aluno, @situacao) ", con.conectar);
                sql.Parameters.AddWithValue("@nota1", nota.Nota1);
                sql.Parameters.AddWithValue("@nota2", nota.Nota2);
                sql.Parameters.AddWithValue("@nota3", nota.Nota3);
                sql.Parameters.AddWithValue("@nota4", nota.Nota4);
                sql.Parameters.AddWithValue("@media", nota.Media);
                sql.Parameters.AddWithValue("@fk_id_aluno", nota.RaAluno);
                sql.Parameters.AddWithValue("@situacao", nota.Situacao);
                sql.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.FecharConexao();
            }
        }
    }
}




