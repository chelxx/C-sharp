using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
 
namespace TheWall.Models
{
    public abstract class BaseEntity
    {
        // BASE ENTITY IS LEFT EMPTY!!!
    }
    public class RegUser : BaseEntity
    {
        [Required(ErrorMessage="First Name field is required.")]
        [MinLength(2, ErrorMessage="First Name should be more than 2 characters!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="Last Name field is required.")]
        [MinLength(2, ErrorMessage="Last Name should be more than 2 characters!")]
        public string LastName { get; set; }
 
        [Required(ErrorMessage="Email Address field is required.")]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required(ErrorMessage="Password field is required.")]
        [MinLength(8, ErrorMessage="Password should be more than 8 characters!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage="Confirm Password field is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage="Confirmation Password should be more than 8 characters!")]
        public string ConfirmPassword { get; set; }
    }
    public class LoginUser : BaseEntity
    {
        [Required(ErrorMessage="Email Address field is required.")]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required(ErrorMessage="Password field is required.")]
        [MinLength(8, ErrorMessage="Password should be more than 8 characters!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class WallMessage : BaseEntity
    {
        [Required]
        [MinLength(2, ErrorMessage="Message should be more than 2 characters!")]
        public string Message { get; set; }
        [Required]
        [MinLength(2, ErrorMessage="Comment should be more than 2 characters!")]
        public string Comment { get; set; }
    }
}