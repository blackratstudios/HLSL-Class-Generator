using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRat.Shaders
{
    public class ShaderProfile
    {
        public ShaderProfile(ShaderModel shaderModel, ShaderKind shaderKind)
        {
            ShaderModel = shaderModel;
            ShaderKind = shaderKind;
        }

        #region Properties

        public ShaderModel ShaderModel { get; private set; }

        public ShaderKind ShaderKind { get; private set; }

        #endregion Properties
    }
}
