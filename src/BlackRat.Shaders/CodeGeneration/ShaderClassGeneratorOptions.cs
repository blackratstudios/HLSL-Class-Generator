using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRat.Shaders.CodeGeneration
{
    public class ShaderClassGeneratorOptions
    {
        public ShaderClassGeneratorOptions(string className)
        {
            ClassName = className;

            // Defaults
            BytecodeArrayElementsPerLine = 8;
            BytecodeVariableName = "_bytecode";
            IncludeGuardStyle = IncludeGuardStyle.Standard;
        }

        public int BytecodeArrayElementsPerLine { get; set; }

        public string BytecodeVariableName { get; set; }

        public string ClassName { get; private set; }

        public IncludeGuardStyle IncludeGuardStyle { get; set; }
    }
}
