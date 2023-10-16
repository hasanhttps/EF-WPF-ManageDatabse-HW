using System;
using EF_Practise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library_Database_CodeFirst_HW.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author> {

    public void Configure(EntityTypeBuilder<Author> builder) {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.FirstName).IsRequired();
        builder.Property(p => p.LastName).IsRequired();
        builder.HasMany(p => p.Books).WithOne(p => p.Author).HasForeignKey(p => p.Id_Author);
    }
}
