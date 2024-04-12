//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.WriteLine("Введите массив:");
string[] inputArray = Console.ReadLine().Split(',');

int count = 0;
foreach (string str in inputArray)
{
    if (str.Length <= 3)
    {
        count++;
    }
}

string[] resultArray = new string[count];
int index = 0;
foreach (string str in inputArray)
{
    if (str.Length <= 3)
    {
        resultArray[index++] = str;
    }
}
void PrintStringArray(string[] resultArray)
{
    Console.WriteLine("Отфильтрованный массив: ");
    foreach (string str in resultArray)
    {
        Console.Write($"{str} ");
    }
    Console.WriteLine();
}
PrintStringArray(resultArray);

