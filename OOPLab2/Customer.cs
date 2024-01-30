using System;
namespace OOPLab2
{
	public class Customer : User
	{
        public int MemberShipLevel = 1;
		public Customer()
		{
		}

        public int CheckMemberShipLevel()
        {
            return this.MemberShipLevel;
        }
    }
}

