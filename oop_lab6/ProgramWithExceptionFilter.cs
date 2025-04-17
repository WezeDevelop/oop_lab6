using System;

namespace Program{
    using System;

class ProgramWithExceptionFilter
{
    static void Main()
    {
        Console.WriteLine("Обчислення кутів прямокутного трикутника (фільтри винятків)");
        
        try
        {
            Console.Write("Введіть катет A: ");
            string inputA = Console.ReadLine();
            
            Console.Write("Введіть катет B: ");
            string inputB = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputA) || string.IsNullOrWhiteSpace(inputB))
                throw new ArgumentException("Введені дані не можуть бути порожніми");

            double a = double.Parse(inputA);
            double b = double.Parse(inputB);

            var (angleA, angleB) = TriangleCalculator.CalculateAngles(a, b);
            
            Console.WriteLine($"Кут проти катета A: {angleA:F2}°");
            Console.WriteLine($"Кут проти катета B: {angleB:F2}°");
        }
        catch (Exception ex) when (ex is FormatException || ex is OverflowException)
        {
            Console.WriteLine("Помилка вводу: некоректний формат числа");
        }
        catch (Exception ex) when (ex.Message.Contains("Введені дані"))
        {
            Console.WriteLine(ex.Message);
        }
    }
}
}
