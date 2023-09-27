using System;
using System.Threading;
using System.Windows.Forms;
using Sistema_Escola_Forms.Entities;
using Sistema_Escola_Forms.Model;
using Sistema_Escola_Forms.view;

namespace Sistema_Escola_Forms.View
{
    public partial class CriarProfessor : Form
    {
        ProfessorModel model = new ProfessorModel();

        public CriarProfessor()
        {
            InitializeComponent();
        }
        private void CriarProfessor_Load(object sender, EventArgs e)
        {
            ListarProf();
        }

        private void BtnNovoProfessor_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            LimparCampo();

            Random random = new Random();
            int id = random.Next(1000, 9000);

            CodigoProfessor.Text = Convert.ToString(id);
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja editar o professor?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HabilitarCampo();
                Professor professor = new Professor();
                Editar(professor);
                ListarProf();
            };
        }

        private void BtnCriarProfessor_Click(object sender, EventArgs e)
        {
            try
            {

                if (TextNomeProfessor.Text == "")
                {
                    MessageBox.Show("O professor novo precisa ter um NOME!");
                    return;
                }
                else if (CbSexoProfessor.Text == "")
                {
                    MessageBox.Show("O professor novo precisa ter um SEXO!");
                    return;
                }
                else if (CbClasseProfessor.Text == "")
                {
                    MessageBox.Show("O professor novo precisa ter um TURMA!");
                    return;
                }

                if (MessageBox.Show("Você deseja criar um professor?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Professor professor = new Professor();
                    Salvar(professor);
                    ListarProf();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar professor : "+ex.Message);
                
            }
  
        }

        #region Crud

        public void ListarProf()
        {
            try
            {
                GridProfessor.DataSource = model.listarProf();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Editar(Professor professor)
        {
            try
            {
                professor.Codigo = Convert.ToInt16(CodigoProfessor.Text);
                professor.Nome = TextNomeProfessor.Text;
                professor.Sexo = CbSexoProfessor.Text;
                professor.Idade = Convert.ToDateTime(idadeProfessor.Text);
                professor.Materia = TxtMateria.Text;
                professor.Classe = CbClasseProfessor.Text;

                model.Editar(professor);
                MessageBox.Show("Professor editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar " + ex.Message);
                throw;
            }
        }

        public void Salvar(Professor professor)
        {
            try
            {
                professor.Nome = TextNomeProfessor.Text;
                professor.Sexo = CbSexoProfessor.Text;
                professor.Idade = Convert.ToDateTime(idadeProfessor.Text);
                professor.Classe = CbClasseProfessor.Text;
                professor.Materia = TxtMateria.Text;
                professor.Codigo = Convert.ToInt16(CodigoProfessor.Text);
            

                model.Salvar(professor);
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
                throw;
            }
        }

        private void Excluir(Professor professor)
        {
            try
            {
                professor.Codigo = Convert.ToInt16(CodigoProfessor.Text);

                model.Excluir(professor);
                MessageBox.Show("Professor excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir professor" + ex.Message);
                throw;
            }
        }
        #endregion

        #region KeyPress

        private void TextNomeProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)))
                e.Handled = true;
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)))
                e.Handled = true;
        }
        #endregion

        #region campos
        public void HabilitarCampo()
        {
            TextNomeProfessor.Enabled = true;
            CbSexoProfessor.Enabled = true;
            TxtMateria.Enabled = true;
            CbClasseProfessor.Enabled = true;
            CodigoProfessor.Enabled = true;
            idadeProfessor.Enabled = true;
          
        }
        public void DesabilitarCampo()
        {
            TextNomeProfessor.Enabled = false;
            CbSexoProfessor.Enabled = false;
            TxtMateria.Enabled = false;
            CbClasseProfessor.Enabled = false;
            CodigoProfessor.Enabled = false;
            idadeProfessor.Enabled = false;
          
        }
        public void LimparCampo()
        {
            TextNomeProfessor.Text = "";
            CbSexoProfessor.Text = "";
            TxtMateria.Text = "";
            CbClasseProfessor.Text = "";
            CodigoProfessor.Text = "";
            idadeProfessor.Text = "";
           
        }
        #endregion

        private void BtnVoltarAreaProfessor_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new AreaAdmView()));
            t.Start();
        }

        private void BtnExcluirProfessor_Click(object sender, EventArgs e)
        {
                if (TextNomeProfessor.Text == "" || CodigoProfessor.Text == "" )
                {
                    MessageBox.Show("Selecione na tabela um registro para excluir!");
                    return;
                }
                if (MessageBox.Show("Você deseja excluir o Professor?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Professor professor = new Professor();
                    Excluir(professor);
                    ListarProf();
                };
        }
        private void GridProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodigoProfessor.Text = GridProfessor.CurrentRow.Cells[0].Value.ToString();
            TextNomeProfessor.Text = GridProfessor.CurrentRow.Cells[1].Value.ToString();
            idadeProfessor.Text = GridProfessor.CurrentRow.Cells[2].Value.ToString();
            CbSexoProfessor.Text = GridProfessor.CurrentRow.Cells[3].Value.ToString(); 
            CbClasseProfessor.Text = GridProfessor.CurrentRow.Cells[4].Value.ToString(); 
            TxtMateria.Text = GridProfessor.CurrentRow.Cells[5].Value.ToString();
        }
    }

}
