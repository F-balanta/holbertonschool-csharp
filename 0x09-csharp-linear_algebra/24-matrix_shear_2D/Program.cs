using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// This method shears a square 2D matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="direction"></param>
    /// <param name="factor"></param>
    /// <returns></returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] array = { { -1 } };
        // If the matrix is of an invalid size, return a matrix containing -1
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return array;
        }
        // If given an axis that is not x or y, return a matrix containing -1
        if (direction != 'x' && direction != 'y')
        {
            return array;
        }
        double[,] result = new double[2, 2];
        if (direction == 'x')
        {
            result[0, 0] = matrix[0, 0] + factor * matrix[0, 1];
            result[0, 1] = matrix[0, 1];
            result[1, 0] = matrix[1, 0] + factor * matrix[1, 1];
            result[1, 1] = matrix[1, 1];
        }
        else
        {
            result[0, 0] = matrix[0, 0];
            result[0, 1] = matrix[0, 0] * factor + matrix[0, 1];
            result[1, 0] = matrix[1, 0];
            result[1, 1] = matrix[1, 0] * factor + matrix[1, 1];
        }
        return (result);
    }
}