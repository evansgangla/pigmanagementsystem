using System.ComponentModel.DataAnnotations;

namespace SwineManagementSys.Models
{
    public class Login
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

        public string RememberMe { get; set; }
        public string Token { get; set; }
    }
}
