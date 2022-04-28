using System;

namespace MyMath
{
    /// <summary> Class Matrix that returna new maztrix with elements divided</summary>
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {

            int j, i;
           
            if ( matrix.GetLength(0) == 0 && matrix.GetLength(1) == 0 )
                return null;
            if(num >= 0)
            {
                try
                {
                    for (i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[i, j] = matrix[i, j] / num;
                        }
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Num cannot be 0");
                    return null;
                }
            }
            return matrix;
        }
    }
}
