namespace aula30.Models
{
    public class Instituicao
    {
        public int Id { get; set; }

        public string Nome { get; set; }    

        public string Endereco { get; set; }

        public long Cnpj { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();

    }
}
