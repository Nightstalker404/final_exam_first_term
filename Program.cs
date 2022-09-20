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


string[] NewArr(string[] arr)
{
    string[] new_arr  = new string[arr.Length];
    for (int i = 0; i < new_arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            new_arr[i] = arr[i];
    }
    new_arr = new_arr.Where(x => x != null).ToArray();
    return new_arr;
}