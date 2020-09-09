using System;

namespace Properties
{
    class Program
    {
        
        static void Main(string[] args)
        {

            ExampleClass eg1 = new ExampleClass();

            string test = eg1.Name;
            eg1.Name = "Mouse2";



            Console.WriteLine("Hello World!");
        }
    }
}
