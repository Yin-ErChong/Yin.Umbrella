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
            //string file = System.Windows.Forms.Application.ExecutablePath;
           // Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            string connectionString = "server=localhost;port=3306;database=mybatis_test;uid=root;pwd=yin936162557;CharSet=utf8";
            //string connectionString = "Database=jinherlvp;Data Source=rm-2ze6wvy6kg0222k48so.mysql.rds.aliyuncs.com;User Id=lvp_conn;Password=t-YFpRAnxSeS0pe;pooling=false;CharSet=utf8;port=3306;SslMode=None;database=jinherlvp";
            //config.ConnectionStrings.ConnectionStrings[connectionName].ConnectionString.ToString();
            return connectionString;
        }
    }

}
