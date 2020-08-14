using System;

namespace Walkalong
{
    class Program
    {
        static void Main(string[] args)
        {
            MyEg myEg = new MyEg();
            myEg.Name = "Freddie";

            Console.WriteLine("Hello World!"+myEg.Name);
        }
    }

    class MyEg
    {
        private float gravity = -9.81f;
        public float Gravity { get => gravity; set => gravity = value; }

        public int myInt = 25;
        private string name;
        public string Name
        {
            //get
            //{
            //    return name;
            //}
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }
    }

}
