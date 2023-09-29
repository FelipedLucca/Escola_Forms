using Sistema_Escola_Forms.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Escola_Forms.View
{
    public partial class NotaView : Form
    {

        public NotaView()
        {
            InitializeComponent();
        }

        private void NotaView_Load(object sender, EventArgs e)
        {

        }
        public void SalvarNota(NotaView nota)
        {
            try
            {
                aluno.Nome = TextNomeAluno.Text;
                aluno.Sexo = CbSexoAluno.Text;
                aluno.Nascimento = Convert.ToDateTime(idadeProfessor.Text);
                aluno.Sala = CbturmaAluno.Text;
                aluno.RA = Convert.ToInt16(RaAluno.Text);

                model.Salvar(aluno);
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
                throw;
            }
        }





    }
}
