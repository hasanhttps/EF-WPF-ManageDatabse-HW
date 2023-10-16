using System;
using System.Linq;
using System.Text;
using EF_Practise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library_Database_CodeFirst_HW.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student> {

    public void Configure(EntityTypeBuilder<Student> builder) {

        builder.HasKey(p => p.Id);
        builder.Property(p => p.FirstName).IsRequired();
        builder.Property(p => p.LastName).IsRequired();
        builder.Property(p => p.Id_Group).IsRequired();
        builder.Property(p => p.Term).IsRequired();

        builder.HasMany(p => p.S_Cards).WithOne(p => p.Student).HasForeignKey(p => p.Id_Student);
        builder.HasOne(p => p.Group).WithMany(p => p.Students).HasForeignKey(p => p.Id_Group);
    }
}
