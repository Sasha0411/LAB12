
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12
{
    internal class Program
    {
        static double DegToRad(double degrees)
        {
            const double pi = 3.14; // Константа π
            return degrees * pi / 180; // Перетворення з градусів в радіани
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Горкун Олександр");
                Console.Write("Введіть величину кута в градусах (або 0 для виходу): ");
                double degrees = double.Parse(Console.ReadLine());

                if (degrees == 0)
                {
                    break; // Вихід з циклу, якщо введено 0
                }

                double radians = DegToRad(degrees);
                Console.WriteLine($"{degrees} градусів дорівнює {radians:F2} радіанам."); // Вивід результату
            }

            Console.WriteLine("Програму завершено.");
        }
    }
}
