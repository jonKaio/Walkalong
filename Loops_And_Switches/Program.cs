using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Loops and switches examples
/// </summary>
namespace Loops_And_Switches
{
    class Program
    {
        static void Main(string[] args)
        {
            int i ;
            int breakOutAtThisPoint = 5;
            for ( i=0; i<10; i ++)
            {
                Console.WriteLine($"Line{i}");
                if(i==breakOutAtThisPoint)
                {
                    break;
                }
            }
            Console.WriteLine(i);
            int[] tmpArray = { 1, 2, 3, 5, 8, 13, 21 };
            foreach(int tmp in tmpArray)
            {
                Console.WriteLine($"Line {tmp}");
           //     tmp = 23;
            }

            i = 0;
            while (i < 7)
            {
                Console.WriteLine($"Line {i}");

                switch (i)
                {
                    case 0:
                        Console.WriteLine("Zero reached");
                        break;
                    case 1:
                        Console.WriteLine("number 1 is reached");
                        break;
                    case 2:
                    case 3:
                        Console.WriteLine("Either 2 or 3 have been reached.");
                        break;
                    default:
                        Console.WriteLine("Unknown");
                        break;
                }
                i++;

            }

            Console.ReadLine();
        }
    }


}
