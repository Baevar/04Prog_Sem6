// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

// “Hello my world” => “world my Hello”

string ReverseWordInStrin(string str)
{
    string[] arrayWord = str.Split(' ');
    string result = string.Empty;
    for (int i = arrayWord.Length - 1; i >= 0; i--)
    {
        if (i != 0)
        {
            result += arrayWord[i] + " ";
        }
        else
        {
            result += arrayWord[i];
        }
    }
    return result;
}

Console.WriteLine("Введите строку");

string str = Console.ReadLine();

string revesreWord = ReverseWordInStrin(str);

Console.WriteLine(revesreWord);
