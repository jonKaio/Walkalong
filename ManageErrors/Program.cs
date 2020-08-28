using System;

namespace ManageErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int test1 = 100;

            int[] indexOutOfBoundsErrror = { 1, 2, 3 };

            try
            {
                int failOnThis = indexOutOfBoundsErrror[3];
                int test2 = test1 / 0;


            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("OH NO:" + e.Message);
            }
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine("OH NO THIS IS TERRIBLE:" + e.Message);
            //}
            catch(Exception e)
            {
                Console.WriteLine("Something Wonderful has happened:" + e.Message);
            }
            finally
            {
                //Include close a file or something

            }
           




        }
    }
}
