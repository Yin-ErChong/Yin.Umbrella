using SqlSugar;
using Yin.Umbrella.CodeGenerator;

namespace CMS.Tool.WebApi.Models.Base
{
    public class DbService
    {
        private static SqlSugarClient _sqlsugarClient;
        public static SqlSugarClient db
        {
            get
            {
                if (_sqlsugarClient == null)
                {
                    var conn = Configer.GetConnStr("ConnectionStrings");//System.Web.Configuration.WebConfigurationManager.AppSettings["connstr"];
                    var db = new SqlSugarClient(
                    new ConnectionConfig()
                    {
                        ConnectionString = conn,
                        DbType = DbType.MySql,
                        IsAutoCloseConnection = true
                    });
                    _sqlsugarClient = db;
                }
                return _sqlsugarClient;
            }
        }
    }
}