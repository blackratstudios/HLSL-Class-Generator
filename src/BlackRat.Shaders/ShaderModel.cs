using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRat.Shaders
{
    public enum ShaderModel
    {
        Unsupported,

        /// <summary>
        /// Shader Model 4.0
        /// </summary>
        SM4_0,

        /// <summary>
        /// Shader Model 4.1
        /// </summary>
        SM4_1,

        /// <summary>
        /// Shader Model 5.0
        /// </summary>
        SM5_0,

        /// <summary>
        /// Shader Model 5.1, introduced with DirectX 12 and 11.3
        /// </summary>
        SM5_1
    }
}
