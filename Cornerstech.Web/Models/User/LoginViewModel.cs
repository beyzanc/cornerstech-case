using System.ComponentModel.DataAnnotations;

namespace Cornerstech.Web.Models.User
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı giriniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Parola giriniz.")]
        public string Password { get; set; }
    }
}
