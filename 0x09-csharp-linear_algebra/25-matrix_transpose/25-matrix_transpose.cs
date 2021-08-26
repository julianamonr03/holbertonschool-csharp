using System;

    // <sumary> Main Class  </sumary>
    class MatrixMath
    {
        // <sumary> Method to transpose a matrix  </sumary>
        public static double[,] Transpose(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            double[,] answer = new double[columns, rows];
            double[,] empty_matrix = {{ }};

            if (rows != 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        answer[j, i] = matrix[i, j];
                    }
                }
                return (answer);
            }
            else
                return (empty_matrix);
        }
    }
