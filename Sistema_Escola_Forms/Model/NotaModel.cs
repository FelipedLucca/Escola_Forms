using Sistema_Escola_Forms.Entities;
using Sistema_Escola_Forms.Repository;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_Escola_Forms.Model
{
    internal class NotaModel
    {
        NotaRepository dao = new NotaRepository();
        public void SalvarNota(Nota nota)
        {
            try
            {
                dao.SalvarNota(nota);                                                                                           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a nota");
                throw;
            }
        }
        public DataTable Buscar(string professor_classe)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Buscar(professor_classe);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable NotaAluno()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.NotaAluno();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer o innner");
                throw;
            }
        }
        public DataTable ListarNota()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarNota();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
      }
 }

