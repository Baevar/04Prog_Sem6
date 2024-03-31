// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int CountNemberVowels(string str)
{
    int countVowel = 0;

    string vowels = "aouyei";

    str = str.ToLower();
    
    for (int i = 0; i < str.Length; i++)
    {
         for (int j = 0; j < vowels.Length; j++)
    {
        if(str[i] == vowels[j])
        countVowel++;
    }
    }
    return countVowel;    
}

Console.WriteLine("Введите строку в нижнем регистре");

string inputString = Console.ReadLine();

int countVowels = CountNemberVowels(inputString);

Console.WriteLine(countVowels);

