//Задача 2: 
//Задайте строку, содержащую латинские буквы
//в обоих регистрах. Сформируйте строку, в которой 
//все заглавные буквы заменены на строчные.

Console.WriteLine("Программа превращает всё в строчные буквы");
main();

void main()
{
    string input = "HoMeWorK gEEkbRaIns!-";

    string result = input.ToLower();

    Console.WriteLine(input + " => " + result);
}
