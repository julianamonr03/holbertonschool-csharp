using System;

    // <sumary> Main Class  </sumary>
    class MatrixMath
    {
        // <sumary> Method that shears a square 2D matrix by a given shear factor </sumary>
        public static double[,] Shear2D(double[,] matrix, char direction, double factor)
        {
            double[,] error_matrix = { { -1 } };
            double[,] answer = new double[2, 2];
            double[,] shear;

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
            {
                if (direction == 'x')
                {
                    shear = new double[,] { { 1, 0 }, { factor, 1 } };
                }

                if (direction == 'y')
                {
                    shear = new double[,] { { 1, factor }, { 0, 1 } };
                }

                else
                {
                    return (error_matrix);
                }

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            answer[i, j] += matrix[i, k] * shear[k, j];
                        }
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
