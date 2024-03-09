using System;

public class Calc
{
    public static void Main()
    {
        ConsoleKeyInfo btn;

        Console.WriteLine("Здравствуйте! Это программа для расчета площади кругового сектора");
        Console.WriteLine("Пожалуйста, следуйте предложенной инструкции!");
        Console.WriteLine("Для выхода из программы после расчетов нажмите клавишу Esc.");
        Console.WriteLine("Для продолжения расчетов нажмите клавишу Enter для появления инструкции.");

        do
        {
            Console.WriteLine("Введите радиус кругового сектора");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите центральный угол кругового сектора");
            double alfa = Convert.ToDouble(Console.ReadLine());

            double result;

            try
            {
                result = Lab3.Lib.Circular_Sector.Calc(r, alfa);
                Console.WriteLine("Площадь кругового сектора:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            btn = Console.ReadKey();
        }
        while (!(btn.Key == ConsoleKey.Escape));
    }
}
