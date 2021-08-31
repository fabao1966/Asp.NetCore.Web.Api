using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Aluno
    {
        public Aluno() { }


        public Aluno(int id, string nome, string sobrenome, string tefefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Tefefone = tefefone;

        }
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Tefefone { get; set; }

        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}