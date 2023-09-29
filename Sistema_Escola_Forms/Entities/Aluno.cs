using Sistema_Escola_Forms.Entities;

namespace Sistema_Escola_Forms.Entidades
{
    public class Aluno : Pessoa
    {
        string sala;
        int ra;
        public string Classe { get => sala; set => sala = value; }
        public int RA { get => ra; set => ra = value; }


        //mudar aqui tambiem
    }
}
