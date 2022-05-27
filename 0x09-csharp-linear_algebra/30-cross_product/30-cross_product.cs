using System;

/// <summary>
/// VectorMath class
/// </summary>
class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] array = {-1};

        if (vector1.GetLength(0) != 3)
            return array;
        if (vector2.GetLength(0) != 3)
            return array;

        double[] Result = new double[3];
        double x1 = vector1[0];
        double y1 = vector1[1];
        double z1 = vector1[2];
        double x2 = vector2[0];
        double y2 = vector2[1];
        double z2 = vector2[2];

        Result[0] = y1 * z2 - y2 * z1;
        Result[1] = x2 * z1 - x1 * z2;
        Result[2] = x1 * y2 - y1 * x2;

        return (Result);
    }
}