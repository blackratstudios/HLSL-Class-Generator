using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRat.Shaders.CodeGeneration
{
    public interface ICodeGenerator
    {
        ShaderClassGeneratorOptions GeneratorOptions { get; }
    }
}
