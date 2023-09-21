using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Escola_Forms.Entities
{
    public class Professor
    {
        string nome, sexo, sala, materia;
        int id, senha;
        DateTime idade;

        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Sala { get => sala; set => sala = value; }
        public string Materia { get => materia; set => materia = value; }
        public int Id { get => id; set => id = value; }
        public DateTime Idade { get => idade; set => idade = value; }
        public int Senha { get => senha; set => senha = value; }
    }
}
