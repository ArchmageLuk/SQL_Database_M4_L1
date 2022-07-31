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
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.EmployeeProjectId);
            builder.Property(e => e.EmployeeProjectId).HasColumnName("EmployeeProjectId").ValueGeneratedOnAdd();
            builder.Property(e => e.Rate).HasColumnName("Rate");
            builder.Property(e => e.StartedDate).HasColumnName("StartedDate");
            builder.Property(e => e.EmployeeId).HasColumnName("EmployeeId");

            builder.HasOne(e => e.EmployeeId);
                // .WithOne(d =>  d.EmployeeId)
                //.HasForeignKey<Employee>(e => e.EmployeeId)
                //.OnDelete(DeleteBehavior.Cascade);

            builder.Property(e => e.ProjectId).HasColumnName("ProjectId");
        }
    }
}
