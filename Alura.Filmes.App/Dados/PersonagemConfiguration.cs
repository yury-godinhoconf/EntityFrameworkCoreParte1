using Alura.Desafio.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    public class PersonagemConfiguration : IEntityTypeConfiguration<Personagem>
    {
        public void Configure(EntityTypeBuilder<Personagem> builder)
        {
            builder
                .ToTable("lotr_characters");

            builder
                .Property(p => p.Id)
                .HasColumnName("character_id");

            builder
                .Property(p => p.Nome)
                .HasColumnName("character_name")
                .HasColumnType("varchar(60)")
                .IsRequired();
        }
    }
}
