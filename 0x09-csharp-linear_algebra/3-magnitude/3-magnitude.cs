using System;

/// <summary>
/// This class containing a public method that calculate the length of a given vector.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Return the Long of a given vector
    /// </summary>
    /// <param name="vector"></param>
    /// <returns>The return value should be rounded to the nearest hundredth</returns>
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