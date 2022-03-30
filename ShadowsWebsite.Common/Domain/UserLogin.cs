using System.ComponentModel.DataAnnotations;
namespace ShadowsWebsite.Common.Domain
{
    public class UserLogin
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}