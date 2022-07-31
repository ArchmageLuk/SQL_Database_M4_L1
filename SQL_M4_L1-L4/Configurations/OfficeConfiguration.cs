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
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(e => e.OfficeId);
            builder.Property(e => e.OfficeId).HasColumnName("OfficeId").ValueGeneratedOnAdd();
            builder.Property(e => e.Title).IsRequired().HasColumnName("Title").HasMaxLength(255);
            builder.Property(e => e.Location).IsRequired().HasColumnName("StartedDate").HasMaxLength(255);
        }
    }
}
