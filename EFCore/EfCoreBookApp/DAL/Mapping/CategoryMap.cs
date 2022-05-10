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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).HasDefaultValue("No Info.");
            builder.HasData(
                new Category { CategoryId = 1, CategoryName = "Health" },
                new Category { CategoryId = 2, CategoryName = "Computer" },
                new Category { CategoryId = 3, CategoryName = "Novel" }
                );
        }
    }
}
