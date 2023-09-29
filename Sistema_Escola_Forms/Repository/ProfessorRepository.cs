using MySql.Data.MySqlClient;
using Sistema_Escola_Forms.Entities;
using System;
using System.Data;

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
            catch 
            {
                throw;
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
            catch 
            {
                throw;
            }
        }
        public void Salvar(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO professor(nome,sexo, idade, id, materia, classe) VALUES(@nome ,@sexo, @idade , @id ,@materia, @classe ) ", con.conectar);
                sql.Parameters.AddWithValue("@nome", professor.Nome);
                sql.Parameters.AddWithValue("@sexo", professor.Sexo);
                sql.Parameters.AddWithValue("@idade", professor.Idade);
                sql.Parameters.AddWithValue("@id", professor.Id);
                sql.Parameters.AddWithValue("@materia", professor.Materia);
                sql.Parameters.AddWithValue("@classe", professor.Classe);

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

        public void EditarProf(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE aluno SET nome = @nome, sexo = @sexo, idade = @idade, classe = @classe WHERE id = @id", con.conectar);
                sql.Parameters.AddWithValue("@nome", professor.Nome);
                sql.Parameters.AddWithValue("@sexo", professor.Sexo);
                sql.Parameters.AddWithValue("@idade", professor.Idade);
                sql.Parameters.AddWithValue("@materia", professor.Materia);
                sql.Parameters.AddWithValue("@classe", professor.Classe);
                sql.Parameters.AddWithValue("@id", professor.Id);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch 
            {  
                throw ;
            }
            finally
            {
                con.FecharConexao();
            }
        }

        public void ExcluirProf(Professor professor)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM professor WHERE id = @id", con.conectar);
                sql.Parameters.AddWithValue("@id", professor.Id);
                sql.ExecuteNonQuery();
                con.FecharConexao();
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
