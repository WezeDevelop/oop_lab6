using System;

namespace Program{

    class Program
    {
        static void ValidateInput(double value, string name)
        {
            if (value <= 0)
                throw new ArgumentException($"{name} повинен бути більше нуля");
            if (value > 1000)
                throw new ArgumentException($"{name} занадто великий (максимум 1000)");
        }

        static void Main()
        {
            Console.WriteLine("Обчислення кутів прямокутного трикутника (генерація винятків)");
            
            try
            {
                Console.Write("Введіть катет A: ");
                double a = double.Parse(Console.ReadLine());
                ValidateInput(a, "Катет A");
                
                Console.Write("Введіть катет B: ");
                double b = double.Parse(Console.ReadLine());
                ValidateInput(b, "Катет B");

                var (angleA, angleB) = TriangleCalculator.CalculateAngles(a, b);
                
                Console.WriteLine($"Кут проти катета A: {angleA:F2}°");
                Console.WriteLine($"Кут проти катета B: {angleB:F2}°");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
                throw;  // Повторна генерація винятку
            }
        }
    }
}
