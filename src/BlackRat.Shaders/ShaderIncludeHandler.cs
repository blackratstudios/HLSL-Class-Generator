using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.D3DCompiler;

namespace BlackRat.Shaders
{
    public class ShaderIncludeHandler : Include, IDisposable
    {
        private IDisposable shadow = null;
        private string directory = "";

        public ShaderIncludeHandler(string shaderFilename)
        {
            if (string.IsNullOrWhiteSpace(shaderFilename))
            {
                throw new ArgumentNullException(nameof(shaderFilename));
            }

            if(!File.Exists(shaderFilename))
            {
                throw new ArgumentException("The specified file does not exist", nameof(shaderFilename));
            }

            directory = Path.GetDirectoryName(shaderFilename);
        }

        #region Properties

        public IDisposable Shadow
        {
            get { return shadow; }
            set { shadow = value; }
        }

        #endregion Properties

        public void Close(Stream stream)
        {
            stream.Close();
        }

        public Stream Open(IncludeType type, string fileName, Stream parentStream)
        {
            if (type == IncludeType.Local)
            {
                return new FileStream(Path.Combine(directory, fileName), FileMode.Open);
            }
            else
            {
                return new FileStream(Path.Combine(Environment.SystemDirectory, fileName), FileMode.Open);
            }
        }

        #region IDisposable Support

        private bool isDisposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    if (shadow != null)
                    {
                        shadow.Dispose();
                    }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                isDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        #endregion
    }
}
