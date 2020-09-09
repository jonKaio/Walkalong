using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace TextFiles
{

    class Program
    {
        static void Main(string[] args)
        {
            #region
            //StreamWriter writer;
            //writer = new StreamWriter("test.txt");
            //writer.WriteLine("hello world");
            //writer.Close();


            //StreamReader reader = new
            //StreamReader("test.txt");
            //while (!reader.EndOfStream)
            //{
            //    string line = reader.ReadLine();
            //    Console.WriteLine(line);
            //}
            //reader.Close();

            //string[] lines = File.ReadAllLines("test.txt");

            // smallArray---------V
            int[] smallArray = { 1,2,3 };

            // smallArray[0] =1000
            // smallArray[1] =1004
            // smallArray[2] =1008

            // smallArray[3] =1012
            //smallArray[1]

            //Console.WriteLine(smallArray[1]);

            //smallArray = new int[9];
            foreach (var v in smallArray)
                Console.WriteLine(v);
            #endregion

            for (int i = 0; i < smallArray.Length; i++)
                Console.WriteLine(smallArray[i]);

            int[,] ticTacToe = new int[3,3];
            Random rng = new Random();
            //Fill with random
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    ticTacToe[x, y] = rng.Next();
                }
            }




          bool gameRunning = true;
            //clear with a fresh array.

            ticTacToe = new int[3, 3];
            while (gameRunning)
            {
                string cmd = Console.ReadLine().ToLower();

                switch (cmd)
                {
                    case "showboard":
                        DisplayBoard(ticTacToe);
                        break;
                    case "place x":
                        Console.WriteLine("which row ?");
                        int row,col;
                        string rowString = Console.ReadLine();
                        int.TryParse(rowString, out row);
                        Console.WriteLine("which col ?");
                        string colString = Console.ReadLine();
                        int.TryParse(colString, out col);
                        ticTacToe[row, col] = 1;
                        DisplayBoard(ticTacToe);
                        break;
                    case "place o":
                        Console.WriteLine("which row ?");
                        int row2, col2;
                        string rowString2 = Console.ReadLine();
                        int.TryParse(rowString2, out row);
                        Console.WriteLine("which col ?");
                        string colString2 = Console.ReadLine();
                        int.TryParse(colString2, out col);
                        ticTacToe[row, col] = 2;
                        DisplayBoard(ticTacToe);
                        break;

                    default:
                        break;
                }

            }

        }   

        static void DisplayBoard(int[,] _board)
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
Console.Write($" {(_board[x,y]==0?"_":_board[x,y]==1?"X":"O")  } ");
                }
                Console.WriteLine("");
            }

        }


    }
}
