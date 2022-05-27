using System;

/// <summary>
///  MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// This method  calculate the determinant of a matrix.
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>Decimal</returns>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return -1;
        if (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3)
            return -1;
        if (matrix.GetLength(0) == 2)
        {
            return (Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2));
        }
        double result1 = matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1];
        double result2 = matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0];
        double result3 = matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0];
        return (Math.Round(matrix[0, 0] * result1 - matrix[0, 1] * result2 + matrix[0, 2] * result3, 2));
    }
}