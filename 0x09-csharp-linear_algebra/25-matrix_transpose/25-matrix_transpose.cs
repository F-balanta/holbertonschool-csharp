using System;
/// <summary>
/// 
/// </summary>
class MatrixMath
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] NewMatrix = { };
        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return (NewMatrix);
        NewMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                NewMatrix[j, i] = matrix[i, j];
            }
        }
        return NewMatrix;
    }
}