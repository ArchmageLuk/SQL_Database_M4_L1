using SQL_M4_L1_L4;
using System;

public class Program
{
    static void Main()
    {
        using (AppContext context = new AppContextFactory().CreateContext(Array.Empty<string>()))
        {
            context.Database.EnsureCreated();
            var 
        }
    }
}