using System;

namespace BookClub
{

class Program
    {
        static void Main(string[] args)
        {
            MembershipList scifiBookClub = new MembershipList();

            //Create a member we can later add to the list
            ClubMember james = new ClubMember();
            james.firstName = "James";
            james.lastName = "Cardo";
            james.subsPaid = 0;

            //Create a member we can later add to the list
            ClubMember terry = new ClubMember();
            terry.firstName = "Terry";
            terry.lastName = "Nguyen";
            terry.subsPaid = 100;

            //Using a constructor to initialize the values at the same time.
            ClubMember misty = new ClubMember("Misty", "Loreen", 0f);




            //Add the various members to the list
            //Though strictly speaking we're simply assigning 
            //them to the array elements.
            scifiBookClub.memberList[0] = james;
            scifiBookClub.memberList[1] = terry;
            scifiBookClub.memberList[2] = misty;
            //using a constructor without an intermediate variable to hold the new member.
            scifiBookClub.memberList[3] = new ClubMember("Amy", "Winkler", 0f);

            //Run some of our methods
            //note: Methods not Functions functions are for C++ fans.
            scifiBookClub.ZeroBalance();
            james.PaySubs(50);
            scifiBookClub.ZeroBalance();
            scifiBookClub.avgPaid();

        }
    }
}
