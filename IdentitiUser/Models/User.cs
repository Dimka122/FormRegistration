using Microsoft.AspNetCore.Identity;

namespace IdentitiUser.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
