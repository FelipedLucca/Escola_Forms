using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Sistema_Escola_Forms.Entidades;

namespace Sistema_Escola_Forms.Repository
{
    public class AlunoRepository
    {
        MySqlCommand sql;
        Connection con = new Connection();

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT*FROM aluno", con.conectar);
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
        }
        public void Salvar(Aluno aluno)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO aluno(nome,sexo, idade, ra, classe) VALUES(@nome ,@sexo, @idade , @ra,@classe ) ", con.conectar);
                sql.Parameters.AddWithValue("@nome", aluno.Nome);
                sql.Parameters.AddWithValue("@sexo", aluno.Sexo);
                sql.Parameters.AddWithValue("@idade", aluno.Idade);
                sql.Parameters.AddWithValue("@classe", aluno.Classe);
                sql.Parameters.AddWithValue("@ra", aluno.RA);
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
        public void Editar(Aluno aluno)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE aluno SET nome = @nome, sexo = @sexo, idade = @idade, classe = @classe WHERE ra = @ra", con.conectar);
                sql.Parameters.AddWithValue("@nome", aluno.Nome);
                sql.Parameters.AddWithValue("@sexo", aluno.Sexo);
                sql.Parameters.AddWithValue("@idade", aluno.Idade);
                sql.Parameters.AddWithValue("@classe", aluno.Classe);
                sql.Parameters.AddWithValue("@ra", aluno.RA);

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
        public void Excluir(Aluno aluno)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM aluno WHERE ra = @ra", con.conectar);
                sql.Parameters.AddWithValue("@ra", aluno.RA);
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
