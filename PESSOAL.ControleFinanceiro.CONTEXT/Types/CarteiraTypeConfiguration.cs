using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PESSOAL.ControleFinanceiro.MODELS;
using System;


namespace PESSOAL.ControleFinanceiro.CONTEXT.Types
{
    class CarteiraTypeConfiguration : IEntityTypeConfiguration<Carteira>
    {
        public void Configure(EntityTypeBuilder<Carteira> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Usuario).WithMany().HasForeignKey(x => x.UsuarioId);
        }
    }
}
