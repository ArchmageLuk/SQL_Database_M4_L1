using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQL_M4_L1_L4;

namespace SQL_M4_L1_L4.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.EmployeeId);
            builder.Property(e => e.EmployeeId).HasColumnName("EmployeeId").ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(255);
            builder.Property(e => e.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(255);
            builder.Property(e => e.HiredDate).IsRequired().HasColumnName("HiredDate");
            builder.Property(e => e.DateOfBirth).IsRequired().HasColumnName("DateOfBirth");
            builder.Property(e => e.OfficeId).HasColumnName("OfficeId").ValueGeneratedNever();
            builder.Property(e => e.TitleId).HasColumnName("TitleId").ValueGeneratedNever();

        }
    }
}
