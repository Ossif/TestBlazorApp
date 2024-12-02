using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя обязательно")]
        public string FirstName{ get; set; }

        [Required(ErrorMessage = "Фамилия обязательна")]
        public string LastName{ get; set; }

        [Required(ErrorMessage = "Отчество обязательно")]
        public string SurName{ get; set; }

        [Required(ErrorMessage = "Адрес обязателен")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Номер телефона обязателен")]
        [Phone(ErrorMessage = "Некорректный номер телефона")]
        public string PhoneNumber { get; set; }
    }
}
