using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRat.Shaders
{
    public struct ShaderModel : IComparable<ShaderModel>, IEquatable<ShaderModel>
    {
        private readonly int majorVersion;
        private readonly int minorVersion;

        public ShaderModel(int majorVersion, int minorVersion)
        {
            if(majorVersion < 1)
            {
                throw new ArgumentException($"{nameof(majorVersion)} cannot be less than 1", nameof(majorVersion));
            }

            if(minorVersion < 0)
            {
                throw new ArgumentException($"{nameof(minorVersion)} cannot be less than zero", nameof(minorVersion));
            }

            this.majorVersion = majorVersion;
            this.minorVersion = minorVersion;
        }

        #region Properties

        public int MajorVersion { get { return majorVersion; } }

        public int MinorVersion { get { return minorVersion; } }

        #endregion Properties

        public int CompareTo(ShaderModel other)
        {
            if(MajorVersion < other.MajorVersion)
            {
                return -1;
            }
            else if (MajorVersion > other.MajorVersion)
            {
                return 1;
            }
            else
            {
                return MinorVersion - other.MinorVersion;
            }
        }

        public bool Equals(ShaderModel other)
        {
            return MajorVersion == other.MajorVersion &&
                MinorVersion == other.MinorVersion;
        }

        public override bool Equals(object obj)
        {
            return obj is ShaderModel ? Equals((ShaderModel)obj) : false;
        }

        public override int GetHashCode()
        {
            return MajorVersion ^ MinorVersion;
        }

        public override string ToString()
        {
            return $"{MajorVersion}_{MinorVersion}";
        }

        #region Operators

        public static bool operator==(ShaderModel lhs, ShaderModel rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator!=(ShaderModel lhs, ShaderModel rhs)
        {
            return !lhs.Equals(rhs);
        }

        public static bool operator<(ShaderModel lhs, ShaderModel rhs)
        {
            return lhs.CompareTo(rhs) < 0;
        }

        public static bool operator <=(ShaderModel lhs, ShaderModel rhs)
        {
            return lhs.CompareTo(rhs) <= 0;
        }

        public static bool operator >(ShaderModel lhs, ShaderModel rhs)
        {
            return lhs.CompareTo(rhs) > 0;
        }

        public static bool operator >=(ShaderModel lhs, ShaderModel rhs)
        {
            return lhs.CompareTo(rhs) >= 0;
        }

        #endregion Operators
    }
}
