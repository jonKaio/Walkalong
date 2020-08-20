using System;
using System.Collections.Generic;
using System.Text;

namespace BookClub
{
/// <summary>
/// An exclusive book club that can only have 10 members 
/// a limit of using arrays, there are ways around this 
/// but we can explore those later.
/// </summary>
    class MembershipList
    {
        
        public ClubMember[] memberList = new ClubMember[10];

        /// <summary>
        /// Zero balance displays a list of member who haven't paid yet.
        /// </summary>
        public void ZeroBalance()
        {
            Console.WriteLine("The following members have not paid any subs");
            foreach(ClubMember cMember in memberList)
            {
                if(cMember!=null)
                if (cMember.subsPaid == 0)
                    cMember.PrintDets();
            }
        }

        public void avgPaid()
        {
            float totalPaid
                = 0;
            int membershipCount = 0;

            foreach (ClubMember cMember in memberList)
            {
                if (cMember != null)
                {
                    totalPaid += cMember.subsPaid;
                    membershipCount++;
                }
            }
            Console.WriteLine($"The average paid {totalPaid / membershipCount}");

        }


    }
}
