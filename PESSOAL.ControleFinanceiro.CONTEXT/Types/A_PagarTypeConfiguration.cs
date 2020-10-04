using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PESSOAL.ControleFinanceiro.MODELS;
using System;


namespace PESSOAL.ControleFinanceiro.CONTEXT.Types
{
    class A_PagaraTypeConfiguration : IEntityTypeConfiguration<A_Pagar>
    {
        public void Configure(EntityTypeBuilder<A_Pagar> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descrição).IsRequired().HasMaxLength(80);
        }
    }
}
