using System;
using System.IO;

namespace TryCatch
{
    
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Testing Try & Catch");

            Console.WriteLine("Please input a number, no text definately no text ?");
            //string tmp = Console.ReadLine();
            //int a=-1;
            //try
            //{
            //a=int.Parse(tmp);


            //}
            //catch (System.FormatException)
            //{
            //    Console.WriteLine("You fool you entered some text");

            //}

            //Console.Write($"You entered the number {a.ToString()}");

            //try
            //{
            //    using (var file = File.OpenText("MyImaginaryFile"))
            //    {
            //        string tmp2 = file.ReadLine();
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("File does not exist");

            //}

            //return;

            try
            {
                string tmp = Console.ReadLine();
                int a = -1;
                
                a = int.Parse(tmp);

                    using (var file = File.OpenText("ARcealFile.txt"))
                {
                    string tmp3;
                    for (int i = 0; i < 10; i++)
                    {
                        tmp3 = file.ReadLine();
                        Console.WriteLine(tmp3);
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
               
                Console.WriteLine("File Not Found");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("You entered text!!");

            }
            finally
            {


            }


        }
    }
}
