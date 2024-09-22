using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class PasswordValidator
    {
        public int ValidatePassword(string password)
        {
            int score = 0;

            // Проверка на наличие цифр
            if (Regex.IsMatch(password, @"[012345678]"))
                score++;

            // Проверка на наличие строчных букв
            if (Regex.IsMatch(password, @"[a-z]"))
                score++;

            // Проверка на наличие заглавных букв
            if (Regex.IsMatch(password, @"[A-Z]"))
                score++;

            // Проверка на наличие спец. символов
            if (Regex.IsMatch(password, @"[\W_]"))
                score++;

            // Проверка на длину
            if (password.Length > 7)
                score++;

            return score;
        }
    }
}
