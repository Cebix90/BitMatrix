using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMatrixLib
{
    public partial class BitMatrix
    {
        public static explicit operator BitMatrix(int[,] bits)
        {
            if (bits == null)
                throw new NullReferenceException();
            if (bits.Length < 1)
                throw new ArgumentOutOfRangeException();
            return new BitMatrix(bits);
        }

        public static implicit operator int[,](BitMatrix matrix)
        {
            int[,] result = new int[matrix.NumberOfRows, matrix.NumberOfColumns];

            int x = 0;
            for (int i = 0; i < matrix.NumberOfRows; i++)
            {
                for (int j = 0; j < matrix.NumberOfColumns; j++)
                {
                    result[i, j] = matrix.data[x] ? 1 : 0;
                    x++;
                }
            }

            return result;
        }

        public static explicit operator BitMatrix(bool[,] bits)
        {
            if (bits == null)
                throw new NullReferenceException();
            if (bits.Length < 1)
                throw new ArgumentOutOfRangeException();
            return new BitMatrix(bits);
        }

        public static implicit operator bool[,](BitMatrix matrix)
        {
            bool[,] result = new bool[matrix.NumberOfRows, matrix.NumberOfColumns];

            int x = 0;
            for (int i = 0; i < matrix.NumberOfRows; i++)
            {
                for (int j = 0; j < matrix.NumberOfColumns; j++)
                {
                    result[i, j] = matrix.data[x] ? true : false;
                    x++;
                }
            }

            return result;
        }

        public static explicit operator BitArray(BitMatrix m)
        {
            return new BitArray(m.data);
        }
    }
}
