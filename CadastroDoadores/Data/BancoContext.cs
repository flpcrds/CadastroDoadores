using CadastroDoadores.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CadastroDoadores.Data
{
    public partial class BancoContext : DbContext
    {
        public BancoContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-VD7RQPJ\\MSSQLSERVER12,;Database=DB_SistemaDoadores;User Id=sa;Password=sangue1234;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);   
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            
        }

        public DbSet<ContatoModel> Doadores { get; set; } 
    }
}
