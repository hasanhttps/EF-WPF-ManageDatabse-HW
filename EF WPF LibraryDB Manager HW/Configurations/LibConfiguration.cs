using System;
using System.Linq;
using System.Text;
using EF_Practise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library_Database_CodeFirst_HW.Configurations;

public class LibConfiguration : IEntityTypeConfiguration<Lib> {

    public void Configure(EntityTypeBuilder<Lib> builder) {

        builder.HasKey(p => p.Id);
        builder.Property(p => p.FirstName).IsRequired();
        builder.Property(p => p.LastName).IsRequired();

        builder.HasMany(p => p.T_Cards).WithOne(p => p.Lib).HasForeignKey(p => p.Id_Lib);
        builder.HasMany(p => p.S_Cards).WithOne(p => p.Lib).HasForeignKey(p => p.Id_Lib);
    }
}
