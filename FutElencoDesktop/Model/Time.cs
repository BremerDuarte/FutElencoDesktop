using System.ComponentModel.DataAnnotations.Schema;

namespace FutElencoDesktop.Model
{
	[Table("Times")]
	public class Time
	{
		public int ID { get; set; }
		public string NomeCompleto { get; set; }
		public string Nome { get; set; }
		public string Sigla { get; set; }
	}
}
