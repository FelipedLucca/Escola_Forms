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
        NotaModel model = new NotaModel();
        Metodo metodo = new Metodo();

        public AdicionarNotaView()
        {
            InitializeComponent();
        }

        private void Boletim_Load(object sender, EventArgs e)
        {
            ListarNota();
        }

        public void ListarNota()
        {
            try
            {
                GridNotas.DataSource = model.ListarNota();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void Validacao(double n1, double n2, double n3, double n4)
        {
           metodo.ValidacaoNotas(n1, n2, n3, n4);
        }
        public void SalvarNota(Nota nota)
        {
            try
            {
                nota.Nota1 = Convert.ToDouble(txtNota01.Text);
                nota.Nota2 = Convert.ToDouble(txtNota02.Text);
                nota.Nota3 = Convert.ToDouble(txtNota03.Text);
                nota.Nota4 = Convert.ToDouble(txtNota04.Text);
             
                nota.media = Convert.ToDouble(labelMedia.Text);

                model.SalvarNota(nota);
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
                GridNotas.DataSource = model.ListarNota();
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new AreaProfessorView()));
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

            Validacao(n1, n2, n3, n4);

            double media, valor, soma;
            soma = 0;

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    valor = Convert.ToDouble(((TextBox)controle).Text);
                    soma += valor;
                }

                media = soma / 4;
                this.Controls["labelMedia"].Text = media.ToString();
            }
        }
        private void txtNota01_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            metodo.NotasDecimais(sender, e);    
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
    
    }
}

