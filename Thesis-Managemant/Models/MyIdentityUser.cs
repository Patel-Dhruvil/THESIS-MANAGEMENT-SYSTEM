using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thesis_Managemant.Models
{
    public class MyIdentityUser
         : IdentityUser<Guid>
    {

        [Display(Name = "Display Name")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [MinLength(2, ErrorMessage = "{0} should have at least {1} characters.")]
        [StringLength(60, ErrorMessage = "{0} cannot have more than {1} characters.")]
        public string DisplayName { get; set; }


        [Display(Name = "Date of Birth")]
        [Required]
        [PersonalData]                                      // for GDPR Complaince
        [Column(TypeName = "smalldatetime")]
        public DateTime DateOfBirth { get; set; }


        [Display(Name = "Is Admin User?")]
        public bool IsAdminUser { get; set; }


        [Display(Name = "Is student User?")]
        public bool IsStudentUser { get; set; }


        [Display(Name = "Is Faculty User?")]
        public bool IsFacultyUser { get; set; }
    }
}
