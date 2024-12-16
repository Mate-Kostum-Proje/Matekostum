using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mate.MVC.Models.VMs
{
    public class UserInsertVM
    {
        [Required(ErrorMessage = "Ad Alani zorunludur")]
        [MinLength(2, ErrorMessage = "En az 2 karakter olmalidir")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalidir")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Soyad Alani zorunludur")]
        [MinLength(2, ErrorMessage = "En az 2 karakter olmalidir")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalidir")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "TC No Alani zorunludur")]
        [MinLength(11, ErrorMessage = "En az 11 karakter olmalidir")]
        [MaxLength(11, ErrorMessage = "En fazla 11 karakter olmalidir")]
        public string TcNo { get; set; }

        [Required(ErrorMessage = "Email Alani zorunludur")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Gsm Alani zorunludur")]
        [DataType(DataType.PhoneNumber)]
        public string GSM { get; set; }

        [Required(ErrorMessage = "Adres Alani zorunludur")]
        [MaxLength(50, ErrorMessage = "En fazla 10000 karakter olmalidir")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Şehir Alani zorunludur")]
        [MaxLength(50, ErrorMessage = "En fazla 10000 karakter olmalidir")]
        public string City { get; set; }

        [Required(ErrorMessage = "İlçe Alani zorunludur")]
        [MaxLength(50, ErrorMessage = "En fazla 10000 karakter olmalidir")]
        public string District { get; set; }

        [Required(ErrorMessage = "Şifre Alani zorunludur")]
        [MinLength(2, ErrorMessage = "En az 3 karakter olmalidir")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalidir")]
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Alani zorunludur")]
        [MinLength(2, ErrorMessage = "En az 3 karakter olmalidir")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalidir")]
        [DisplayName("Şifre Tekrar")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }

        //public IFormFile? Picture { get; set; }

        public List<CheckBoxVM> Roles { get; set; } = new List<CheckBoxVM>();
    }
}