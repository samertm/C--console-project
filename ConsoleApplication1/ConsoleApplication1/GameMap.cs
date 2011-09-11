using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class GameMap
    {
        private string[,] MyMap;
        private int numrows;
        private int numcols;
        private int[] startcoords;

        public int Rows
        {
            get
            {
                return numrows;
            }
        }

        public int Cols
        {
            get
            {
                return numcols;
            }
        }

        public int[] StartCoordinates
        {
            get
            {
                return startcoords;
            }
        }

        public GameMap()
        {
            numrows = 20;
            numcols = 54;
            startcoords = new int[] { numrows / 2, numcols / 2 };

            MyMap = new string[numrows, numcols];
            FillMap();
        }

        public GameMap(int rows, int cols)
        {
            numrows = rows;
            numcols = cols;
            startcoords = new int[] { numrows / 2, numcols / 2 };

            MyMap = new string[numrows, numcols];
            FillMap();
        }

        public void FillMap()
        {
            for (int i = 0; i < numrows; i++)
            {
                for (int j = 0; j < numcols; j++)
                {
                    if (MyMap[i, j] == null)
                        MyMap[i, j] = ".";
                }
            }

            for (int i = 0; i < numrows; i++)
            {
                MyMap[i, 0] = "#";
                MyMap[i, numcols - 1] = "#";
            }

            for (int i = 0; i < numcols; i++)
            {
                MyMap[0, i] = "#";
                MyMap[numrows - 1, i] = "#";
            }

        }

        public string GetPoint(int row, int col)
        {
            return MyMap[row, col];
        }

        public void SetPoint(int row, int col, string sprite)
        {
            MyMap[row, col] = sprite;
        }

        public void Print()
        {
            for (int i = 0; i < numrows; i++)
            {
                for (int j = 0; j < numcols; j++)
                {
                    Console.Write(MyMap[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
