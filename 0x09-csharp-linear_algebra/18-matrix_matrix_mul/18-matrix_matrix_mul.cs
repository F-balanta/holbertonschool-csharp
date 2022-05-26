using System;
/// <summary>
/// Matrix Class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multuply
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns>Result</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] array = { { -1 } };
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            return (array);
        }
        double[,] Result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    Result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return (Result);
    }
}
