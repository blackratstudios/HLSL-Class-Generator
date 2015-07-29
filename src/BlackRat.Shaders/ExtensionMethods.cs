using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRat.Shaders
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Returns the short version of the specified <see cref="ShaderKind"/> (e.g. <see cref="ShaderKind.VertexShader"/> is "vs")
        /// </summary>
        public static string ToShortKindString(this ShaderKind shaderKind)
        {
            switch(shaderKind)
            {
                case ShaderKind.ComputeShader: return "cs";
                case ShaderKind.DomainShader: return "ds";
                case ShaderKind.GeometryShader: return "gs";
                case ShaderKind.HullShader: return "hs";
                case ShaderKind.PixelShader: return "ps";
                case ShaderKind.VertexShader: return "vs";
            }

            throw new InvalidOperationException("Exhausted all possible values of ShaderKind");
        }
    }
}
