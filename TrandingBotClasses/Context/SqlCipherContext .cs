using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2019.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace TrandingBotClasses.Context
{
    


        public class SqlCipherContext : DbContext
        { 

           


            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<CBinance> Contas { get; set; }
            public DbSet<GoogleSheets> Planilhas { get; set; }
            public DbSet<Trade> Trades { get; set; }
            
            public static string DEFAULTDBFILE = "App.db";
            private readonly string dbFile = DEFAULTDBFILE;
            
            private SqliteConnection connection;

            public SqlCipherContext(){}

            public SqlCipherContext(string databaseFile)
            {
                if (!string.IsNullOrEmpty(databaseFile)) dbFile = databaseFile;
            }

            public SqlCipherContext(SqliteConnection sqliteConnection)
            {
                if (!string.IsNullOrEmpty(sqliteConnection?.DataSource)) dbFile = sqliteConnection.DataSource;
                connection = sqliteConnection;
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                connection ??= InitializeSQLiteConnection(dbFile);
                optionsBuilder.UseSqlite(connection);
            }

            private static SqliteConnection InitializeSQLiteConnection(string databaseFile)
            {

            var connectionString = new SqliteConnectionStringBuilder
            {
                DataSource = databaseFile,
                Password = "TBKrmv9d2345732117"// PRAGMA key is being sent from EF Core directly after opening the connection
                };
                return new SqliteConnection(connectionString.ToString());
            }

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
                    .HasMaxLength(100);


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

            //---------------------------------------------------------------------Trade------------------------------------------------------------------------------------------------

            var Trade = mb.Entity<Trade>();

                Trade
                   .HasKey(p => p.TradeId);

                Trade
                   .Property(p => p.TradeId);
   
                Trade
                   .HasOne(c => c.Conta)
                   .WithMany(d => d.Trades)
                    .OnDelete(DeleteBehavior.Cascade);

            }

        }
  }
