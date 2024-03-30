// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.


bool IsStringPalindrome(string str)
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - i - 1])
            return false;
    }
    return true;

}

Console.WriteLine("Введите строку палиндром");
string str = Console.ReadLine();

Console.WriteLine(IsStringPalindrome(str) ? "Строка палиндром" : "Строка не палиндром");