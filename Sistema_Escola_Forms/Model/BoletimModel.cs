using Sistema_Escola_Forms.Entities;
using Sistema_Escola_Forms.Repository;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_Escola_Forms.Model
{
    internal class BoletimModel
    {
        BoletimRepository dao = new BoletimRepository();
        public void SalvarNota(Boletim boletim)
        {
            try
            {
                dao.SalvarNota(boletim);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a nota");
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
            catch 
            {
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


