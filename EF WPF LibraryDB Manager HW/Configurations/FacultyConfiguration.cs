using System;
using System.Linq;
using System.Text;
using EF_Practise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library_Database_CodeFirst_HW.Configurations;

public class FacultyConfiguration : IEntityTypeConfiguration<Faculty> {

    public void Configure(EntityTypeBuilder<Faculty> builder) {

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired();

        builder.HasMany(p => p.Groups).WithOne(p => p.Faculty).HasForeignKey(p => p.Id_Faculty);
    }
}
