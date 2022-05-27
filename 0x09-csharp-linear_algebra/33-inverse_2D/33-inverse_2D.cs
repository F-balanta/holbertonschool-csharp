using System;


class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] fail = { { -1 } };

        if (matrix == null || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (fail);

        double a = matrix[0, 0];
        double b = -1 * matrix[0, 1];
        double c = -1 * matrix[1, 0];
        double d = matrix[1, 1];
        double Result = a * d - b * c;

        if (Result == 0)
            return (fail);

        double[,] NewMatrix = new double[2, 2];

        NewMatrix[0, 0] = Math.Round(d / Result, 2);
        NewMatrix[0, 1] = Math.Round(b / Result, 2);
        NewMatrix[1, 0] = Math.Round(c / Result, 2);
        NewMatrix[1, 1] = Math.Round(a / Result, 2);

        return (NewMatrix);
    }
}


