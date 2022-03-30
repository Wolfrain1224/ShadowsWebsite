using System.ComponentModel.DataAnnotations;

namespace ShadowsWebsite.Common.Domain
{
    public class RegisterModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "Username to long")]
        [MinLength (5, ErrorMessage = "Username to short")] 
        public string Username { get; set; }
        
        [Required]
        [StringLength(15, ErrorMessage = "Password to long")]
        [MinLength (5, ErrorMessage = "Password to short")]
        public string Password { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string Lastname { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        public string Phone { get; set; }
    }
}