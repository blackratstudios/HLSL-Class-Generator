﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlackRat.Shaders {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class D3D11Types {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal D3D11Types() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BlackRat.Shaders.Resources.D3D11Types", typeof(D3D11Types).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ID3D11Buffer.
        /// </summary>
        internal static string ConstantBufferType {
            get {
                return ResourceManager.GetString("ConstantBufferType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ID3D11DeviceContext.
        /// </summary>
        internal static string DeviceContextType {
            get {
                return ResourceManager.GetString("DeviceContextType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ID3D11Device.
        /// </summary>
        internal static string DeviceType {
            get {
                return ResourceManager.GetString("DeviceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ID3D11InputLayout.
        /// </summary>
        internal static string InputLayoutType {
            get {
                return ResourceManager.GetString("InputLayoutType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ID3D11SamplerState.
        /// </summary>
        internal static string SamplerType {
            get {
                return ResourceManager.GetString("SamplerType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ID3D11ShaderResourceView.
        /// </summary>
        internal static string ShaderResourceViewType {
            get {
                return ResourceManager.GetString("ShaderResourceViewType", resourceCulture);
            }
        }
    }
}
