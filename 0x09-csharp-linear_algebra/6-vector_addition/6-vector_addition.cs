using System;
/// <summary>
/// Vector Add Class
/// </summary>
class VectorMath
{
    /// <summary>
    ///  Add Method
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns> Return the add of two vectors </returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] array = new double[]{-1};
        if (vector1.GetLength(0) != vector2.GetLength(0))
            return array;
        if (vector1.GetLength(0) != 2 && vector1.GetLength(0) != 3)
            return array;
        if (vector1.GetLength(0) == 2)
        {
            double[] addvector = { vector1[0] + vector2[0], vector1[1] + vector2[1] };
            return addvector;
        }
        else
        {
            double[] addvector = { vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2] };
            return addvector;
        }
    }
}
