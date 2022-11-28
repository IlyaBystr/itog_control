
Console.WriteLine("Введите колличество элементов в массиве");
int a = int.Parse(Console.ReadLine()!);
string[] arr = new string[a];
CreatArray(a, arr);

Console.WriteLine("Введите колличество символов в новом массиве");
int b = int.Parse(Console.ReadLine()!);
string[] Arry = new string[10];
CreatNewArray(b, Arry);

void CreatArray(int a, string[] arr)
{
    for (int i = 0; i < a; ++i)
    {
        arr[i] = Console.ReadLine()!;
        Console.WriteLine($"Вы ввели {i + 1} элемент массиыв");
    }
    Console.Write("[ ");
    for (int b = 0; b < arr.Length; b++)
    {
        Console.Write(arr[b] + " ");
    }
    Console.WriteLine("]");


}

void CreatNewArray(int b, string[] Array)
{
    int l = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= b)
        {
            Array[l] = arr[i];
            l++;
        }
    }
    Console.Write("[ ");
    for (int j = 0; j < Array.Length; j++)
    {
        Console.Write(Array[j] + " ");
    }
    Console.WriteLine("]");
}