using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] gridMap = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    gridMap[i, j] = ((i * 3) + (j + 1));

        }
    }
}
