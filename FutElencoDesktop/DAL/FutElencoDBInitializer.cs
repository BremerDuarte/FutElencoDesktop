using FutElencoDesktop.Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace FutElencoDesktop.DAL
{
	public class FutElencoDBInitializer : DropCreateDatabaseIfModelChanges<FutElencoContext>
	{
		protected override void Seed(FutElencoContext context)
		{
			#region posicoes
			var posicoes = new List<Posicao>()
			{
				new Posicao {Nome = "Goleiro", Abreviacao = "GOL"},
				new Posicao {Nome = "Zagueiro", Abreviacao = "ZAG"},
				new Posicao {Nome = "Lateral Direito", Abreviacao = "LAD"},
				new Posicao {Nome = "Lateral Esquerdo", Abreviacao = "LAE"},
				new Posicao {Nome = "Volante", Abreviacao = "VOL"},
				new Posicao {Nome = "Meia", Abreviacao = "MEI"},
				new Posicao {Nome = "Atacante", Abreviacao = "ATA"}
			};
			

			posicoes.ForEach(posicao => context.Posicoes.Add(posicao));
			context.SaveChanges();
			#endregion

			#region times
			var times = new List<Time>()
			{
				new Time {NomeCompleto = "Jogadores Sem Time", Nome = "Sem Time", Sigla = ""},
				new Time {NomeCompleto = "Clube Atlético Mineiro", Nome = "Atlético-MG", Sigla = "CAM"},
				new Time {NomeCompleto = "Botafogo de Futebol e Regatas", Nome = "Botafogo", Sigla = "BFR"},
				new Time {NomeCompleto = "Sport Club Corinthians Paulista", Nome = "Corinthians", Sigla = "SCCP"},
				new Time {NomeCompleto = "Cruzeiro Esporte Clube", Nome = "Cruzeiro", Sigla = "CEC"},
				new Time {NomeCompleto = "Clube das Regatas Flamengo", Nome = "Flamengo", Sigla = "CRF"},
				new Time {NomeCompleto = "Fluminense Football Club", Nome = "Fluminense", Sigla = "FFC"},
				new Time {NomeCompleto = "Grêmio Foot-Ball Porto Alegrense", Nome = "Grêmio", Sigla = "GFPA"},
				new Time {NomeCompleto = "Sport Club Internacional", Nome = "Internacional", Sigla = "SCI"},
				new Time {NomeCompleto = "Sociedade Esportiva Palmeiras", Nome = "Palmeiras", Sigla = "SEP"},
				new Time {NomeCompleto = "São Paulo Futebol Clube", Nome = "São Paulo", Sigla = "SPFC"},
				new Time {NomeCompleto = "Santos Futebol Clube", Nome = "Santos", Sigla = "SFC"},
				new Time {NomeCompleto = "Club de Regatas Vasco da Gama", Nome = "Vasco da Gama", Sigla = "CRVG"},
			};

			times.ForEach(time => context.Times.Add(time));
			context.SaveChanges();
			#endregion
		}
	}
}
