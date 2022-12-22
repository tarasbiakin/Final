// написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами

string[] arrString = { "хороший", "плохой", "злой", "jq", "jq", "j1", "ji", "112", "kj1" };
string[] arrString = Console.ReadLine().Split(' ').Select(x => string.Parse(x)).ToArray();

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


void PrintArrau(string[] arr, string symb1, string symb2)
{

    Console.Write(symb1);

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");

        else
            Console.Write($"{arr[i]}");
    }
    Console.Write(symb2);

}
string[] ArrayStringEmptyRemuv(string[] array) // метод удаляет пустые значения из строкового массива используя динамичский массив
{
    // array = array.Except(new List<string> { string.Empty }).ToArray();// этот оставляет последнюю пустую строку 
    // return array;
    var temp = new List<string>();
    foreach (var s in array)
    {
        if (!string.IsNullOrEmpty(s))
            temp.Add(s);
    }
    array = temp.ToArray();
    return array;
}

string[] array = ArrayString(arrString);
string[] array1 = ArrayStringEmptyRemuv(array);
PrintArrau(array1, "[", "]");


// Вариант 2
// string[] ArrayStringLenth(string[] arrString)
// {
//     int count = 0;

//     for (int i = 0; i < arrString.Length; i++)
//     {
//         if (arrString[i].Length <= 3)
//         {
//             count++;

//         }


//     }
//     // Console.WriteLine(count);
//     string[] arrStringNew = new string[count];

//     int numPos = 0;
//     for (int k = 0; k < arrString.Length; k++)
//     {
//         if (arrString[k].Length <= 3)
//         {
//             arrStringNew[numPos] = arrString[k];
//             numPos++;

//         }

//     }
//     return arrStringNew;
// }
// string[] array = ArrayStringLenth(arrString);
// PrintArrau(array, "[", "]");
