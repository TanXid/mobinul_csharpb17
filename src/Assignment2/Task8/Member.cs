using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Member
    {
        private string membershipId;

        public string MembershipId
        {
            get { return membershipId; }
            private set { membershipId = value; }
        }

        public string Name { get; set; }
        public DateTime MembershipExpirationDate { get; set; }

        public Member()
        {
            MembershipId = Guid.NewGuid().ToString();
        }
    }
}
