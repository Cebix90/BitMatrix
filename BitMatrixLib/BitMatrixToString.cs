using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMatrixLib
{
    public partial class BitMatrix
    {
        public override string ToString()
        {
            /*var sb = new StringBuilder();

            for (int row = 0; row < NumberOfRows; row++)
            {
                for (int col = 0; col < NumberOfColumns; col++)
                {
                    sb.Append(BoolToBit(data[row * NumberOfColumns + col]));
                }
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();*/

            string result = "";
            for (int i = 0; i < NumberOfRows; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    result += BoolToBit(data[i * NumberOfColumns + j]);
                }
                result += "\n";
            }
            return result;
        }
    }
}
