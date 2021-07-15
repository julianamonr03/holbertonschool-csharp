using System;

    class Matrix
    {
        public static int[,] Square(int[,] myMatrix)
        {
            int row = myMatrix.GetLength(0);
            int col = myMatrix.GetLength(1);

            int[,] newOne = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    newOne[i, j] = myMatrix[i, j] * myMatrix[i, j];
                }
            }
            return (newOne);
        }
    }
