using RazorEngine;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.Text;
using static Yin.Umbrella.CodeGenerator.Models.DBModel;

namespace Yin.Umbrella.CodeGenerator.Core
{
    public  class GeneratorBase : IGenerator
    {
        public string _templateText { get; set; }
        protected string _tableName { get; set; }
        protected List<ColumnInfo> _columsInfos { get; set; }
        public virtual void SetTableName(string tableName)
        {
            _tableName = tableName;
        }
        public virtual string GetCode()
        {
            var entity_result = Razor.Parse(_templateText, new
            {
                EntityNameSpace = "Ace.Entity.CMS",
                EntityName = _tableName,
                Columns = _columsInfos
            }, "entity");
            return entity_result;
        }
    }
    public enum GeneratorEnum
    {
        GeneratorBase=0,
        EntityGenerator=1
    }
}
