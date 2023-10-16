using System;
using System.Linq;
using System.Text;
using EF_Practise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library_Database_CodeFirst_HW.Configurations;

public class ThemeConfiguration : IEntityTypeConfiguration<Theme> {

    public void Configure(EntityTypeBuilder<Theme> builder) {

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired();

        builder.HasMany(p => p.Books).WithOne(p => p.Theme).HasForeignKey(p => p.Id_Themes);
    }
}
