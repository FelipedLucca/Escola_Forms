using Sistema_Escola_Forms.Entidades;
using Sistema_Escola_Forms.Entities;
using Sistema_Escola_Forms.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
