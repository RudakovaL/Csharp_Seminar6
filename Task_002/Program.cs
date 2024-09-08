//  Задайте строку, содержащую латинские буквы 
// в обоих регистрах. Сформируйте строку, в которой все 
// заглавные буквы заменены на строчные.

using System;

class Program
{
    static void Main()
    {
        // Шаг 1: Задаем строку
        string inputString = "Hello World! This Is A Test String.";

        // Шаг 2: Преобразуем строку в нижний регистр
        string lowerCaseString = inputString.ToLower();

        // Шаг 3: Выводим результат
        Console.WriteLine("Исходная строка: " + inputString);
        Console.WriteLine("Строка в нижнем регистре: " + lowerCaseString);
    }
}
