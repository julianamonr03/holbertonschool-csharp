using System;

    // <sumary> Main Class  </sumary>
    class VectorMath
    {
        // <sumary> Calculates the sum of two vectors </sumary>
        public static double[] Add(double[] vector1, double[] vector2)
        {
            if (vector1.Length == 2 && vector2.Length == 2)
            {
                double[] sum = {0, 0};
                sum[0] = vector1[0] + vector2[0];
                sum[1] = vector1[1] + vector2[1];
                return (sum);
            }

            else if (vector1.Length == 3 && vector2.Length == 3)
            {
                double[] sum = {0, 0, 0};
                sum[0] = vector1[0] + vector2[0];
                sum[1] = vector1[1] + vector2[1];
                sum[2] = vector1[2] + vector2[2];
                return (sum);
            }

            else
            {
                return (new double[] {-1});
            }
        }
    }
