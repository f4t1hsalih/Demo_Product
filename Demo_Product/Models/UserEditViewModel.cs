using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen bir isim giriniz!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen bir soyisim giriniz!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet giriniz!")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen bir şifre giriniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen bir maail adresi giriniz!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz!")]
        [Compare("Password", ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olun")]
        public string ConfirmPassword { get; set; }
    }
}
