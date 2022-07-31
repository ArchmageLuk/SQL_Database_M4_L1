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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(e => e.ProjectId);
            builder.Property(e => e.ProjectId).HasColumnName("ProjectId").ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired().HasColumnName("Name").HasMaxLength(255);
            builder.Property(e => e.Budget).HasColumnName("Budget");
            builder.Property(e => e.StartedDate).IsRequired().HasColumnName("StartedDate");
        }
    }
}
