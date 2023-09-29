using System;
using System.Windows.Forms;
using Sistema_Escola_Forms.Model;
using System.Threading;
using Sistema_Escola_Forms.view;
using Sistema_Escola_Forms.Validation;
using Sistema_Escola_Forms.Entities;
using System.Drawing;
using Sistema_Escola_Forms.Entidades;

namespace Sistema_Escola_Forms.View
{

    public partial class AdicionarNotaView : Form
    {
        ProfessorModel modelProf = new ProfessorModel();
        BoletimModel boletimModel = new BoletimModel();
        Metodo metodo = new Metodo();

        public AdicionarNotaView()
        {
            InitializeComponent();
        }

        private void Boletim_Load(object sender, EventArgs e)
        {
            NotaAluno();
        }


        public void NotaAluno()
        {
            try
            {

                GridNotas.AutoGenerateColumns = false;
                GridNotas.DataSource = boletimModel.NotaAluno();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void SalvarNota()
        {
            try
            {
                Boletim boletim = new Boletim();

                // colocar um try parse aqui 

                boletim.Nota1 = Convert.ToDouble(txtNota01.Text);
                boletim.Nota2 = Convert.ToDouble(txtNota02.Text);
                boletim.Nota3 = Convert.ToDouble(txtNota03.Text);
                boletim.Nota4 = Convert.ToDouble(txtNota04.Text);
                boletim.Media = Convert.ToDouble(labelMedia.Text);
                boletim.RaAluno = Convert.ToInt32(TxtRaAluno.Text);
                boletim.Situacao = LabelSituacao.Text;

                boletimModel.SalvarNota(boletim);
                MessageBox.Show("Notas salvas com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
                throw;
            }
        }
        private void List()
        {
            try
            {
                GridNotas.DataSource = boletimModel.NotaAluno();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new AreaAdmView()));
            t.Start();
        }

        public void BtnSalvarNota_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja atribuir essas notas?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SalvarNota();
                List();
            };
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNota01.Text == "" || txtNota02.Text == "" || txtNota03.Text == "" || txtNota04.Text == "")
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos!");
                return;
            }

            double n1 = Convert.ToDouble(txtNota01.Text);
            double n2 = Convert.ToDouble(txtNota02.Text);
            double n3 = Convert.ToDouble(txtNota03.Text);
            double n4 = Convert.ToDouble(txtNota04.Text);

            double media;

            if (n1 < 0 || n1 > 10)
            {
                txtNota01.Text = "A Boletim 01 precisa estar entre 0 e 10!";
                return;
            }
            if (n2 < 0 || n2 > 10)
            {
                txtNota02.Text = "A Boletim 02 precisa estar entre 0 e 10! ";
                return;
            }
            if (n3 < 0 || n3 > 10)
            {
                txtNota03.Text = "A Boletim 03 precisa estar entre 0 e 10! ";
                return;
            }
            if (n4 < 0 || n4 > 10)
            {
                txtNota04.Text = "A Boletim 04 precisa estar entre 0 e 10! ";
                return;
            }
            else
            {
                media = (n1 + n2 + n3 + n4) / 4;
                labelMedia.Text = media.ToString();
            }

            if(media >= 7)
            {
                LabelSituacao.Text = "Aprovado";
                LabelSituacao.ForeColor = Color.Green;
            }
            else
            {
                LabelSituacao.Text = "Reprovado";
                LabelSituacao.ForeColor = Color.Red;
            }
        }

        private void txtNota01_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 8)
                e.Handled = true;
            //indica se o evento foi tratado
        }

        private void txtNota01_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtRaAluno.Text = GridNotas.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {




        }





































        //public void Login(Professor professor)
        //{
        //    if (TxtLogin.Text == "")
        //    {
        //        MessageBox.Show("Preencha o usuario!");
        //        TxtLogin.Focus();
        //        return;
        //    }

        //    try
        //    {
        //        professor.Nome = TxtLogin.Text;
        //        professor = modelProf.Login(professor);

        //        if (professor.Nome == null)
        //        {

        //            MessageBox.Show("Usuario ou senha incorretos");
        //            return;
        //        }
        //        MessageBox.Show("Usuario Encontrado");

        //        AdicionarNotaView form = new AdicionarNotaView();
        //        this.Hide();
        //        form.Show();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao salvar " + ex.Message);
        //        throw;
        //    }
        //}
    }   
}

