using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RazorPagesPizza.Data;

// Add profile data for application users by adding properties to the RazorPagesPizzaUser class
public class RazorPagesPizzaUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

