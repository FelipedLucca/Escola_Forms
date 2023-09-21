using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Escola_Forms.Entidades;
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
            Listar();
        }

        private void BtnNovoProfessor_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            LimparCampo();

            Random random = new Random();
            int id = random.Next(1000, 9000);

            // aqui eu preciso fazer uma verificação se um RA já existe

            IdProfessor.Text = Convert.ToString(id);
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja editar o professor?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HabilitarCampo();
                Professor professor = new Professor();
                Editar(professor);
                Listar();
            };
        }

        private void BtnCriarProfessor_Click(object sender, EventArgs e)
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
            else if (CbturmaProfessor.Text == "")
            {
                MessageBox.Show("O professor novo precisa ter um TURMA!");
                return;
            }
            else if (string.IsNullOrEmpty(TxtSenha.Text))
            {
                MessageBox.Show("O professor novo precisa de uma senha!");
                return;
            }

            if (MessageBox.Show("Você deseja criar um professor?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Professor professor = new Professor();
                Salvar(professor);
                Listar();
            };
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

        private void Editar(Professor professor)
        {
            try
            {
                professor.Id = Convert.ToInt16(IdProfessor.Text);
                professor.Nome = TextNomeProfessor.Text;
                professor.Sexo = CbSexoProfessor.Text;
                professor.Idade = Convert.ToDateTime(idadeProfessor.Text);
                professor.Materia = TxtMateria.Text;
                professor.Sala = CbturmaProfessor.Text;

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
                professor.Sala = CbturmaProfessor.Text;
                professor.Materia = TxtMateria.Text;
                professor.Id = Convert.ToInt16(IdProfessor.Text);
                professor.Senha = Convert.ToInt32(TxtSenha.Text);

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
                professor.Id = Convert.ToInt16(IdProfessor.Text);

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
            CbturmaProfessor.Enabled = true;
            IdProfessor.Enabled = true;
            idadeProfessor.Enabled = true;
            TxtSenha.Enabled = true;
        }
        public void DesabilitarCampo()
        {
            TextNomeProfessor.Enabled = false;
            CbSexoProfessor.Enabled = false;
            TxtMateria.Enabled = false;
            CbturmaProfessor.Enabled = false;
            IdProfessor.Enabled = false;
            idadeProfessor.Enabled = false;
            TxtSenha.Enabled = false;
        }
        public void LimparCampo()
        {
            TextNomeProfessor.Text = "";
            CbSexoProfessor.Text = "";
            TxtMateria.Text = "";
            CbturmaProfessor.Text = "";
            IdProfessor.Text = "";
            idadeProfessor.Text = "";
            TxtSenha.Text = "";
        }
        #endregion

        private void BtnVoltarAreaProfessor_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new AreaProfessorView()));
            t.Start();
        }

        private void BtnExcluirProfessor_Click(object sender, EventArgs e)
        {
                if (TextNomeProfessor.Text == "" || IdProfessor.Text == "" )
                {
                    MessageBox.Show("Selecione na tabela um registro para excluir!");
                    return;
                }
                if (MessageBox.Show("Você deseja excluir o Professor?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Professor professor = new Professor();
                    Excluir(professor);
                    Listar();
                };
        }
    }

}
