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
