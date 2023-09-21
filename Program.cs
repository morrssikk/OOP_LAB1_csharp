using System.Numerics;

namespace Program
{
    public class OOP_LAB1
    {
        public static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double orig = 1 + x;
            double condition1 = orig + Math.Pow(Math.E, Math.Log(2 + 2 * x) + 2 * x);
            double condition2 = orig + 1 / Math.Tan((1 + x) / 9) + 8 * x;
            double condition3 = orig + 1 - 7 * x + Math.Pow(x, 2) - 2 * Math.Pow(x, 3);
            //скорочена форма
            if (x <= 4)
            {
                Console.WriteLine($"1 умова(скорочена форма): {condition1}");
            }
            if (4 < x && x <= 7)
            {
                Console.WriteLine($"2 умова(скорочена форма): {condition2}");
            }
            if (7 < x)
            {
                Console.WriteLine($"3 умова(скорочена форма): {condition3}");
            }
            // Повна форма  :(
            if (x <= 4)
                Console.WriteLine($"Перша умова (Повна форма): {condition1}");
            else
                if (7 < x)
                Console.WriteLine($"Третя умова (Повна форма): {condition3}");
            else
                Console.WriteLine($"Друга умова (Повна форма): {condition2}");
        }
    }
}

        