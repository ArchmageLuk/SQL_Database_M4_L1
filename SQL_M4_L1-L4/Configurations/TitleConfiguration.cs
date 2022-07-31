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
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(e => e.TitleId);
            builder.Property(e => e.TitleId).HasColumnName("ProjectId").ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired().HasColumnName("Name").HasMaxLength(255);
        }
    }
}
