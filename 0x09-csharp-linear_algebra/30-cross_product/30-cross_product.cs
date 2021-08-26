using System;

    // <sumary> Main Class  </sumary>
    class VectorMath
    {
        // <sumary> Method that calculates the cross product of two 3D vectors  </sumary>
        public static double[] CrossProduct(double[] vector1, double[] vector2)
        {
            double[] answer = new double[3];

            if (vector1.Length == 3 && vector2.Length == 3)
            {
                answer[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
                answer[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
                answer[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
                return (answer);
            }
            // If either vector is not a 3D vector return a vector containing -1
            else
            {
                return (new double[] { -1 });
            }
        }
    }
