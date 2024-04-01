// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.


bool IsStringPalindrome(string str)             // решение просто сравниваем строку саму с собой
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - i - 1])
            return false;
    }
    return true;

}

string ReverseString(string str)                // разворачиваем строку
{
    string result = string.Empty;
    for (int i = str.Length - 1; i >= 0; i--)
    {
    result += str[i];
    }
    return result;
}

bool IsSimilarTwoString(string str, string str2)         // решение сравниваем строку с ее реверсной копией
{
    for (int i = 0; i < str.Length -1; i++)
    {
        if (str[i] != str2[i])
            return false;
    }
    return true;

}


Console.WriteLine("Введите строку палиндром");

string str = Console.ReadLine();

string result = ReverseString (str);

Console.WriteLine("Метод сравнения строки и ее реверсной копии");

Console.WriteLine(IsSimilarTwoString(str, result) ? "Строка палиндром" : "Строка не палиндром");

Console.WriteLine("Метод сравнения строки самой с собой");

Console.WriteLine(IsStringPalindrome(str) ? "Строка палиндром" : "Строка не палиндром");