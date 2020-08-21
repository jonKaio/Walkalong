using System;

namespace Inherit
{
    class Example
    {
        protected int protInteger = 5;
        public int publicInteger = 2;
        private int privateInteger = 1;

        void Test()
        {
            protInteger = 6;
            publicInteger = 7;
            privateInteger = 8;
        }

    }

    class ExampleChild : Example
    {
     

        //public int ProtInteger
        //{
        //    get => protInteger;
        //    set => protInteger = value;
        //}

        public void Test2()
        {
            publicInteger = 1;
            protInteger = 2;
            //privateInteger = 3;


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Example eg = new Example();
            //eg.publicInteger = 10;
            //ExampleChild egChild = new ExampleChild();
            //egChild.publicInteger = 10;        
            //Object tmpObject = egChild;

            Dog myDog = new Dog();
            Cat myCat = new Cat();
            Mouse broonsMouse = new Mouse();

            //myDog.Speak();
            //myCat.Speak();
            //broonsMouse.Speak();

            Animal[] zoo = { myDog, myCat, broonsMouse };


            Spider spider1 = new Spider();
            spider1.SayName();
            
            foreach (Animal animal in zoo)
            {
                animal.Speak();
                //if (animal is Cat && (animal as Cat).lovesCheese)
                //    Console.WriteLine("Feed me cheese");

                if (animal is Mouse && (animal as Mouse).lovesCheese)
                    Console.WriteLine("Feed me cheese");
                    
            }

        }
    }
}
