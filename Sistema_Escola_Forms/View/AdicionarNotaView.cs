using System;
using System.Windows.Forms;
using Sistema_Escola_Forms.Model;
using System.Threading;
using Sistema_Escola_Forms.view;
using Sistema_Escola_Forms.Entities;
using Sistema_Escola_Forms.Validation;

namespace Sistema_Escola_Forms.View
{

    public partial class AdicionarNotaView : Form
    {
        ProfessorModel modelProf = new ProfessorModel();
        NotaModel modelNota = new NotaModel();
        Metodo metodo = new Metodo();

        public AdicionarNotaView()
        {
            InitializeComponent();
        }

        private void Boletim_Load(object sender, EventArgs e)
        {
            NotaAluno();
            
            CbBuscarProf.ValueMember = "classe";
            CbBuscarProf.DisplayMember = "nome";
            CbBuscarProf.DataSource = modelProf.listarProf();

            // deixando o Data source por ultimo ele ja vai saber o que procurar (listar professor).
            //o programa vai procurar pelo ValueMember 
        }

        public void NotaAluno()
        {
            try
            {

                GridNotas.AutoGenerateColumns = false;
                GridNotas.DataSource = modelNota.NotaAluno();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ListarNota()
        {
            try
            {
                GridNotas.DataSource = modelNota.ListarNota();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SalvarNota(Nota nota)
        {
            try
            {
                // colocar um try parse aqui 

                nota.Nota1 = Convert.ToDouble(txtNota01.Text);
                nota.Nota2 = Convert.ToDouble(txtNota02.Text);
                nota.Nota3 = Convert.ToDouble(txtNota03.Text);
                nota.Nota4 = Convert.ToDouble(txtNota04.Text);
                nota.media = Convert.ToDouble(labelMedia.Text);

                modelNota.SalvarNota(nota);
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
                GridNotas.DataSource = modelNota.ListarNota();
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

        public void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja atribuir essas notas?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Nota nota = new Nota();
                SalvarNota(nota);
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
                labelNota22.Text = "A nota 01 precisa estar entre 0 e 10!";
                return;
            }
            if (n2 < 0 || n2 > 10)
            {
                labelNota33.Text = "A nota 02 precisa estar entre 0 e 10! ";
                return;
            }
            if (n3 < 0 || n3 > 10)
            {
                //label44.Text = "A nota 03 precisa estar entre 0 e 10! ";
                return;
            }
            if (n4 < 0 || n4 > 10)
            {
                label55.Text = "A nota 04 precisa estar entre 0 e 10! ";
                return;
            }
            else
            {
                media = (n1 + n2 + n3 + n4) / 4;
                labelMedia.Text = media.ToString();
            }
        }

        private void txtNota01_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 8)
                e.Handled = true;
            //indica se o evento foi tratado
        }

        #region Campos
        public void HabilitarCampo()
        {
            txtNota01.Enabled = true;
            txtNota02.Enabled = true;

            txtNota03.Enabled = true;
            txtNota04.Enabled = true;

        }
        public void DesabilitarCampo()
        {
            txtNota01.Enabled = false;
            txtNota02.Enabled = false;

            txtNota03.Enabled = false;
            txtNota04.Enabled = false;
        }
        public void LimparCampo()
        {
            txtNota01.Text = "";
            txtNota02.Text = "";
            txtNota03.Text = "";
            txtNota04.Text = "";
        }
        #endregion

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            //Login(professor);
        }

        private void CbBuscarProf_TextChanged(object sender, EventArgs e)
        {

            string professor_classe = CbBuscarProf.SelectedValue.ToString();

            GridNotas.AutoGenerateColumns = false;
            GridNotas.DataSource = modelNota.Buscar(professor_classe);
            textBoxCodigo.Text = GridNotas.CurrentRow.Cells[7].Value.ToString(); 
            TxtMateria.Text = GridNotas.CurrentRow.Cells[8].Value.ToString();
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

