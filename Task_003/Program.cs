//Задача 3:
//Задайте произвольную строку. 
//Выясните, является ли она палиндромом.


Console.WriteLine("Программа проверяет, является ли введённое значение палидромом");
System.Console.WriteLine();

System.Console.WriteLine("Введите символы");
string input = Console.ReadLine();
bool isPalindrome = IsPalindrome(input);
Console.WriteLine(isPalindrome ? $"Ваши символы '{input}' палидром" : $"Ваши символы '{input}' не палидром");

bool IsPalindrome(string str)
{
    string normalized = new
    string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    return normalized.SequenceEqual(normalized.Reverse());
}