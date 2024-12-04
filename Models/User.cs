using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Указание имени обязательно")]
        [SingleWordWithCapitalAttribute(ErrorMessage="Имя должно начинаться с заглавной буквы и содержать только одно слово")]
        public string FirstName{ get; set; }

        [Required(ErrorMessage = "Указание фамилииобязательна")]
        [SingleWordWithCapitalAttribute(ErrorMessage="Фамилия должна начинаться с заглавной буквы и содержать только одно слово")]
        public string LastName{ get; set; }

        [Required(ErrorMessage = "Указание отчестваобязательно")]
        [SingleWordWithCapitalAttribute(ErrorMessage="Отчество должно начинаться с заглавной буквы и содержать только одно слово")]
        public string SurName{ get; set; }

        [Required(ErrorMessage = "Указание города обязательно")]
        [SingleWordWithCapitalAttribute(ErrorMessage="Город должен начинаться с заглавной буквы и содержать только одно слово")]
        public string City { get; set; }

        [Required(ErrorMessage = "Указание улицы обязательно")]
        [SingleWordWithCapitalAttribute(ErrorMessage="Улица должна начинаться с заглавной буквы и содержать только одно слово")]
        public string Square { get; set; }

        [Required(ErrorMessage = "Указание номера дома обязательно")]
        [DigitAndLetterAttribute(ErrorMessage = "Номер дома может включать в себя только число, или число с буквой(без пробела)")]
        public string HouseNumber { get; set; }

        [DigitAndLetterAttribute(ErrorMessage = "Номер квартиры может включать в себя только число, или число с буквой(без пробела)")]
        public string? ApartmentNumber { get; set; }

        [Required(ErrorMessage = "Номер телефона обязателен")]
        [Phone(ErrorMessage = "Некорректный номер телефона")]
        public string PhoneNumber { get; set; }
    }
}
