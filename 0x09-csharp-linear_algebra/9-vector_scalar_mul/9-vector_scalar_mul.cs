using System;

    // <sumary> Main Class  </sumary>
    class VectorMath
    {
        // <sumary> Scalar vector multiplication </sumary>
        public static double[] Multiply(double[] vector, double scalar)
        {
            if (vector.Length == 2)
            {
                double[] mul = {0, 0};
                mul[0] = vector[0] * scalar;
                mul[1] = vector[1] * scalar;
                return (mul);
            }

            if (vector.Length == 3)
            {
                double[] mul = {0, 0, 0};
                mul[0] = vector[0] * scalar;
                mul[1] = vector[1] * scalar;
                mul[2] = vector[2] * scalar;
                return (mul);
            }

            else
            {
                return (new double[] {-1});
            }
        }
    }
