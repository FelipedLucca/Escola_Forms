using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Escola_Forms.Entidades
{
    public class Aluno
    {
        string nome, sexo;
       
        DateTime nascimento;
        string sala;
        int ra;

        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Sala { get => sala; set => sala = value; }
        public int RA { get => ra; set => ra = value; }
    }
}
