using System;

    // <sumary> Main Class  </sumary>
    class MatrixMath
    {
        // <sumary> Method that rotates a 2D matrix by a given angle in radians </sumary>
        public static double[,] Rotate2D(double[,] matrix, double angle)
        {
            double[,] error_matrix = { { -1 } };
            double[,] answer = new double[2, 2];

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Create the convention matrix
            // { cos 0, -sin 0 }
            // { sin 0, cos 0 }
            double[,] rotate_mat = {{ Math.Cos(angle), Math.Sin(angle) }, { -1 * Math.Sin(angle), Math.Cos(angle) }};

            if (rows == 2 && columns == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            answer[i, j] = Math.Round((answer[i, j] + (matrix[i, k] * rotate_mat[k, j])), 2);
                        }
                    }
                }
                return (answer);
            }
            else
                return (error_matrix);
        }
    }
