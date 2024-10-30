using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MVCProject.Models {
    public class ApplicationUser : IdentityUser {
        [Required]
        public required string Address { get; set; }

        [StringLength(15)]
        public string FamilyPhone { get; set; }
    }
}