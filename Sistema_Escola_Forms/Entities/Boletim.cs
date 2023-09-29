using Sistema_Escola_Forms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Escola_Forms.Entities
{
    public class Boletim 
    {
        public int RaAluno { get; set; }

        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public double Media { get; set; }
        public string Situacao { get; set; }
    

    }
}
