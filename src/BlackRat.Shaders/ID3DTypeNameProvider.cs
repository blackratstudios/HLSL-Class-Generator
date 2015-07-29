using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRat.Shaders
{
    /// <summary>
    /// Provides names of DirectX types (e.g. ID3D11Buffer)
    /// </summary>
    /// <remarks>
    /// Should be implemented to provide types for multiple versions of DirectX, if necessary
    /// </remarks>
    public interface ID3DTypeNameProvider
    {
        string ConstantBufferType { get; }

        string DeviceType { get; }

        string DeviceContextType { get; }

        string InputLayoutType { get; }

        string SamplerType { get; }

        string ShaderResourceViewType { get; }
    }
}
