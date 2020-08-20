using System;
using System.Collections.Generic;
using System.Text;

namespace BookClub
{
    class ClubMember
    {
        public string firstName;
        public string lastName;
        public float subsPaid;

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
