using System.Collections;

namespace BitMatrixLib
{
    public partial class BitMatrix : IEquatable<BitMatrix>
    {
        public bool Equals(BitMatrix other)
        {
            if (object.ReferenceEquals(this, other)) return true;
            if (object.ReferenceEquals(other, null)) return false;

            string m = this.ToString().Replace("\n", "").Replace("\r", "");
            string m2 = other.ToString().Replace("\n", "").Replace("\r", ""); ;
            string mResult = "";
            string m2Result = "";

            foreach (var item in m)
            {
                mResult += item;
            }

            foreach (var item in m2)
            {
                m2Result += item;
            }

            if (!mResult.Equals(m2Result))
            {
                return false;
            }

            return this.NumberOfColumns == other.NumberOfColumns && this.NumberOfRows == other.NumberOfRows;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as BitMatrix);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(data, NumberOfRows, NumberOfColumns, IsReadOnly);
        }

        public static bool operator ==(BitMatrix left, BitMatrix right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BitMatrix left, BitMatrix right)
        {
            return !(left == right);
        }
    }
}
