using Sistema_Escola_Forms.Entities;
using System;
using System.Windows.Forms;
using Sistema_Escola_Forms.Model;


namespace Sistema_Escola_Forms.View
{
    public partial class LoginProfessorView : Form
    {
        ProfessorModel model = new ProfessorModel();

        public LoginProfessorView()
        {
            InitializeComponent();
        }

        private void LoginProfessorView_Load(object sender, EventArgs e)
        {
            ListarProf();
        }

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

        public void Login(Professor professor)
        {
            if (CodigoProfessor.Text == "" )
            {
                MessageBox.Show("Preencha o usuario!");
                CodigoProfessor.Focus();
                return;
            }
            
            try
            {
                professor.Nome = CodigoProfessor.Text;

                professor = model.Login(professor);
                MessageBox.Show("Usuario Encontrado");


                AdicionarNotaView form = new AdicionarNotaView();
                this.Hide();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
                throw;
            }
        }
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
           
        }
       
        private void GridProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodigoProfessor.Text = GridProfessor.CurrentRow.Cells[0].Value.ToString();
            TextNomeProfessor.Text = GridProfessor.CurrentRow.Cells[1].Value.ToString();
            CbClasseProfessor.Text = GridProfessor.CurrentRow.Cells[2].Value.ToString();
            TxtMateria.Text = GridProfessor.CurrentRow.Cells[3].Value.ToString();
        }
    }
}


