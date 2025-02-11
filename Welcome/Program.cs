using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imię:");
            var name = Console.ReadLine();

            Console.WriteLine("Podaj rok urodzenia:");
            var yearOfBirth = GetYear();

            Console.WriteLine("Podaj miesiąc urodzenia:");
            var monthOfBirth = GetMonth();

            Console.WriteLine("Podaj dzień urodzenia:");
            var dayOfBirth = GetDayOfMonth(yearOfBirth, monthOfBirth);

            Console.WriteLine("Podaj miejsce urodzenia:");
            var placeOfBirth = Console.ReadLine();

            var dateOfBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);

            int age = DateTime.Now.Year - dateOfBirth.Year;

            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age--;

            Console.WriteLine($"Cześć {name} urodziłeś się w {placeOfBirth} i masz {age} lat.");
        }


        private static int GetDayOfMonth(int yearOfBirth, int monthOfBirth)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int day) || day > DateTime.DaysInMonth(yearOfBirth, monthOfBirth) || day < 1)
                {
                    Console.WriteLine("Podano nieprawidłowe dane. Spróbuj ponownie.");
                    continue;
                }
                return day;
            }
        }

        private static int GetYear()
        {
            while(true)
            {
                if (!int.TryParse(Console.ReadLine(), out int year) || DateTime.Now.Year < year)
                {
                    Console.WriteLine("Podano nieprawidłowe dane. Spróbuj ponownie.");
                    continue;
                }
                return year;
            }
        }  
        
        private static int GetMonth()
        {
            while(true)
            {
                if (!int.TryParse(Console.ReadLine(), out int month) || month > 12 || month < 1)
                {
                    Console.WriteLine("Podano nieprawidłowe dane. Spróbuj ponownie.");
                    continue;
                }
                return month;
            }
        }
    }
}
