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

// создает финальный массив без пустых элементов
string[] CreateFinalArray(string[] array, int index)
{
    int count = 0;
    string[] finalArray = new string[index];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null) {
            finalArray[count] = array[i];
            count++;
        }
    }
    return finalArray;
}

// Выводит массив в консоль
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write('"' + array[i] + '"' + ", ");
    }
    Console.Write('"' + array[array.Length - 1] + '"' + "]");
}

string insertStringText = "Введите массив строк через запятую без пробелов = ";
string insertNumberText = "Введите количество символов в подстроке = ";

string[] stringArray = ReadDataString(insertStringText).Split(',');
int substringNumber = ReadDataNumber(insertNumberText);
var tuple = SortArrayMaxCountSymbols(stringArray, substringNumber).ToTuple();
string[] finalArray = CreateFinalArray(tuple.Item1, tuple.Item2);
PrintArray(finalArray);