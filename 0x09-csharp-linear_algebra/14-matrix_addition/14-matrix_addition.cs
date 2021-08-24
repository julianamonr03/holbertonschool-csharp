using System;

    // <sumary> Main Class  </sumary>
    class MatrixMath
    {
        // <sumary> Matrix addition  </sumary>
        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {
            double[,] error_matrix = { { -1 } };

            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);

            if (matrix1.GetLength(0) == 2 && matrix2.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(1) == 2)
            {
                // double[,] matrix = { { 0, 0 }, { 0, 0 } };

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix1[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }

                return (matrix1);
            }

            else if (matrix1.GetLength(0) == 3 && matrix2.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(1) == 3)
            {

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix1[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }

                return (matrix1);
            }

            else
            {
                return (error_matrix);
            }
        }
    }
