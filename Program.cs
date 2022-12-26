// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] => 2

int InputSize()
{
    Console.WriteLine("Input array size:   ");
    bool isParsed = int.TryParse(Console.ReadLine(), out int size);
    if (isParsed)
    {
        return size;
    }
    else
    {
        Console.WriteLine("Wrong numbers");
        return -1;
    }
}
int size = InputSize();
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("array: ");
PrintArray(numbers);
int count = evenNumbersArray();
int evenNumbersArray()
{
    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
        if (numbers[i] % 2 == 0)
            count++;
    return count;
}
Console.WriteLine($"In array {numbers.Length} numbers, {count} of them are even");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}



// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int size = InputSize();
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("array: ");
PrintArray(numbers);
int sum = sumNumbersArray();

Console.WriteLine($" {numbers.Length} numbers,sum of elements in odd positions = {sum}");

int InputSize()
{
    Console.WriteLine("Input array size:   ");
    bool isParsed = int.TryParse(Console.ReadLine(), out int size);
    if (isParsed)
    {
        return size;
    }
    else
    {
        Console.WriteLine("Wrong number");
        return -1;
    }
}
int sumNumbersArray()
{
int sum = 0;

for (int i = 0; i < numbers.Length; i+=2)
    sum = sum + numbers[i];
    return sum;
}
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}



// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// Не использовать готовые методы Min и Max [3 7 22 2 78] -> 76


int[] array = CreatRandomArray();
PrintArray(array);

array = arrSort(array);
PrintArray(array);

int result = array[4] - array[0];
Console.WriteLine($" the difference will be {result}");

int[] arrSort(int[] array)
{
    Array.Sort(array);
    if (array.Length > 0)
    {
        Console.WriteLine("Minimum number is " + array[0]);
        Console.WriteLine("Maximum number is " + array[array.Length - 1]);
    }
    return array;
}

int[] CreatRandomArray()
{
    Random random = new Random();

    int[] array = new int[5];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
}
