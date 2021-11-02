namespace FitLife.API.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        public string Nome { get; set; }

        public string  CPF { get; set; }

        public string DataNasc { get; set; }

        public string Foto { get; set; }

        public bool Ativo { get; set; }
    }
}