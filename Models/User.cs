using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Указание имени обязательно")]
        [SingleWordWithCapitalAttribute(ErrorMessage="Имя должно начинаться с заглавной буквы и содержать только одно слово")]
        [Display(Name = "Имя")]
        public string FirstName{ get; set; }

        [Required(ErrorMessage = "Указание фамилииобязательна")]
        [SingleWordWithCapitalAttribute(ErrorMessage="Фамилия должна начинаться с заглавной буквы и содержать только одно слово")]
        [Display(Name = "Фамилия")]
        public string LastName{ get; set; }

        [Required(ErrorMessage = "Указание отчестваобязательно")]
        [SingleWordWithCapitalAttribute(ErrorMessage="Отчество должно начинаться с заглавной буквы и содержать только одно слово")]
        [Display(Name = "Отчество")]
        public string SurName{ get; set; }

        [Required(ErrorMessage = "Указание города обязательно")]
        [SingleWordWithCapitalAttribute(ErrorMessage="Город должен начинаться с заглавной буквы и содержать только одно слово")]
        [Display(Name = "Город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Указание улицы обязательно")]
        [SingleWordWithCapitalAttribute(ErrorMessage="Улица должна начинаться с заглавной буквы и содержать только одно слово")]
        [Display(Name = "Площадь")]
        public string Square { get; set; }

        [Required(ErrorMessage = "Указание номера дома обязательно")]
        [DigitAndLetterAttribute(ErrorMessage = "Номер дома может включать в себя только число, или число с буквой(без пробела)")]
        [Display(Name = "Номер дома")]
        public string HouseNumber { get; set; }

        [DigitAndLetterAttribute(ErrorMessage = "Номер квартиры может включать в себя только число, или число с буквой(без пробела)")]
        [Display(Name = "Номер квартиры")]
        public string? ApartmentNumber { get; set; }

        [Required(ErrorMessage = "Номер телефона обязателен")]
        [Phone(ErrorMessage = "Некорректный номер телефона")]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }
    }
}
