using System;
/// <summary>
///  1 method
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiply
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="scalar"></param>
    /// <returns>multiplies a vector and a scalar and returns the resulting vector.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] array = { -1 };

        if (vector.GetLength(0) != 2 && vector.GetLength(0) != 3)
            return array;

        if (vector.GetLength(0) == 2)
        {
            double[] Vec_Scalar = { scalar * vector[0], scalar * vector[1] };
            return Vec_Scalar;
        }
        else
        {
            double[] Vec_Scalar = { scalar * vector[0], scalar * vector[1], scalar * vector[2] };
            return Vec_Scalar;
        }
    }
}