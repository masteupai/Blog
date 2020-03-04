using BlogEsta.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEsta.Data.Mapping
{
    public class BlogMapping : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().HasColumnType("integer");
            builder.Property(x => x.Url).IsRequired().HasMaxLength(100).HasColumnName("Url").HasColumnType("varchar(50)");
            builder.Property(x => x.Titulo).IsRequired().HasMaxLength(50).HasColumnName("Titulo").HasColumnType("varchar(50)");
            builder.Property(x => x.Texto).IsRequired().HasMaxLength(255).HasColumnName("Texto").HasColumnType("varchar(255)");
            builder.Property(x => x.Autor).IsRequired().HasMaxLength(50).HasColumnName("Autor").HasColumnType("varchar(50)");
            builder.Property(x => x.Ativo).IsRequired().HasColumnName("Ativo").HasColumnType("bit");
            builder.Property(x => x.DateCriacao).IsRequired().HasColumnName("DataCriacao").HasColumnType("datetime");
        }
    }
}
