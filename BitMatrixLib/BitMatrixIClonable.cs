using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMatrixLib
{
    public partial class BitMatrix : ICloneable
    {

        public BitMatrix(BitMatrix bitMatrix)
        {
            data = new BitArray(bitMatrix.data);
            NumberOfRows = bitMatrix.NumberOfRows;
            NumberOfColumns = bitMatrix.NumberOfColumns;
        }

        public object Clone()
        {
            return new BitMatrix(this);
        }
    }
}
