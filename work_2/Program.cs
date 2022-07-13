using System;
class Programm
{
    static void Main(string[] args)
    {
        double firstValue, secondValue, thirdValue;

        Console.WriteLine("Введите 1 число");
        firstValue = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите 2 число");
        secondValue = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите 3 число");
        thirdValue = double.Parse(Console.ReadLine());

        double sumResult = firstValue + secondValue + thirdValue;
        Console.WriteLine(sumResult);
        double multResult = firstValue * secondValue * thirdValue;
        Console.WriteLine(multResult);

    }
}