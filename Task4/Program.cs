// Задача 3: Задайте произвольную строку. Выясните,
// является      ли      она      палиндромом.

// 15:15
// “aBcD1ef!-” => Нет
// “шалаш” => Да “55655” => Да

bool IsStringPalindrome(string str)
{
    
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - i - 1])
        {
            return false;
        }

    }
    return true;
}

Console.WriteLine("Введите строку");

string userInput = Console.ReadLine();

bool palindrome = IsStringPalindrome(userInput);

Console.WriteLine(palindrome ? "Строка палиндром" : "Строка не палиндром");