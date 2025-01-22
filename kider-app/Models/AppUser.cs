using Microsoft.AspNetCore.Identity;

namespace kider_app.Models;

public class AppUser : IdentityUser
{
    public string FullName { get; set; }
}
