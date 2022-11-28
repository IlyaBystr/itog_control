
Console.WriteLine("Введите колличество элементов в массиве");
int a = int.Parse(Console.ReadLine()!);
string[] arr = new string[a];
CreatArray(a, arr);
Printarray(arr);

Console.WriteLine("Введите колличество символов в новом массиве");
int b = int.Parse(Console.ReadLine()!);
string[] Arry = new string[5];
CreatNewArray(b, Arry);

void CreatArray(int a, string[] arr)
{
    for (int i = 0; i < a; ++i)
    {
        arr[i] = Console.ReadLine()!;
        Console.WriteLine($"Вы ввели {i + 1} элемент массиыв");
    }

}

void Resize(ref string[] Arry, int NewSize)
{
    string[] newArray = new string[NewSize];
    for (int i = 0; i < Arry.Length && i < newArray.Length; i++)
    {
        newArray[i] = Arry[i];
    }
    Arry = newArray;
}

void CreatNewArray(int b, string[] Arry)
{
    int l = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= b)
        {
            Arry[l] = arr[i];
            l++;
        }
        Resize(ref Arry, l + 1);

    }
    Printarray(Arry);
}

void Printarray(string[] Arry)
{

    Console.Write("[ ");
    for (int j = 0; j < Arry.Length; j++)
    {
        Console.Write(Arry[j] + " ");
    }
    Console.WriteLine("]");
}