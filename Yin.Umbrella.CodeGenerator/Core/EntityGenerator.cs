using CMS.Tool.WebApi.Models.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static Yin.Umbrella.CodeGenerator.Models.DBModel;

namespace Yin.Umbrella.CodeGenerator.Core
{
    public class EntityGenerator: GeneratorBase
    {
        public EntityGenerator()
        {
            _templateText = GetTemplate();
        }

        private string GetTemplate()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "Template", "实体类razor.txt");
            return File.ReadAllText(path);
        }
        public override void SetTableName(string tableName)
        {
            
            base.SetTableName(tableName);
            _columsInfos = GetColumnInfos();
        }
        private List<ColumnInfo> GetColumnInfos()
        {
            var columsInfo = DbService.db.SqlQueryable<ColumnInfo>(string.Format(@"select table_name,column_name,ordinal_position,is_nullable,data_type,character_maximum_length,column_key,column_comment
                  from information_schema.COLUMNS
                 where table_name = '{0}'",  _tableName)).ToList();
            return columsInfo;
        }
    }
}
