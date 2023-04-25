global using System.Collections;

namespace BitMatrixLib
{
    public partial class BitMatrix : IEnumerable<int>
    {
        //indexer
        public int this[int i, int j]
        {
            get => (i < 0 || i >= NumberOfRows || j < 0 || j >= NumberOfColumns) ? throw new IndexOutOfRangeException(): BoolToBit(data[i * NumberOfColumns + j]);

            set 
            {
                if (i < 0 || i >= NumberOfRows || j < 0 || j >= NumberOfColumns)
                {
                    throw new IndexOutOfRangeException();
                }
                data[i * NumberOfColumns + j] = BitToBool(value);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < NumberOfRows; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    yield return BoolToBit(data[i * NumberOfColumns + j]);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
