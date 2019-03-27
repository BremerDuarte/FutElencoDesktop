using System.ComponentModel.DataAnnotations.Schema;

namespace FutElencoDesktop.Model
{
	[Table("Posicoes")]
	public class Posicao
	{
		public int ID { get; set; }
		public string Nome { get; set; }
		public string Abreviacao { get; set; }
	}
}
