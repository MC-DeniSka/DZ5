// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] Massive()
{
    System.Console.WriteLine("Введите длину массива");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length > 0)
    {
        int [] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = new Random().Next(-99,99);
        }
        return arr;
    }
    else
    {
        System.Console.WriteLine("Длина должна быть положительной!");
        int[] arr =  {-1};
        return arr;
    }
}

void PrintArr(int [] arr)
{
    System.Console.Write("{");
    System.Console.Write(String.Join(", ",arr));
    System.Console.Write("}");
    System.Console.WriteLine();
}

void SumOfOdd(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
       sum = sum + arr[i]; 
    }
    System.Console.WriteLine("Cумма элементов с нечётными индексами = "+sum);
}

int [] arr = Massive();
PrintArr(arr);
SumOfOdd(arr);