using System;
using System.Linq;
using System.Text;
using EF_Practise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library_Database_CodeFirst_HW.Configurations;

public class T_CardConfiguration : IEntityTypeConfiguration<T_Card> {

    public void Configure(EntityTypeBuilder<T_Card> builder) {

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id_Lib).IsRequired();
        builder.Property(p => p.Id_Teacher).IsRequired();
        builder.Property(p => p.Id_Book).IsRequired();
        builder.Property(p => p.DateOut).IsRequired();
        builder.Property(p => p.DateIn);

        builder.HasOne(p => p.Teacher).WithMany(p => p.T_Cards).HasForeignKey(p => p.Id_Teacher);
        builder.HasOne(p => p.Book).WithMany(p => p.T_Cards).HasForeignKey(p => p.Id_Book);
        builder.HasOne(p => p.Lib).WithMany(p => p.T_Cards).HasForeignKey(p => p.Id_Lib);
    }
}
