using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Protocols;
using SQL_M4_L1_L4;

namespace SQL_M4_L1_L4
{
    public class Process
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public List<Employee> GetUsers()
        {
            List<Employee> employees = new List<Employee>();
            using(IDbConnection db = new SqlConnection(connectionString))
            {
                employees = db.Query<Employee>("SELECT * FROM Employees")
                    .ToList();
            }
            return employees;
        }

    }
}