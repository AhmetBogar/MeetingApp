using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
	public class UserInfo
	{
        public int Id { get; set; }
        
		[Required(ErrorMessage ="İsim bilgisi giriniz.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon bilgisi giriniz.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Mail adres bilgisi giriniz.")]
        [EmailAddress]
		public string? Email { get; set; }

        [Required(ErrorMessage = "Katılım durumunuzu seçiniz.")]
        public bool? WillAttend { get; set; }
    }
}
