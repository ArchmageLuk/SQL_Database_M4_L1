using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQL_M4_L1_L4.Configurations;
using SQL_M4_L1_L4;

public sealed class AppContextFactory : IDesignTimeDbContextFactory<SQL_M4_L1_L4.AppContext>
{
    public SQL_M4_L1_L4.AppContext CreateDbContext(string[] args)
    {
        var connectionString = new ConfigService().Read();
        var optionsBuilder = new DbContextOptionsBuilder<SQL_M4_L1_L4.AppContext>();
        var options = optionsBuilder
            .UseSqlServer(connectionString)
            .Options;

        return new SQL_M4_L1_L4.AppContext(options);
    }
}