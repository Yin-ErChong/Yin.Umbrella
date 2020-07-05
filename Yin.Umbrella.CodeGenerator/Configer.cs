using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Yin.Umbrella.CodeGenerator
{
    public  class Configer
    {
        public static string GetConnStr(string connectionName)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            string connectionString =
                config.ConnectionStrings.ConnectionStrings[connectionName].ConnectionString.ToString();
            return connectionString;
        }
    }

}
