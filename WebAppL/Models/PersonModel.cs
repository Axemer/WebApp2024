using Microsoft.AspNetCore.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace WebAppL.Models
{
    public class PersonModel
    {
        //[Required(ErrorMessage = "Поле 'Фамилия' обязательно для заполнения.")]
        //[RegularExpression("^[А-ЯЁ][а-яё]+$", ErrorMessage = "Введите корректную фамилию.")]
        //public string Surname { get; set; } = "";

        //[Required(ErrorMessage = "Поле 'Имя' обязательно для заполнения.")]
        //[RegularExpression("^[А-ЯЁ][а-яё]+$", ErrorMessage = "Введите корректное имя.")]
        //public string Name { get; set; } = "";

        //[RegularExpression("^[А-ЯЁ][а-яё]+$", ErrorMessage = "Введите корректное имя.")]
        //public string? MidName { get; set; } = "";
        //// не всем завезли, бывает

        //[Required(ErrorMessage = "Поле 'Группа' обязательно для заполнения.")]
        //[RegularExpression("^М[0-9-]+$", ErrorMessage = "Введите корректную группу.")]
        //public string Group { get; set; } = "";

        //[Required(ErrorMessage = "Поле 'Телефон' обязательно для заполнения.")]
        //[Phone(ErrorMessage = "Введите корректный номер телефона.")]
        //public string TelNum { get; set; } = "";

        //[Required(ErrorMessage = "Поле 'E-Mail' обязательно для заполнения.")]
        //[EmailAddress(ErrorMessage = "Введите корректный адрес электронной почты.")]
        //public string Email { get; set; } = "";

        [Required]
        [RegularExpression(@"^[А-ЯЁ][а-яё]*$",
        ErrorMessage = "Имя должно начинаться с заглавной буквы и содержать только кириллицу.")]
        public string Name { get; set; } = "";

        [Required]
        [RegularExpression(@"^[А-ЯЁ][а-яё]*$",
            ErrorMessage = "Фамилия должно начинаться с заглавной буквы и содержать только кириллицу.")]
        public string Surname { get; set; } = "";

        [RegularExpression(@"^[А-ЯЁ][а-яё]*$",
            ErrorMessage = "Отчество должно начинаться с заглавной буквы и содержать только кириллицу.")]
        public string? MidName { get; set; } = "";

        [Required]
        [RegularExpression(@"^[0-9M-]*$",
            ErrorMessage = "Группа может содержать только цифры, символ тире и заглавную букву 'М'.")]
        public string Group { get; set; } = "";

        private string _phone;

        [Required]
        [RegularExpression(@"^(\+7|8)?[\s-]?(\(?\d{3}\)?)[\s-]?(\d{3})[\s-]?(\d{2})[\s-]?(\d{2})$",
            ErrorMessage = "Номер телефона должен быть в формате +7(999)0000000.")]
        public string TelNum
        {
            get => _phone;
            set
            {
                if (value is not null)
                {
                    _phone = FormatPhoneNumber(value);
                }
                else
                {
                    return;
                }
            }
        }

        [Required]
        [RegularExpression(@"([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+)",
            ErrorMessage = "Введите email формата символы@символы.буквы")]
        public string Email { get; set; }

        private string FormatPhoneNumber(string phone)
        {
            string cleaned = Regex.Replace(phone, @"[\s-()]", string.Empty);
            Match match = Regex.Match(cleaned, @"^(\+7|8)?(\d{3})(\d{3})(\d{2})(\d{2})$");

            if (match.Success)
            {
                return $"+7({match.Groups[2].Value}){match.Groups[3].Value}-{match.Groups[4].Value}-{match.Groups[5].Value}";
            }
            return phone ;
        }
    }
}