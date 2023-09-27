using MySql.Data.MySqlClient;
using Sistema_Escola_Forms.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_Escola_Forms.Repository
{
    internal class ProfessorRepository
    {
        MySqlCommand sql;
        Connection con = new Connection();
        public Professor Enter(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT*FROM professor WHERE nome = @nome  ", con.conectar);
                sql.Parameters.AddWithValue("@nome", professor.Nome);
                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        professor.Nome = Convert.ToString(dr["nome"]);
                    }
                }
                else
                {
                    professor.Nome = null;
                }

                return professor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro : " + ex.Message);
                throw ex;
            }
        }
        public DataTable ListarProf()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT*FROM professor", con.conectar);
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
        public void Salvar(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO professor(nome,sexo, idade, codigo, materia, classe) VALUES(@nome ,@sexo, @idade , @codigo ,@materia, @classe ) ", con.conectar);
                sql.Parameters.AddWithValue("@nome", professor.Nome);
                sql.Parameters.AddWithValue("@sexo", professor.Sexo);
                sql.Parameters.AddWithValue("@idade", professor.Idade);
                sql.Parameters.AddWithValue("@codigo", professor.Codigo);
                sql.Parameters.AddWithValue("@materia", professor.Materia);
                sql.Parameters.AddWithValue("@classe", professor.Classe);

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
        public void EditarProf(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE alunos SET nome = @nome, sexo = @sexo, idade = @idade, classe = @classe WHERE codigo = @codigo", con.conectar);
                sql.Parameters.AddWithValue("@nome", professor.Nome);
                sql.Parameters.AddWithValue("@sexo", professor.Sexo);
                sql.Parameters.AddWithValue("@idade", professor.Idade);
                sql.Parameters.AddWithValue("@materia", professor.Materia);
                sql.Parameters.AddWithValue("@classe", professor.Classe);
                sql.Parameters.AddWithValue("@codigo", professor.Codigo);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar" + ex);
                con.FecharConexao();
                throw ex;
            }
        }
        //colocar so o date.
        public void ExcluirProf(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM professor WHERE codigo = @codigo", con.conectar);

                sql.Parameters.AddWithValue("@codigo", professor.Codigo);

                sql.ExecuteNonQuery();
                con.FecharConexao();

                //executar os comandos de sql
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir" + ex.Message);
                con.FecharConexao();
                throw ex;
            }
        }
    }
}
