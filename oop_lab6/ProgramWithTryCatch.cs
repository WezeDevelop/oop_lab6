using System;

namespace Program{

    class ProgramWithTryCatch
    {
        static void Main()
        {
            Console.WriteLine("Обчислення кутів прямокутного трикутника (try-catch-finally)");
            
            try
            {
                Console.Write("Введіть катет A: ");
                double a = double.Parse(Console.ReadLine());
                
                Console.Write("Введіть катет B: ");
                double b = double.Parse(Console.ReadLine());

                var (angleA, angleB) = TriangleCalculator.CalculateAngles(a, b);
                
                Console.WriteLine($"Кут проти катета A: {angleA:F2}°");
                Console.WriteLine($"Кут проти катета B: {angleB:F2}°");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: Введено некоректне число");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Робота програми завершена");
            }
        }
    }
}
