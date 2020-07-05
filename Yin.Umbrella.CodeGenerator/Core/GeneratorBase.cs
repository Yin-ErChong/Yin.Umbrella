using RazorEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Yin.Umbrella.CodeGenerator.Core
{
    public class GeneratorBase : IGenerator
    {
        private string _templateText { get; set; }
        private string _tableName { get; set; }
        private string _columsInfo { get; set; }
        public string GetCode()
        {
            var entity_result = Razor.Parse(_templateText, new
            {
                EntityNameSpace = "Ace.Entity.CMS",
                EntityName = _tableName,
                Columns = _columsInfo
            }, "entity");
            throw new NotImplementedException();
        }
    }
}
