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
