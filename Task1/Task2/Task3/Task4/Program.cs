// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.
using System;
using System.Text;

class Program
{
    static void Main()
    {
        string originalString = "Hello World This Is A Test String";
        string reversedString = ReverseString(originalString);
        Console.WriteLine(reversedString);
    }

    static string ReverseString(string input)
    {
        // Разделяем строку на слова
        string[] words = input.Split(' ');

        // Переворачиваем список слов
        Array.Reverse(words);

        // Собираем новую строку, разделяя слова пробелами
        return string.Join(" ", words);
    }
}

