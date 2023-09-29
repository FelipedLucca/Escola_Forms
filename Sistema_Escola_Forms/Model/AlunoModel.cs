using System.Data;
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
            catch 
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
            catch 
            {
                throw;
            }
        }
        public void Editar(Aluno aluno)
        {
            try
            {
                dao.Editar(aluno);
            }
            catch 
            {
                throw;
            }
        }
        public void Excluir(Aluno aluno)
        {
            try
            {
                dao.Excluir(aluno);
            }
            catch 
            {
                throw;
            }
        }
    }
}
