using System;
using System.IO.Pipes;

namespace Inherit
{
    //class Example
    //{
    //  //  protected int protInteger = 5;
    //    public int publicInteger = 2;
    //  //  private int privateInteger = 1;

    //  public virtual void Test()
    //    {
    //        Console.WriteLine(publicInteger);
    //       // protInteger = 6;
    //        //publicInteger = 7;
    //     //   privateInteger = 8;
    //    }

    //}

    //class ExampleChild : Example
    //{
    //    public int publicInteger = 99;

     
    //    //public int ProtInteger
    //    //{
    //    //    get => protInteger;
    //    //    set => protInteger = value;
    //    //}

    //    public void Test2()
    //    {
    //        Console.WriteLine(publicInteger);
    //        //publicInteger = 1;
    //       // protInteger = 2;
    //       //privateInteger = 3;
    //    }
    //}


    class Program
    {
        static void Main(string[] args)
        {
            //Example eg = new Example();
            //eg.Test();
            //Console.WriteLine("---------------");
            //ExampleChild egChild = new ExampleChild();
            //egChild.Test();
            //egChild.Test2();



            // return;

            //Object tmpObject = egChild;



            Animal fredTheAnimal = new Animal();
            fredTheAnimal.numberOfLegs = 5;
            fredTheAnimal.Speak();



            Dog myDog = new Dog();
            myDog.numberOfLegs = 3;
            myDog.Speak();
            Console.WriteLine("-------");

            Cat myCat = new Cat();
            myCat.Speak();
            
            Mouse broonsMouse = new Mouse();

            myDog.Speak();
            myCat.Speak();
            broonsMouse.Speak();

            Animal tmpAnimal = myDog;
            tmpAnimal.Speak();


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
