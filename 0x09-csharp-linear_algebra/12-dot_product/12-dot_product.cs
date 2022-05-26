using System;

/// <summary>
/// VectorMath Class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Dot Product
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns></returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.GetLength(0) != vector2.GetLength(0))
            return -1;
        if (vector1.GetLength(0) != 2 && vector1.GetLength(0) != 3)
            return -1;
        double addvector = 0;
        for (int i = 0; i < vector1.GetLength(0); i++)
        {
            addvector += vector1[i] * vector2[i];
        }
        return addvector;
    }
}