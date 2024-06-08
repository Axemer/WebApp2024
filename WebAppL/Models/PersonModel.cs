using System.ComponentModel.DataAnnotations;

namespace WebAppL.Models
{
    public class PersonModel
    {
        [Required(ErrorMessage = "Поле 'Фамилия' обязательно для заполнения.")]
        [RegularExpression("^[А-ЯЁ][а-яё]+$", ErrorMessage = "Введите корректную фамилию.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Поле 'Имя' обязательно для заполнения.")]
        [RegularExpression("^[А-ЯЁ][а-яё]+$", ErrorMessage = "Введите корректное имя.")]
        public string Name { get; set; }

        [RegularExpression("^[А-ЯЁ][а-яё]+$", ErrorMessage = "Введите корректное имя.")]
        public string? MidName { get; set; }
        // не всем завезли, бывает

        [Required(ErrorMessage = "Поле 'Группа' обязательно для заполнения.")]
        [RegularExpression("^М[0-9-]+$", ErrorMessage = "Введите корректную группу.")]
        public string Group { get; set; }

        [Required(ErrorMessage = "Поле 'Телефон' обязательно для заполнения.")]
        [Phone(ErrorMessage = "Введите корректный номер телефона.")]
        public string TelNum { get; set; }

        [Required(ErrorMessage = "Поле 'E-Mail' обязательно для заполнения.")]
        [EmailAddress(ErrorMessage = "Введите корректный адрес электронной почты.")]
        public string Email { get; set; }

    }
}