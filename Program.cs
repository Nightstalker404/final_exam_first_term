string[] StringArr(int num)
{
    string[] arr_string  = new string[num];
    for (int i = 0; i < arr_string.Length; i++)
    {
        Console.WriteLine("Введите строку:");
        arr_string[i] = Console.ReadLine();
    }
    return arr_string;
}


