using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class SingleWordWithCapitalAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {        
        if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
        {
            return ValidationResult.Success;
            //return new ValidationResult(ErrorMessage ?? "Поле обязательно для заполнения.");
        }

        var strValue = value.ToString();

        // Проверка на одно слово, начинающееся с заглавной буквы и состоящее только из букв
        var regex = new Regex(@"^[A-ZА-ЯЁ][a-zа-яё]*$");
        if (!regex.IsMatch(strValue))
        {
            return new ValidationResult(ErrorMessage ?? "Поле должно содержать только одну букву, начинаться с заглавной и состоять только из букв");
        }

        return ValidationResult.Success;
    }
}
