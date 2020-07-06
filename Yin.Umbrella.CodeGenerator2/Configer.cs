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
            //string connectionString = "server=localhost;port=3306;database=mybatis_test;uid=root;pwd=yin936162557;CharSet=utf8";
            string connectionString = "server=rm-2ze6wvy6kg0222k48so.mysql.rds.aliyuncs.com;port=3306;user id=testlvp;password=9bLL(4fe&6)vzLR;database=jinherlvp;max pool size=32767;";
            //config.ConnectionStrings.ConnectionStrings[connectionName].ConnectionString.ToString();
            return connectionString;
        }
    }

}
