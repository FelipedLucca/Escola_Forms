using Sistema_Escola_Forms.Entidades;
using Sistema_Escola_Forms.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Escola_Forms.Entities;
using Sistema_Escola_Forms.Model;
using Sistema_Escola_Forms.View;
using Sistema_Escola_Forms.view;

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
        }

        public void Login(Professor professor)
        {
            if (TxtLogin.Text == "")
            {
                MessageBox.Show("Preencha o usuario!");
                TxtLogin.Focus();
                return;
            }
            if (TxtSenha.Text == "")
            {
                MessageBox.Show("Preencha a senha!");
                TxtLogin.Focus();
                return;
            }
            try
                {
                  professor.Nome = TxtLogin.Text;
                  professor.Senha = Convert.ToInt32(TxtSenha.Text);
                    professor = model.Login(professor);

                if (professor.Nome == null)
                    {

                    MessageBox.Show("Usuario ou senha incorretos");
                    return;
                    }
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
            Entities.Professor professor = new Entities.Professor();
            Login(professor);    
        }
        private void TxtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
