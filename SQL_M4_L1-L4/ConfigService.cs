using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SQL_M4_L1_L4
{
    public class ConfigService
    {
        public string ConnectionString { get; set; }

        public string Read()
        {
            string readingJson = File.ReadAllText(@"D:\Projects\C# learning\Code\SQL_M4_M1-4\SQL_M4_L1-L4\config.json");
            var jsonDir = JsonConvert.DeserializeObject<ConfigService>(readingJson);
            return jsonDir.ConnectionString;
        }
    }
}
