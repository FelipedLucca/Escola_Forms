using Sistema_Escola_Forms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Escola_Forms.Entities
{
    public class Nota : Entidades.Aluno
    {
        double nota1, nota2, nota3, nota4;
        double resultado;

        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public double Nota4 { get => nota4; set => nota4 = value; }
        public double media { get => resultado; set => resultado = value; }
    }
}
