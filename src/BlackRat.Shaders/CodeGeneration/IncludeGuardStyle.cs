using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRat.Shaders.CodeGeneration
{
    public enum IncludeGuardStyle
    {
        /// <summary>
        /// Generates an include guard using the <code>#pragma once</code> macro.
        /// </summary>
        PragmaOnce,
        /// <summary>
        /// Generates classic include guards with a <code>#define</code> macro.
        /// </summary>
        Standard,
    }
}
