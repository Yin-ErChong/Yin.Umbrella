using CMS.Tool.WebApi.Models.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

    }
}
