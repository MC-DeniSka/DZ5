// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3,21 7,04 22,93 -2,71 78,24] -> 80,95

double [] CreateMassive()
{
    System.Console.WriteLine("Введите длину массива");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length > 0)
    {
        double [] arr = new double[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = new Random().NextDouble() *100;
            arr[i] = Math.Round(arr[i],2);
        }
        return arr;
    }
    else
    {
        System.Console.WriteLine("Длина должна быть положительной!");
        double[] arr =  {-1};
        return arr;
    }
}

void PrintArr(double [] arr)
{
    System.Console.Write("{");
    System.Console.Write(String.Join(", ",arr));
    System.Console.Write("}");
    System.Console.WriteLine();
}

void FindDifMaxMin (double [] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length;i++ )
    {
       if(arr[i] < min)
        {
            min = arr[i];
        }
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }
    System.Console.WriteLine("Разница между максимальным и минимальным элементами массива =  " +String.Format("{0:F2}",(max - min)));
}

double [] arr = CreateMassive();
PrintArr(arr);
FindDifMaxMin(arr);