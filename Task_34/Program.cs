// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] Massive()
{
    System.Console.WriteLine("Введите длину массива");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length > 0)
    {
        int [] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = new Random().Next(100,999);
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

void CountEvenNumbers(int [] mass)
{
    int count = 0;
    if(mass[0] > 0)
    {
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 != 1)
        {
            count++;
        }
    }
    System.Console.WriteLine("Количесво четных чисел в массиве = " +count);
    }
}

int [] arr = Massive();
PrintArr(arr);
CountEvenNumbers(arr);