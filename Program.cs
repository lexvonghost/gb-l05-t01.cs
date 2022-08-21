//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите число, определяющее длинну массива");
int length =  Convert.ToInt32(Console.ReadLine());
int[] NewArray(int[] array)
{
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}
int[] array = new int[length];
array = NewArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");

int Count = 0;
for (int i = 0; i < length; i++)
if (i < length)
{
     if (i % 2 ==0)
        Count ++; 
}
    else
        Console.WriteLine("Чётные числа не найдены");  
Console.WriteLine("Kоличество чётных чисел в массиве:" + Count);