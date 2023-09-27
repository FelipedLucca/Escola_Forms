using Sistema_Escola_Forms.Entidades;
using System;
using System.Threading;
using System.Windows.Forms;
using Sistema_Escola_Forms.Model;
using System.Collections.Generic;

namespace Sistema_Escola_Forms.view
{
    public partial class NotaView : Form
    {
        AlunoModel model = new AlunoModel();
        public NotaView()
        {
            InitializeComponent();
        }

        //na parte da sala colocar uma label chumbada (de acordo com a materia do professor).

        private void CriarProfessorView_Load(object sender, EventArgs e)
        {
            Listar();
        }

        #region Crud

        public void Listar()
        {
            try
            {
                Grid.DataSource = model.listar();
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
        public void Editar(Aluno aluno)
        {
            try
            {
                aluno.RA = Convert.ToInt16(RaAluno.Text);
                aluno.Nome = TextNomeAluno.Text;
                aluno.Sexo = CbSexoAluno.Text;
                aluno.Nascimento = Convert.ToDateTime(idadeProfessor.Text);
                aluno.Sala = CbturmaAluno.Text;

                model.Editar(aluno);
                MessageBox.Show("Aluno editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar " + ex.Message);
                throw;
            }
        }
        public void Excluir(Aluno aluno)
        {
            try
            {
                aluno.RA = Convert.ToInt16(RaAluno.Text);

                model.Excluir(aluno);
                MessageBox.Show("Aluno excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir" + ex.Message);
                throw;
            }
        }
        #endregion

        #region buttons
        public void BtnVoltarAreaProfessor_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new AreaAdmView()));
            t.Start();
        }
        public void BtnCriar_Click(object sender, EventArgs e)
        {
           

            if (TextNomeAluno.Text == "")
            {
                MessageBox.Show("O aluno novo precisa ter um NOME!");
                return;
            }
            else if (CbSexoAluno.Text == "")
            {
                MessageBox.Show("O aluno novo precisa ter um SEXO!");
                return;
            }
            else if (CbturmaAluno.Text == "")
            {
                MessageBox.Show("O aluno novo precisa ter um TURMA!");
                return;
            }

            if (MessageBox.Show("Você deseja criar um aluno?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Aluno professor = new Aluno();
                Salvar(professor);
                Listar();
            };
        }
        //private void BtnNovo_Click(object sender, EventArgs e)
        //{
        //    HabilitarCampo();
        //    LimparCampo();

        //    Random random = new Random();
        //    int ra = random.Next(1000, 9000);

        //    //aqui eu preciso fazer uma verificação se um RA já existe

        //    RaAluno.Text = Convert.ToString(ra);
        //}
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja editar o aluno?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HabilitarCampo();
                Aluno aluno = new Aluno();
                Editar(aluno);
                Listar();
            };
        }
        private void BtnExcluirAluno_Click(object sender, EventArgs e)
        {
            if (RaAluno.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para excluir!");
                return;
            }
            if (MessageBox.Show("Você deseja excluir o aluno?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Aluno aluno = new Aluno();
                Excluir(aluno);
                Listar();
            };
        }

        #endregion

        #region Campos
        public void HabilitarCampo()
        {
            TextNomeAluno.Enabled = true;
            CbSexoAluno.Enabled = true;
            idadeProfessor.Enabled = true;
            CbturmaAluno.Enabled = true;
            RaAluno.Enabled = true;
            idadeProfessor.Enabled = true;
        }
        public void DesabilitarCampo()
        {
            TextNomeAluno.Enabled = false;
            CbSexoAluno.Enabled = false;
            idadeProfessor.Enabled = false;
            CbturmaAluno.Enabled = false;
            RaAluno.Enabled = false;
            idadeProfessor.Enabled = false;
        }
        public void LimparCampo()
        {
            TextNomeAluno.Text = "";
            CbSexoAluno.Text = "";
            idadeProfessor.Text = "";
            CbturmaAluno.Text = "";
            RaAluno.Text = "";
            idadeProfessor.Text = "";
        }
        #endregion

        private void TextNomeAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void Grid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            TextNomeAluno.Text = Grid.CurrentRow.Cells[0].Value.ToString();
            idadeProfessor.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            CbSexoAluno.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            CbturmaAluno.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            RaAluno.Text = Grid.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RaAluno.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para Editar!");
                return;
            }
            if (MessageBox.Show("Você deseja excluir editar o aluno?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Aluno aluno = new Aluno();
                Editar(aluno);
                Listar();
            };
        }

        private void BtnNovo_Click_1(object sender, EventArgs e)
        {
            HabilitarCampo();
            LimparCampo();

            Random random = new Random();
            int ra = random.Next(1000, 9000);
            RaAluno.Text = Convert.ToString(ra);  
        }
    }
}







