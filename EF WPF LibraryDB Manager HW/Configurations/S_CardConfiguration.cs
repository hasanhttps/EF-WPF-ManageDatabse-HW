using System;
using System.Linq;
using System.Text;
using EF_Practise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library_Database_CodeFirst_HW.Configurations;

public class S_CardConfiguration : IEntityTypeConfiguration<S_Card> {

    public void Configure(EntityTypeBuilder<S_Card> builder) {

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id_Lib).IsRequired();
        builder.Property(p => p.Id_Student).IsRequired();
        builder.Property(p => p.Id_Book).IsRequired();
        builder.Property(p => p.DateOut).IsRequired();
        builder.Property(p => p.DateIn);

        builder.HasOne(p => p.Student).WithMany(p => p.S_Cards).HasForeignKey(p => p.Id_Student);
        builder.HasOne(p => p.Book).WithMany(p => p.S_Cards).HasForeignKey(p => p.Id_Student);
        builder.HasOne(p => p.Lib).WithMany(p => p.S_Cards).HasForeignKey(p => p.Id_Lib);
    }
}
