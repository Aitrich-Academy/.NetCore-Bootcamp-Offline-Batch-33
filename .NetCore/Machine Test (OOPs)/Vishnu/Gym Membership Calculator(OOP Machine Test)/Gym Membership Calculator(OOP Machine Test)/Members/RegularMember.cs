using Gym_Membership_Calculator_OOP_Machine_Test_.Gym_Member;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym_Membership_Calculator_OOP_Machine_Test_.Members
{
    internal class RegularMember : GymMember
    {
        private int RegularRate = 20;
        public RegularMember(int memberId, string memberName)
            : base(memberId, memberName) { }

        private int CalculateFee(int months)
        {
            return months * RegularRate;
        }

        public override int CalculateFeeCost(int months)
        {
            return CalculateFee(months);
        }



    }
}
