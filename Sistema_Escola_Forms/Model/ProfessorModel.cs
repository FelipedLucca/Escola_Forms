using Sistema_Escola_Forms.Repository;
using System;
using System.Windows.Forms;
using Sistema_Escola_Forms.Entities;
using System.Data;

namespace Sistema_Escola_Forms.Model
{
    public class ProfessorModel
    {
        ProfessorRepository dao = new ProfessorRepository();
        public Professor Login(Professor professor)
        {
            try
            {
                return dao.Enter(professor);
            }
            catch 
            {
                throw;
            }
        }
        public DataTable listarProf()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarProf();
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
                    dao.Salvar(professor);
                }
                catch 
                {
                    throw;
                }
            }
            public void Editar(Professor professor)
            {
                try
                {
                    dao.EditarProf(professor);
                }
                catch 
                {
                    throw;
                }
            }
            public void Excluir(Professor professor)
            {
                try
                {
                    dao.ExcluirProf(professor);
                }
                catch 
                {
                    throw;
                }
            }
    }
}
