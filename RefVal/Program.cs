using System;

namespace RefVal
{

    // Uncomment the struct version of account to see
    // behaviour of a struct based variable (An example of VALUE types)

    struct Account
    {
        public string name;
    }

    // Uncomment the class version of account to see
    // behaviour of a class based variable (An example of REFERENCE types)
    //class Account
    //{
    //    public string name;
    //}
    class StructsAndClassesDemo
    {
        public static void Main()
        {
            //Account could either be a STRUCT or a CLASS depending on the above.

            Account robsAccount = new Account();
            Account fakeRobsAccount;

            robsAccount.name = "Rob";
            fakeRobsAccount = robsAccount;
            Console.WriteLine("-----Starting Values-------");
            Console.WriteLine($"robsAccount name is {robsAccount.name}");
            Console.WriteLine($"fakeRobsAccount name is {fakeRobsAccount.name}");


            //Change fakeRobsAccount.name and see what happens
            //Behaviour is different depending on it being a STRUCT or a CLASS
            fakeRobsAccount.name = "FAKE ROB";
            Console.WriteLine($"robsAccount name is {robsAccount.name}");
            Console.WriteLine($"fakeRobsAccount name is {fakeRobsAccount.name}");

            Console.WriteLine("------Testing Value Vs Ref------");
            Console.WriteLine($"robsAccount name is {robsAccount.name}");
            Console.WriteLine($"fakeRobsAccount name is {fakeRobsAccount.name}");
            Console.WriteLine("-------Executing the Test Method-----");
            Test(ref fakeRobsAccount);
            Console.WriteLine($"robsAccount name is {robsAccount.name}");
            Console.WriteLine($"fakeRobsAccount name is {fakeRobsAccount.name}");

        }
        /// <summary>
        /// TestAccount....
        /// Whan dealing with a STRUCT:-
        /// This will simply not effect the value of the variable passed into it.
        /// Because it's a copy of a VALUE
        /// 
        /// When dealing with a CLASS:-
        /// Effectively the value being passed into it is a REFERENCE (coz it's an object)
        /// And so _myAcc is a reference coz it's also an object
        /// so the effect is the same as saying _myAcc = objectReferenceWasPassedToIt
        /// So whatever happens to _myAcc happens to objectReferenceWasPassedToIt
        /// 
        /// </summary>
        /// <param name="_myAcc"></param>

        static void TestAccount(Account _myAcc)
        {
            _myAcc.name = "boris";
        }

        /// <summary>
        /// Test
        /// This accepts an Account by REFERENCE, which means we'll be able to
        /// completely change what object is referred to by the variable we provided
        /// as an argument when we called this method.
        ///
        /// In this case, we're going to completely overwrite the variable we
        /// passed in with a completely new instance of the Account type.
        /// 
        /// </summary>
        /// <param name="_myAcc2"></param>
        static void Test(ref Account _myAcc2)
        {
            _myAcc2 = new Account();
            _myAcc2.name = "Hector";
        }

    }
}