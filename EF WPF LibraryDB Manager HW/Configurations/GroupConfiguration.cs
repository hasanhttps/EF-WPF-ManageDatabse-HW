using System;
using System.Linq;
using System.Text;
using EF_Practise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library_Database_CodeFirst_HW.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group> {

    public void Configure(EntityTypeBuilder<Group> builder) {

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Id_Faculty).IsRequired();

        builder.HasMany(p => p.Students).WithOne(p => p.Group).HasForeignKey(p => p.Id_Group);
        builder.HasOne(p => p.Faculty).WithMany(p => p.Groups).HasForeignKey(p => p.Id_Faculty);
    }
}
