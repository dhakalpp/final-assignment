
/*
 Name=Priyanka Dhakal
 Student ID=30001935
 */
 using System;

namespace AddMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating matrices
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];
            int[,] matrix3 = new int[3, 3];

            //variables for loops
            int i = 0, j = 0;

            //to obtain random values
            Random random = new Random();

            //loop to add values to matrices
            while(i < 3)
            {
                j = 0;
                while(j < 3)
                {
                    //populating matrix A and B with randomly generated numbers between -10 and 10
                    matrix1[i,j] = random.Next(-10, 10);
                    matrix2[i, j] = random.Next(-10, 10);
                    j++;
                }
                i++;
            }

            //resetting value to use again
            i = 0;

            //displaying first matrix
            Console.WriteLine("\nRandom Values in Matrix A (3X3) are:");

            while (i < 3)
            {
                j = 0;
                while (j < 3)
                {
                   Console.Write(matrix1[i, j] + " ");
                    j++;
                }
                i++;
            }

            //displaying second matrix
            Console.WriteLine("\n\nRandom Values in Matrix B(3X3) are:");
            i = 0;

            while (i < 3)
            {
                j = 0;
                while (j < 3)
                {
                    Console.Write(matrix2[i, j] + " ");
                    j++;
                }
                i++;
            }

            i = 0;
            //adding matrix A and B 
            while (i < 3)
            {
                j = 0;
                while (j < 3)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                    j++;
                }
                i++;
            }

            //displayong third matrix
            Console.WriteLine("\n\nValues of Matrix C (A+B)are:");

            i = 0;

            while (i < 3)
            {
                j = 0;
                while (j < 3)
                {
                    Console.Write(matrix3[i, j] + " ");
                    j++;
                }
                i++;
            }

            Console.ReadKey();

        }
    }
}
