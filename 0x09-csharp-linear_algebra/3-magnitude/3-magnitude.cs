using System;

    // <sumary> Main class  </sumary>
    class VectorMath
    {
        // <sumary> Calculates the lenght of a given vector </sumary>
        public static double Magnitude(double[] vector)
        {
            if (vector.Length == 2)
            {
                return (Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 2));
            }

            if (vector.Length == 3)
            {
                return (Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 2));
            }

            else
            {
                return (-1);
            }
        }
    }
