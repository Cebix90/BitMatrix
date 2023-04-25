using BitMatrixLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMatrixLib
{
    public partial class BitMatrix
    {
        #region Parse
        public static BitMatrix Parse1(string s)
        {
            if (s == null)
                throw new ArgumentNullException();

            var lines = s.Split('\n', '\r').Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
            var numberOfRows = lines.Length;
            var numberOfColumns = lines[0].Length;

            var bits = new int[numberOfRows * numberOfColumns];
            for (int i = 0; i < numberOfRows; i++)
            {
                if (lines[i].Length != numberOfColumns)
                    throw new ArgumentException("All rows must have the same number of columns.");

                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (lines[i][j] == '0')
                        bits[i * numberOfColumns + j] = 0;
                    else if (lines[i][j] == '1')
                        bits[i * numberOfColumns + j] = 1;
                    else
                        throw new FormatException("Invalid character in input string.");
                }
            }

            return new BitMatrix(numberOfRows, numberOfColumns, bits);
        }
        #endregion

        public static BitMatrix Parse(string s)
        {
            if(s == null || s == string.Empty) throw new ArgumentNullException();

            var lines = s.Split('\n', '\r').Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
            var numberOfRows = lines.Length;
            var numberOfColumns = lines[0].Length;

            var bits = new int [numberOfRows* numberOfColumns];

            for (int i = 0; i < numberOfRows; i++)
            {
                if (lines[i].Length != numberOfColumns) throw new FormatException();

                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (lines[i][j] == '0')
                        bits[i * numberOfColumns + j] = 0;
                    else if (lines[i][j] == '1')
                        bits[i * numberOfColumns + j] = 1;
                    else
                        throw new FormatException();
                }
            }

            return new BitMatrix(numberOfRows, numberOfColumns, bits);
        }

        public static bool TryParse(string s, out BitMatrix result)
        {
            result = null;

            try
            {
                result = (Parse(s));
                return true;
            }
            catch { return false; }
        }
    }
}
