using System;

namespace BookClub
{
    class Program
    {
        static void Main(string[] args)
        {
            MembershipList scifiBookClub = new MembershipList();

            ClubMember james = new ClubMember();
            james.firstName = "James";
            james.lastName = "Cardo";
            james.subsPaid = 0;

            ClubMember terry = new ClubMember();
            terry.firstName = "Terry";
            terry.lastName = "Nguyen";
            terry.subsPaid = 100;
            scifiBookClub.memberList[0] = james;
            scifiBookClub.memberList[1] = terry;

            scifiBookClub.ZeroBalance();
            james.PaySubs(50);
            scifiBookClub.ZeroBalance();
            scifiBookClub.avgPaid();

        }
    }
}
