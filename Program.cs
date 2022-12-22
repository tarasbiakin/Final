// написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами

 string[] arrString = { "хороший", "плохой", "злой", "jq", "jq", "j1", "ji", "112", "kj1" };
//string[] arrString = Console.ReadLine().Split(' ').Select(x => string.Parse(x)).ToArray();

string[] ArrayStringLenth(string[] arrString)
{
    int count = 0;
    string[] arrStringNew = new string[arrString.Length];
    for (int i = 0; i < arrString.Length; i++)
    {
        if (arrString[i].Length <= 3)
        {
            arrStringNew[count] = arrString[i];
            count++;
            // Console.WriteLine(count);
        }

    }
    return arrStringNew;

}
