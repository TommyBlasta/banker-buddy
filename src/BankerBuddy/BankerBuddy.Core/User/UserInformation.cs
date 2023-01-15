namespace BankerBuddy.Core.User
{
    public class UserInformation
    {
        public Guid UserGuid { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;

    }
}