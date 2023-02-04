/*                    Задайте массив заполненный случайными положительными трёхзначными числами. 
                      Показать количество чётных чисел в массиве. */
/*
int size = 25;
int[] TakeArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next( 100, 999);
    }
    return array;
}

void PrintResult(int[] array)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
        else uneven++;
    }
    Console.Write($"-> {even}");
}
PrintResult(TakeArray(size));
*/

/*                                 Задайте одномерный массив, заполненный случайными числами.
                                   Найдите сумму элементов, стоящих на нечётных позициях.  */

/*
int size = 25;
int[] TakeArray(int size)
{
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().Next(1,1000);
        Console.Write(array[i] + " ");
    }
    return array;
}
void PrintSumArr(int[] arr)
{
    int sum=0;
    for (int i=0; i<size; i++)
    {
        if (i%2>0) sum+= arr[i];
    }
    Console.Write($"->{sum}");
}
PrintSumArr(TakeArray(size));
*/

//                    Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
int size = new Random().Next(1, 10);
Console.WriteLine($"Массив: {size}");
double[] TakeArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}
void PrintDifference(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();
    Console.WriteLine($"Разница между {arr.Max()} и {arr.Min()} = {difference}");
}
PrintDifference(TakeArray(size));
*/
