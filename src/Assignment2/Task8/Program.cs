using Task8;

Member regularMember = new Member
{
    Name = "Mobinul Ahasan",
    MembershipExpirationDate = DateTime.Now.AddYears(1)
};

Console.WriteLine($"Regular Member:\n Name: {regularMember.Name}\n Membership ID: {regularMember.MembershipId}\n Expiration Date: {regularMember.MembershipExpirationDate}\n");

VIPMember vipMember = new VIPMember
{
    Name = "Md. Jalal Uddin",
    MembershipExpirationDate = DateTime.Now.AddYears(2)
};

Console.WriteLine($"VIP Member:\n Name: {vipMember.Name}\n Membership ID: {vipMember.MembershipId}\n Expiration Date: {vipMember.MembershipExpirationDate}\n");