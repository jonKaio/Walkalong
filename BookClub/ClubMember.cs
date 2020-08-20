using System;
using System.Collections.Generic;
using System.Text;

namespace BookClub
{
    /// <summary>
    /// A basic member class to hold a simple record of a person in the club.
    /// </summary>
    class ClubMember
    {
        public string firstName;
        public string lastName;
        public float subsPaid;

        /// <summary>
        /// Default constructor needed when we use custom constructors
        /// </summary>
        public ClubMember() { }

        /// <summary>
        /// Custom constructor
        /// </summary>
        /// <param name="_fName">First name</param>
        /// <param name="_lName">Last Name</param>
        /// <param name="_paid">The starting balance</param>
        public ClubMember(string _fName, string _lName,float _paid)
        {
            //this isn't necessarily a requirement here, though would add clarity.
            firstName = _fName;
            lastName = _lName;
            subsPaid = _paid;
        }



        /// <summary>
        /// Use this to add to the members current balance.
        /// </summary>
        /// <param name="amt"> The amount to add</param>
        public void PaySubs(float amt)
        {
            subsPaid += amt;
        }
        public void PrintDets()
        {
            Console.WriteLine($"{firstName} {lastName} has paid {subsPaid} subs in total.");

        }

    }
}
