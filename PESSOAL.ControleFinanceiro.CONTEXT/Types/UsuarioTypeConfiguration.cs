using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PESSOAL.ControleFinanceiro.MODELS;
using System;


namespace PESSOAL.ControleFinanceiro.CONTEXT.Types
{
    class UsuarioTypeConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Login).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(30);
            builder.HasMany(x => x.Carteiras).WithOne().HasForeignKey(x => x.UsuarioId);
        }
    }
}
