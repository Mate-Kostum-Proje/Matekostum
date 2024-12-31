using System.ComponentModel.DataAnnotations;

namespace Mate.MVC.Models.VMs
{
    public class UserEditUserVM
    {
        [Required]
        public string Id { get; set; }

        [Required(ErrorMessage = "Ad Alanı zorunludur")]
        [MinLength(2, ErrorMessage = "En az 2 karakter olmalıdır")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Soyad Alanı zorunludur")]
        [MinLength(2, ErrorMessage = "En az 2 karakter olmalıdır")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "TC No Alanı zorunludur")]
        [MinLength(11, ErrorMessage = "En az 11 karakter olmalıdır")]
        [MaxLength(11, ErrorMessage = "En fazla 11 karakter olmalıdır")]
        public string TcNo { get; set; }

        [Required(ErrorMessage = "Email Alanı zorunludur")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Gsm Alanı zorunludur")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        [DataType(DataType.PhoneNumber)]
        public string GSM { get; set; }

        [Required(ErrorMessage = "Adres Alanı zorunludur")]
        [MaxLength(300, ErrorMessage = "En fazla 300 karakter olmalıdır")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Şehir Alanı zorunludur")]
        [MaxLength(20, ErrorMessage = "En fazla 20 karakter olmalıdır")]
        public string City { get; set; }

        [Required(ErrorMessage = "İlçe Alanı zorunludur")]
        [MaxLength(20, ErrorMessage = "En fazla 20 karakter olmalıdır")]
        public string District { get; set; }
    }
}
