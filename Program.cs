Console.WriteLine("Введите колличество элементов в массиве");

int a = int.Parse(Console.ReadLine()!);
Printarray(a);





void Printarray(int a){
int[] arr = new int[a];
for (int i = 0; i < a; ++i)
arr[i] = int.Parse(Console.ReadLine()!);
}
