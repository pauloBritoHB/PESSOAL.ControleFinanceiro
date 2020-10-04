using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PESSOAL.ControleFinanceiro.MODELS;
using System;


namespace PESSOAL.ControleFinanceiro.CONTEXT.Types
{
    class OperacaoTypeConfiguration : IEntityTypeConfiguration<Operacao>
    {
        public void Configure(EntityTypeBuilder<Operacao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descrição).IsRequired().HasMaxLength(80);
        }
    }
}
