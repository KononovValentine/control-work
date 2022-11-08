// Запрашивает ввод строки
string ReadDataString(string msg)
{
    System.Console.Write(msg);
    string array = System.Console.ReadLine();
    return array;
}

// Запрашивает ввод номера
int ReadDataNumber(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine());
    return number;
}

// Создает из заданного массива новый массив с элементами
static (string[] array, int count) SortArrayMaxCountSymbols(string[] array, int substringNumber) {
    int count = 0;
    string[] sortedArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= substringNumber) 
        {
            sortedArray[count] = array[i];
            count++;
        }
    }
    return (sortedArray, count);
}
