using System;

namespace Matrix
{
    class TestProgram
    {
        static void Main()
        {
            Matrix<int> firstMatrix = new Matrix<int>(3, 3);
            Matrix<int> secondMatrix = new Matrix<int>(3, 3);

            //initializing the matrixes
            int counter = 0;
            for (int i = 0; i < firstMatrix.Cols; i++)
            {
                for (int j = 0; j < firstMatrix.Rows; j++)
                {
                    counter++;
                    firstMatrix[i, j] = counter;
                }
            }

            for (int i = 0; i < secondMatrix.Cols; i++)
            {
                for (int j = 0; j < secondMatrix.Rows; j++)
                {
                    secondMatrix[i, j] = counter;
                    counter--;
                }
            }

            Console.WriteLine(firstMatrix);

            Console.WriteLine(secondMatrix);

            Console.WriteLine(firstMatrix + secondMatrix);

            Console.WriteLine(firstMatrix * secondMatrix);

          
        }
    }
}
