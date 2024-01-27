using Microsoft.AspNetCore.Identity;

namespace IdentytiUser.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
