using System;
using System.Linq;
using System.Text;
using EF_Practise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library_Database_CodeFirst_HW.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher> {

    public void Configure(EntityTypeBuilder<Teacher> builder) {

        builder.HasKey(p => p.Id);
        builder.Property(p => p.FirstName).IsRequired();
        builder.Property(p => p.LastName).IsRequired();
        builder.Property(p => p.Id_Dep).IsRequired();

        builder.HasMany(p => p.T_Cards).WithOne(p => p.Teacher).HasForeignKey(p => p.Id_Teacher);
        builder.HasOne(p => p.Department).WithMany(p => p.Teachers).HasForeignKey(p => p.Id_Dep);
    }
}
