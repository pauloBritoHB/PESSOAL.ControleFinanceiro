using Microsoft.EntityFrameworkCore;
using PESSOAL.ControleFinanceiro.MODELS;
using System;

namespace PESSOAL.ControleFinanceiro.CONTEXT
{
    public class BancoContext : DbContext
    {
        public BancoContext()
        {

        }
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NT-04777\\SQLEXPRESS;Initial Catalog=ControleFinanceiro;Integrated Security=True;MultipleActiveResultSets=True");
        }

        public DbSet<A_Pagar> Contas_A_Pagar { get; set; }
        public DbSet<Carteira> Carteiras { get; set; }
        public DbSet<Operacao> Operacoes{ get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
