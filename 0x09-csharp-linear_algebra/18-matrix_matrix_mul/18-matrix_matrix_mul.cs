using System;

    // <sumary> Main Class  </sumary>
    class MatrixMath
    {
        // <sumary> Method for multiply matrix-matrix  </sumary>
        public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
            double[,] error_matrix = { { -1 } };

            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);

            int rows2 = matrix2.GetLength(0);
            int columns2 = matrix2.GetLength(1);

            double res;
            double[,] answer = new double[rows, columns2];

            if (columns == rows2)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns2; j++)
                    {
                        res = 0;
                        for (int k = 0; k < columns; k++)
                        {
                            res += matrix1[i, k] * matrix2[k, j];
                        }
                        answer[i, j] = res;
                    }
                }
                return (answer);
            }
            else
            {
                return (error_matrix);
            }
        }
    }
