using CMS.Tool.WebApi.Models.Base;
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
        public List<ColumnInfo> GetColumnInfos()
        {
            var columsInfo = DbService.db.SqlQueryable<ColumnInfo>(string.Format(@"select table_name,column_name,ordinal_position,is_nullable,data_type,character_maximum_length,column_key,column_comment
                  from information_schema.COLUMNS
                 where table_name = '{0}'", _tableName)).ToList();
            return columsInfo;
        }
        public virtual string GetCode()
        {

            var engine = new RazorLightEngineBuilder()
                        .UseEmbeddedResourcesProject(typeof(Program))
                         .UseMemoryCachingProvider()
                         .Build();
            var model = new { Name = "John Doe" };
            string template = "Hello, @Model.Name. Welcome to RazorLight repository";
            var result2 = engine.CompileRenderStringAsync("templateKey", template, model);
            string str = result2.Result;
            //string template = "Hello, @Model.Name. Welcome to RazorLight repository";
            var result = engine.CompileRenderStringAsync("templateKey", _templateText, new
            {
                EntityNameSpace = "Ace.Entity.CMS",
                EntityName = _tableName,
                Columns = _columsInfos
            });
            return result.Result;
            //var engine = new RazorLightEngineBuilder().
            ////.UseFilesystemProject(@"D:\Test\CoreTest\ConsoleApp.RazorConsole")
            ////.UseMemoryCachingProvider()
            ////.Build();
            //engine.CreateStrByRazorString();
            //string result = engine.CompileRenderAsync("Ocean.cshtml",
            //    new { Name = "Ocean" }).Result;
            //var entity_result = Razor.Parse(_templateText, new
            //{
            //EntityNameSpace = "Ace.Entity.CMS",
            //    EntityName = _tableName,
            //    Columns = _columsInfos
            //}, "entity");
            //return entity_result;
            //return "";
        }//https://github.com/toddams/RazorLight
    }
    public enum GeneratorEnum
    {
        GeneratorBase=0,
        EntityGenerator=1
    }
}
