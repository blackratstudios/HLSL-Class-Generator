using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRat.Shaders
{
    public static class ThrowIf
    {
        public static class Argument
        {
            [DebuggerStepThrough]
            public static void IsNull<T>(T argument, string argumentName)
                where T : class
            {
                if(ReferenceEquals(argument, null))
                {
                    throw new ArgumentNullException(argumentName);
                }
            }
        }
    }
}
