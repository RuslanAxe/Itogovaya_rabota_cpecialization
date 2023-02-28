void PrintArray(string[] array)
{
    for (int i = 0; i< array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine("\n");
}
void SelectionArray(string[] array1, string[] array2)
{
    int num = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[num] = array1[i];
            num++;
        }
    }
}
string[] array1 = new string[5] { "array", "arr", "123", "12345", "proekt" };
string[] array2 = new string[array1.Length];
Console.WriteLine("Вам представлен заданный массив состоящий из 5 элементов");
PrintArray(array1);
Console.WriteLine("\nПосле выполнения данной программы во втором массиве останутся только элементы длина которых равна 3 символа или меньше");
SelectionArray(array1, array2);
PrintArray(array2);

