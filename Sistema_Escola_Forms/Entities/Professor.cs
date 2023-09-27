using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Escola_Forms.Entities
{
    public class Professor
    {
        string nome, sexo, classe, materia;
        int codigo, senha;
        DateTime idade;

        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Idade { get => idade; set => idade = value; }
        public string Classe { get => classe; set => classe = value; }
        public string Materia { get => materia; set => materia = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Senha { get => senha; set => senha = value; }
    }
}
