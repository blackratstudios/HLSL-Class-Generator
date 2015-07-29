using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRat.Shaders
{
    public class Shader
    {
        public Shader()
        {

        }

        public Shader(string name, ShaderProfile profile, byte[] bytecode)
        {
            Bytecode = bytecode;
            Name = name;
            Profile = profile;
        }

        #region Properties

        public byte[] Bytecode { get; set; }

        public string Name { get; set; }

        public ShaderProfile Profile { get; set; }

        #endregion Properties
    }
}
