// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

// “Hello my world” => “world my Hello”

string ReverseWordInStrin(string str)
{
    string[] arrayWord = str.Split(' ');
    string akk = " ";
    for (int i = 0; i < arrayWord.Length / 2; i++)
    {
        akk = arrayWord[i];
        arrayWord[i] = arrayWord[arrayWord.Length - i - 1];
        arrayWord[arrayWord.Length - i - 1] = akk;
    }
    string result = string.Join(" ", arrayWord);
    return result;
}

Console.WriteLine("Введите строку");

string str = Console.ReadLine();

string revesreWord = ReverseWordInStrin(str);
Console.WriteLine(revesreWord);

// string hello = "Hello my world";
// string res = string.Empty;
// string[] helloSplit = hello.Split();//["Hello", "my", "world"]

// for (int i = helloSplit.Length - 1; i >= 0; i--)
// {
//     res += helloSplit[i] + " ";
// }

// Console.WriteLine(res.TrimEnd());