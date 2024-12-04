using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class DigitAndLetterAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
        {
            return ValidationResult.Success;
            //return new ValidationResult(ErrorMessage ?? "Поле обязательно для заполнения.");
        }

        var strValue = value.ToString();

        // Проверка на числа или числа с одной буквой в конце
        var regex = new Regex(@"^\d+([a-zA-Zа-яА-ЯёЁ]{1})?$");
        if (!regex.IsMatch(strValue))
        {
            return new ValidationResult(ErrorMessage ?? "Поле должно содержать только числа или число с одной буквой в конце.");
        }

        return ValidationResult.Success;
    }
}
