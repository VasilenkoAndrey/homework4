using System;
class Program
{
    static void Main()
    {
        while (true) 
        {
            Console.Write("Введите число или символ [q] для выхода из программы ");
            string input = Console.ReadLine();
            if (input == "q") 
            {
                break;
            }
            int number;
            if (int.TryParse(input, out number)) 
            {
                int sum = 0;
                while (number > 0)  
                {
                    sum += number % 10; 
                    number /= 10;
                }
                if (sum % 2 == 0) 
                {
                    Console.WriteLine("СУММА ЧЕТНАЯ");
                    break;
                }
            }
            else
            {
                Console.WriteLine("ОШИБКА: введите 'q' или число .");
            }
        }
    }
}