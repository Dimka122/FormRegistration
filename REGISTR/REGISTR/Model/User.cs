using Microsoft.AspNetCore.Identity;

namespace REGISTR.Model
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
