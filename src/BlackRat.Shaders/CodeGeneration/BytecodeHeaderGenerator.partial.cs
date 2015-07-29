using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRat.Shaders.CodeGeneration
{
    public partial class BytecodeHeaderGenerator : ICodeGenerator
    {
        public BytecodeHeaderGenerator(Shader shader, ShaderClassGeneratorOptions generatorOptions)
        {
            ThrowIf.Argument.IsNull(shader, nameof(shader));
            ThrowIf.Argument.IsNull(generatorOptions, nameof(generatorOptions));

            GeneratorOptions = generatorOptions;
            Shader = shader;
        }

        #region Properties

        public ShaderClassGeneratorOptions GeneratorOptions { get; private set; }

        public Shader Shader { get; private set; }

        #endregion Properties

        /// <summary>
        /// Returns the specified <see cref="byte"/> as an integer string of length 4, for
        /// aesthetic and readability purposes.
        /// </summary>
        private string FormatByte(byte b)
        {
            return b.ToString().PadLeft(4, ' ');
        }

        private IEnumerable<string> GetBytecodeArrayLines()
        {
            for (int i = 0; i < Shader.Bytecode.Length; i += GeneratorOptions.BytecodeArrayElementsPerLine)
            {
                yield return Shader.Bytecode.Skip(i)
                    .Take(GeneratorOptions.BytecodeArrayElementsPerLine)
                    .Aggregate("", (c, n) => c + FormatByte(n) + ",");
            }
        }

        private string GetStandardIncludeGuardDefinitionName()
        {
            return $"{GeneratorOptions.ClassName.ToUpper()}_BYTECODE_H";
        }
    }
}
