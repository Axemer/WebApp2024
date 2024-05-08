using Humanizer;

namespace WebAppL.Models
{
    public class BDayModel
    {
        public static string CheckDates(DateTime FirstPerson, DateTime SecondPerson)
        {
            var diff = (SecondPerson - FirstPerson).TotalDays;

            if  (diff > 0)
            {
                return $"Первый старше второго на {diff} дней.";
            }
            else if (diff < 0)
            {
                return $"Второй  старше первого на {-diff} дней.";
            }
            else
            {
                return $"Оба человека родились в одинаковую дату.";
            }
        }
    }
}