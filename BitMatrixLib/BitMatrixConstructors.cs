using System.Collections;

namespace BitMatrixLib
{
    public partial class BitMatrix
    {
        public BitMatrix(int numberOfRows, int numberOfColumns, params int[] bits)
        {
            int numberOfBits = bits == null ? 0 : bits.Length;
            data = new BitArray(numberOfRows * numberOfColumns);
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    int index = i * numberOfColumns + j;
                    if (index < numberOfBits)
                        data[index] = BitToBool(bits[index]);
                    else
                        data[index] = false;
                }
            }

            NumberOfRows = numberOfRows;
            NumberOfColumns = numberOfColumns;
        }

        public BitMatrix(int[,] bits)
        {
            if (bits == null)
                throw new NullReferenceException();

            int numberOfRows = bits.GetLength(0);
            int numberOfColumns = bits.GetLength(1);

            if (numberOfRows < 1 || numberOfColumns < 1)
                throw new ArgumentOutOfRangeException();

            data = new BitArray(numberOfRows * numberOfColumns);

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    data.Set(i * numberOfColumns + j, BitToBool(bits[i, j]));
                }
            }

            NumberOfRows = numberOfRows;
            NumberOfColumns = numberOfColumns;
        }

        public BitMatrix(bool[,] bits)
        {
            if (bits == null)
                throw new NullReferenceException();

            int numberOfRows = bits.GetLength(0);
            int numberOfColumns = bits.GetLength(1);

            if (numberOfRows < 1 || numberOfColumns < 1)
                throw new ArgumentOutOfRangeException();

            data = new BitArray(numberOfRows * numberOfColumns);

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    data[i * numberOfColumns + j] = bits[i, j];
                }
            }

            NumberOfRows = numberOfRows;
            NumberOfColumns = numberOfColumns;
        }

    }
}
