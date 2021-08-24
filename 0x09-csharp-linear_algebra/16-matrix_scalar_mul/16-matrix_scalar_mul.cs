using System;

    // <sumary> Main Class  </sumary>
    class MatrixMath
    {
        // <sumary> Method for matrix scalar multiplication  </sumary>
        public static double[,] MultiplyScalar(double[,] matrix, double scalar)
        {
            double[,] error_matrix = { { -1 } };

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2 || matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[i, j] = matrix[i, j] * scalar;
                    }
                }

                return (matrix);
            }

            else
            {
                return (error_matrix);
            }
        }
    }
