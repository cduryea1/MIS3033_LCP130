namespace f2
{
   public interface IDanceClubMember
    {
        public string clubMemID { get; set; }
        public bool PayMembershipFee(double amount);
    }
}