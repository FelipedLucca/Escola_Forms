namespace Sistema_Escola_Forms.Entities
{
    public class Professor : Pessoa
    {
        string classe, materia;
        int id;
       
        public string Classe { get => classe; set => classe = value; }
        public string Materia { get => materia; set => materia = value; }
        public int Id { get => id; set => id = value; }

        //Mudar aqui tb

    }
}
