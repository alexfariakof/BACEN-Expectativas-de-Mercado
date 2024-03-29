﻿using Expectativas_de_Mercado.Model.Aggregates;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Expectativas_de_Mercado.Model.ValueObjects;
using Expectativas_de_Mercado.Model.Core;

namespace Expectativas_de_Mercado.Repository.Mapping;
public class ExpectativasMercadoMap : IEntityTypeConfiguration<ExpectativasMercado>
{
    public void Configure(EntityTypeBuilder<ExpectativasMercado> builder)
    {
        builder.ToTable(nameof(ExpectativasMercado));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();               
        builder.Property(x => x.Data).IsRequired().HasMaxLength(100);
        builder.Property(x => x.DataReferencia);
        builder.Property(x => x.Reuniao);

        builder.OwnsOne<Media>(e => e.Media, c =>
        {
            c.Property(x => x.Value).HasColumnName("Media");
        });

        builder.OwnsOne<Mediana>(e => e.Mediana, c =>
        {
            c.Property(x => x.Value).HasColumnName("Mediana");
        });

        builder.OwnsOne<DesvioPadrao>(e => e.DesvioPadrao, c =>
        {
            c.Property(x => x.Value).HasColumnName("DesvioPadrao");
        });

        builder.Property(x => x.Minimo);
        builder.Property(x => x.Maximo);
        builder.Property(x => x.NumeroRespondentes);
        builder.Property(x => x.BaseCalculo);

        
    }
}