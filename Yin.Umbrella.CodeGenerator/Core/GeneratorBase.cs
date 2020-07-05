using RazorLight;
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
            //var engine = new RazorLightEngineBuilder().
            ////.UseFilesystemProject(@"D:\Test\CoreTest\ConsoleApp.RazorConsole")
            ////.UseMemoryCachingProvider()
            ////.Build();
            //engine.CreateStrByRazorString();
            //string result = engine.CompileRenderAsync("Ocean.cshtml",
            //    new { Name = "Ocean" }).Result;
            //var entity_result = Razor.Parse(_templateText, new
            //{
            //    EntityNameSpace = "Ace.Entity.CMS",
            //    EntityName = _tableName,
            //    Columns = _columsInfos
            //}, "entity");
            //return entity_result;
            return "";
        }
    }
    public enum GeneratorEnum
    {
        GeneratorBase=0,
        EntityGenerator=1
    }
}
