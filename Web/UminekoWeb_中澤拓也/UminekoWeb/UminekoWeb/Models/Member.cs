namespace UminekoWeb.Models
{
    public class Member
    {
        public Member() { }

        public Member(string? memberCode, string? memberName)
        {
            MemberCode = memberCode;
            MemberName = memberName;
        }
        public string? MemberCode { get; set; }

        public string? MemberName { get; set; }
    }
}