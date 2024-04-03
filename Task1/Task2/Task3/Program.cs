// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом
using System;

class Program
{
    static void Main()
    {
        string input = "Андрей";
        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine($"Строка '{input}' является палиндромом: {isPalindrome}");
    }

    static bool IsPalindrome(string str)
    {
        if (str.Length % 2 != 0) return false; // Проверка на четность длины строки

        for (int i = 0; i < str.Length / 2; i++)
        {
            // Проверка на равенство символов без учета регистра
            if (char.ToLower(str[i]) != char.ToLower(str[str.Length - 1 - i]))
            {
                return false;
            }
        }

        return true;
    }
}

