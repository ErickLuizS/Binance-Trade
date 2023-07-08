using Microsoft.EntityFrameworkCore;

namespace TrandingBotClasses.Context
{


    public class SqlServerContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(""); // String de conexão
        }

        

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CBinance> Contas { get; set; }
        public DbSet<GoogleSheets> Planilhas { get; set; }
        public DbSet<Trade> Trades { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {


            //Definindo os relacionamentos 

            var Cliente = mb.Entity<Cliente>();

            Cliente
              .HasOne(c => c.Conta)
              .WithOne(d => d.Cliente)
              .HasForeignKey<Cliente>(b => b.CBinanceId)
              .OnDelete(DeleteBehavior.Cascade);


            Cliente
              .HasOne(s => s.Sheets)
              .WithOne(d => d.Cliente)
              .HasForeignKey<Cliente>(b => b.GoogleSheetsId)
              .OnDelete(DeleteBehavior.Cascade);


            //---------------------------------------------------------------------Cliente-------------------------------------------------------------------------------------


            Cliente
                .HasKey(p => p.ClienteId);

            Cliente
                .Property(p => p.ClienteId);

            Cliente
                .Property(p => p.Nome)
                .HasMaxLength(110);


            //---------------------------------------------------------------------CBinance----------------------------------------------------------------------------------------


            var CBinance = mb.Entity<CBinance>();

            CBinance
               .HasKey(p => p.CBinanceId);

            CBinance
               .Property(p => p.CBinanceId)
               .HasColumnName("ContaId");

            CBinance
               .Property(p => p.apiKey)
               .HasMaxLength(100);

            CBinance
               .Property(p => p.apiSecret)
               .HasMaxLength(100);

            //---------------------------------------------------------------------GoogleSheets----------------------------------------------------------------------------------------

            var GoogleSheets = mb.Entity<GoogleSheets>();

            GoogleSheets
               .HasKey(p => p.GoogleSheetsId);

            GoogleSheets
               .Property(p => p.GoogleSheetsId)
               .HasColumnName("PlanilhaId");

            GoogleSheets
                .Property(p => p.SheetID)
                .HasMaxLength(100)
                .IsRequired(false);

            GoogleSheets
               .Property(p => p.TabName)
               .HasMaxLength(100)
               .IsRequired(false);


            //---------------------------------------------------------------------Trade----------------------------------------------------------------------------------------

           
            var Trade = mb.Entity<Trade>();

            Trade
                .HasKey(p => p.TradeId);

            Trade
                .HasOne(c => c.Conta)
                .WithMany(d => d.Trades)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}