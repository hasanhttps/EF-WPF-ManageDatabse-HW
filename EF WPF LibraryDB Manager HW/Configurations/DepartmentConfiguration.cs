using System;
using System.Linq;
using System.Text;
using EF_Practise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library_Database_CodeFirst_HW.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department> {

    public void Configure(EntityTypeBuilder<Department> builder) {

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired();

        builder.HasMany(p => p.Teachers).WithOne(p => p.Department).HasForeignKey(p => p.Id_Dep);
    }
}
