using Projet_LeagueofLegends.Models;
using System.Collections;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projet_LeagueofLegends.DAL
{
    public class LeagueContext : DbContext
    {

        public LeagueContext() : base("LeagueContext")
        {
        }

        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<Resultat> Resultats { get; set; }
        public DbSet<Classement> Classements { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}