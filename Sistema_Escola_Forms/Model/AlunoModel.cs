using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Sistema_Escola_Forms.Entidades;
using Sistema_Escola_Forms.Repository;


namespace Sistema_Escola_Forms.Model
{
    public class AlunoModel
    {
        AlunoRepository dao = new AlunoRepository();
        public DataTable listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Listar();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Salvar(Aluno aluno)
        {
            try
            {
                dao.Salvar(aluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar");
                throw;
            }
        }
        public void Editar(Aluno aluno)
        {
            try
            {
                dao.Editar(aluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar!");
                throw;
            }
        }
        public void Excluir(Aluno aluno)
        {
            try
            {
                dao.Excluir(aluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar!");
                throw;
            }
        }
    }
}
