using System;


class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.GetLength(0) != 2 && vector.GetLength(0) != 3)
            return -1;
        double result = 0;
        for (int i = 0; i < vector.GetLength(0); i++)
        {
            result += Math.Round(Math.Sqrt(Math.Pow(vector[i],2)));
        }
        return result;
    }
}