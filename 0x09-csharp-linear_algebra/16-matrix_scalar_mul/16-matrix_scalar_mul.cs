using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] Array = { { -1 } };
        // If the matrix is not a 2D or 3D matrix, return a matrix containing -1
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return (Array);
        }
        // If the matrix is not a 2D or 3D matrix, return a matrix containing -1
        if (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3)
        {
            return (Array);
        }
        double[,] Result = null;
        if (matrix.GetLength(0) == 2)
            Result = new double[2, 2];
        else
            Result = new double[3, 3];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Result[i, j] = scalar * matrix[i, j];
            }
        }
        return (Result);
    }
}