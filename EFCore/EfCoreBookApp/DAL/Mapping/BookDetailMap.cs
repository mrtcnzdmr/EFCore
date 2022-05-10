using EfCoreBookApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EfCoreBookApp.DAL.Mapping
{
    public partial class BookMap
    {
        public class BookDetailMap : IEntityTypeConfiguration<BookDetail>
        {
            public void Configure(EntityTypeBuilder<BookDetail> builder)
            {
                builder.HasKey(bd => bd.BookDetailId);

                builder.Property(bd => bd.ISSN)
                    .IsRequired()
                    .HasDefaultValue("0000-0000-0000");

                builder.Property(bd => bd.Year)
                    .HasDefaultValue(DateTime.Now.Year);

                builder.HasOne(bd => bd.Book)
                    .WithOne(x => x.BookDetail)
                    .HasForeignKey<BookDetail>(bd => bd.BookId)
                    .OnDelete(DeleteBehavior.Cascade);
                
                    
                    
            }
        }
    }
}
