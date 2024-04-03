// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
using System;

class Program
{
    static void Main()
    {
        string input = "aBcDeFgHijKlmNoPqRstUvWxyZA";
        string output = input.ToLower();
        
        Console.WriteLine(output);
    }
}

