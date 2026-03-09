using Gym_Membership_Calculator_OOP_Machine_Test_.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym_Membership_Calculator_OOP_Machine_Test_.Gym_Member
{
    internal abstract class GymMember : IMembership 
    {
        public int MemberId {  get; set; }
        public string MemberName {  get; set; }

        public abstract int CalculateFeeCost(int months);

         public GymMember(int memberId, string memberName) 
        {
            this.MemberId   = memberId;   
            this.MemberName = memberName;
        }

    }
}
