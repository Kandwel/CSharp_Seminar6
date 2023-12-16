//Задача 1: 
//Задайте двумерный массив символов (тип char[,]). 
//Создать строку из символов этого массива. 

Console.WriteLine("Программа показывает весь массив в одной строке");

char[,] charArray = new char[,] { { 'H', 'W' }, { 'G', 'B' } };

string result = CreateStringFrom(charArray);
Console.WriteLine(result);

static string CreateStringFrom(char[,] array)
{
    string result = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
    }
    return result;
}
