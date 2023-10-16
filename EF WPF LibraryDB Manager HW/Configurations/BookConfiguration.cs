using System;
using System.Linq;
using System.Text;
using EF_Practise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library_Database_CodeFirst_HW.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book> {
    
    public void Configure(EntityTypeBuilder<Book> builder) {

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Pages).IsRequired();
        builder.Property(p => p.YearPress).IsRequired();
        builder.Property(p => p.Id_Themes).IsRequired();
        builder.Property(p => p.Id_Press).IsRequired();
        builder.Property(p => p.Id_Author).IsRequired();
        builder.Property(p => p.Id_Category).IsRequired();
        builder.Property(p => p.Quantity).IsRequired();
        builder.Property(p => p.Comment);

        builder.HasMany(p => p.S_Cards).WithOne(p => p.Book).HasForeignKey(p => p.Id_Book);
        builder.HasMany(p => p.T_Cards).WithOne(p => p.Book).HasForeignKey(p => p.Id_Book);
        builder.HasOne(p => p.Category).WithMany(p => p.Books).HasForeignKey(p => p.Id_Category);
        builder.HasOne(p => p.Author).WithMany(p => p.Books).HasForeignKey(p => p.Id_Author);
        builder.HasOne(p => p.Theme).WithMany(p => p.Books).HasForeignKey(p => p.Id_Themes);
        builder.HasOne(p => p.Press).WithMany(p => p.Books).HasForeignKey(p => p.Id_Press);
    }

}