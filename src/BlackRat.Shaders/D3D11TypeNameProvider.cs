using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRat.Shaders
{
    public class D3D11TypeNameProvider : ID3DTypeNameProvider
    {
        public string ConstantBufferType => D3D11Types.ConstantBufferType;

        public string DeviceContextType => D3D11Types.DeviceContextType;

        public string DeviceType => D3D11Types.DeviceType;

        public string InputLayoutType => D3D11Types.InputLayoutType;

        public string SamplerType => D3D11Types.SamplerType;

        public string ShaderResourceViewType => D3D11Types.ShaderResourceViewType;
    }
}
