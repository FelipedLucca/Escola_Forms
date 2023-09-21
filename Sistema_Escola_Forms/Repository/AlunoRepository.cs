using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using Sistema_Escola_Forms.Entidades;

namespace Sistema_Escola_Forms.Repository
{
    public class AlunoRepository 
    {
        MySqlCommand sql;
        Connection con = new Connection();

        //objeto de negocio.
        //Lista + interface.
        public DataTable Listar()
        {  
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT*FROM alunos", con.conectar);
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
            public void Salvar(Aluno aluno)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO alunos(nome,sexo, idade, sala, ra) VALUES(@nome ,@sexo, @idade ,@sala, @ra ) ", con.conectar);
                sql.Parameters.AddWithValue("@nome", aluno.Nome);
                sql.Parameters.AddWithValue("@sexo", aluno.Sexo);
                sql.Parameters.AddWithValue("@idade", aluno.Nascimento);
                sql.Parameters.AddWithValue("@sala", aluno.Sala);
                sql.Parameters.AddWithValue("@ra", aluno.RA);
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
        public void Editar(Aluno aluno)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE alunos SET nome = @nome, sexo = @sexo, idade = @idade, sala = @sala WHERE ra = @ra", con.conectar);
                sql.Parameters.AddWithValue("@nome", aluno.Nome);
                sql.Parameters.AddWithValue("@sexo", aluno.Sexo);
                sql.Parameters.AddWithValue("@idade", aluno.Nascimento);
                sql.Parameters.AddWithValue("@sala", aluno.Sala);
                sql.Parameters.AddWithValue("@ra", aluno.RA);

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
        public void Excluir(Aluno aluno)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM alunos WHERE ra = @ra", con.conectar);
               
                sql.Parameters.AddWithValue("@ra", aluno.RA);

                sql.ExecuteNonQuery();
                con.FecharConexao();

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
