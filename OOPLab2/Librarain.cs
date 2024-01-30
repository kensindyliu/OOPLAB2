using System;
namespace OOPLab2
{
	public class Librarain : User
	{
		public Librarain()
		{
		}

        public void UpdateMembershipLevel(Customer customer, int newMembershipLevel)
        {
            customer.MemberShipLevel = newMembershipLevel;
        }
    }
}

