using Microsoft.AspNetCore.Identity;

namespace MovieTrackerMVC.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name{ get; set; }
    }
}
