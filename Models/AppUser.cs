using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Norboev_Asilbek_HW4.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name= "Last Name")]
        public String LastName { get; set; }

    }
}
