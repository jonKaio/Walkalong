using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class ExampleClass
    {
        //private string name = "Test123";

        //public string Name
        //{
        //    get => name;
        //    set =>  name = value;
        //}


        public string Name { get;  set; }

        public ExampleClass()
        {
            Name = "MOUSE55";
        }
        public void PrintName()
        {
            Name = "mouse";
            Console.WriteLine(Name);
        }

    }
}
