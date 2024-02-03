using Microsoft.AspNetCore.Identity;


namespace IdentityASP.NET.Models
{
    public class AppUser  : IdentityUser
    {
        public string NickName { get; set; }

    }
}
