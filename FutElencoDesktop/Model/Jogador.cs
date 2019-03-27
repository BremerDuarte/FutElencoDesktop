using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FutElencoDesktop.Model
{
	[Table("Jogadores")]
	public class Jogador
	{
		public int ID { get; set; }
		public string Nome { get; set; }
		public string Apelido { get; set; }
		public DateTime DataNascimento { get; set; }
		public Posicao Posicao { get; set; }
		public Time Time { get; set; }

		public string NomePosicao
		{
			get { return Posicao == null ? string.Empty : Posicao.Nome; }
		}

		public string NomeTime
		{
			get { return Time == null ? string.Empty : Time.Nome; }
		}
	}
}
