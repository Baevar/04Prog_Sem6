// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 


char[] StringToCharsArray(string inputString)
{
    char[] resultArray = new char[inputString.Length];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = inputString[i];
    }
    return resultArray;
}

void PrintCharsArray(char[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"'{array[i]}', ");
        }
        else
            Console.Write($"'{array[i]}'");
    }
    Console.Write("]");
}

string str = "Hello!";

char[] resultArray = StringToCharsArray(str);

PrintCharsArray(resultArray);