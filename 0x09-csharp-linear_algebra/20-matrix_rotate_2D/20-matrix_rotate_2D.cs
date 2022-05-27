using System;
/// <summary>
/// Matrix Class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="angle"></param>
    /// <returns></returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] array = { { -1 } };
        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return (array);
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (array);

        double[,] result = new double[2, 2];
        double x1 = matrix[0, 0];
        double y1 = matrix[0, 1];
        double x2 = matrix[1, 0];
        double y2 = matrix[1, 1];
        double coseno = Math.Cos(angle);
        double seno = Math.Sin(angle);

        result[0, 0] = Math.Round((x1 * coseno), 2) - Math.Round((y1 * seno), 2);
        result[0, 1] = Math.Round((x1 * seno), 2) + Math.Round((y1 * coseno), 2);
        result[1, 0] = Math.Round((x2 * coseno), 2) - Math.Round((y2 * seno), 2);
        result[1, 1] = Math.Round((x2 * seno), 2) + Math.Round((y2 * coseno), 2);

        return result;
    }
}
