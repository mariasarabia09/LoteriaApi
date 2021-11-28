using LoteriaApi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace LoteriaApi.Data
{
    public class LoteriaContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public LoteriaContext() : base("Loteria") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var cardModelBuilder = modelBuilder.Entity<Card>();

            cardModelBuilder.ToTable("Card");
            cardModelBuilder.HasKey(x => x.Id);
            cardModelBuilder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            cardModelBuilder.Property(x => x.SpanishName).IsRequired().HasMaxLength(100);
            cardModelBuilder.Property(x => x.EnglishName).IsRequired().HasMaxLength(100);
            cardModelBuilder.Property(x => x.ImageUrl).IsRequired().HasMaxLength(250);
        }
    }
}