using EfCoreBookApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBookApp.DAL.Mapping
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.AuthorId);

            builder.Property(a => a.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Ignore(a => a.FullName);

            builder.HasData(
                new Author { AuthorId=1 ,FirstName="Zafer",LastName="Cömert"},
                new Author { AuthorId=2,FirstName="Ahmet",LastName="Yıldırım"},
                new Author { AuthorId=3,FirstName="Fatih",LastName="Çelik"}
                );

            builder.Property(a => a.FirstName)
                .IsRequired();

            builder.Property(a => a.LastName)
                .IsRequired();
        }
    }
}
