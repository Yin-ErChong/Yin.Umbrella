using System;
using System.Collections.Generic;
using System.Text;

namespace Yin.Umbrella.CodeGenerator.Core
{
    public class GeneratorFactory
    {
        public static Dictionary<string, GeneratorBase> GeneratorDic = new Dictionary<string, GeneratorBase>();
        public static GeneratorBase GetGeneratorByName(GeneratorEnum generatorEnum)
        {
            switch (generatorEnum)
            {
                case GeneratorEnum.EntityGenerator:
                    if (GeneratorDic.ContainsKey(generatorEnum.ToString()))
                    {
                        return GeneratorDic[generatorEnum.ToString()];
                    }
                    else
                    {
                        var generator = new EntityGenerator();
                        GeneratorDic.Add(generatorEnum.ToString(), generator);
                        return generator;
                    }                        
                default:return new GeneratorBase();
            }           
        }
    }
}
