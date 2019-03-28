using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FutElencoDesktop.Model
{
	[Table("Jogadores")]
	public class Jogador
	{
		public int ID { get; set; }
		public int PosicaoID { get; set; }
		public int TimeID { get; set; }
		public string Nome { get; set; }
		public string Apelido { get; set; }
		public DateTime DataNascimento { get; set; }
		public virtual Posicao Posicao { get; set; }
		public virtual Time Time { get; set; }

		public virtual string NomePosicao
		{
			get { return Posicao == null ? string.Empty : Posicao.Nome; }
		}

		public virtual string NomeTime
		{
			get { return Time == null ? string.Empty : Time.Nome; }
		}
	}
}
