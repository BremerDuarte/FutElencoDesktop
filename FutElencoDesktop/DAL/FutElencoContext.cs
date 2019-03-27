using FutElencoDesktop.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FutElencoDesktop.DAL
{
	public class FutElencoContext : DbContext
	{
		public DbSet<Jogador> Jogadores { get; set; }
		public DbSet<Posicao> Posicoes { get; set; }
		public DbSet<Time> Times { get; set; }

		public FutElencoContext() : base("FutElencoContext") {
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
