using System;

namespace SalesWebMvcCourse.Models
{
	public class Aluno
	{
		public int IdAluno_PK { get; set; }
		public int Matricula { get; set; }
		public string Nome { get; set; }
		public DateTime DataNascimento { get; set; }
		public string NomePai { get; set; }
		public string NomeMae { get; set; }
		public string NomeResponsavel { get; set; }
		public string GrauResponsavel { get; set; }

	}
}

