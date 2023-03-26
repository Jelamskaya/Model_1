// Запишите массив вещественных чисел. Найдите разницу между максимальным
//и минимальным элементом массива.
//[ 3 7 22 2 78]->76

double [] array = newdouble [8];
for (int i=0; i< array.Length; i++)
  array[i] = Math.Round(newRandom().nextDouble()*(50-10)+ 10);
double max1 = array[0];
double min1 = array[0];
for (int i=0; i< array.Length; i++)
{
if (array[i]>max1)
  max1 = array[i];
if (array[i]>min1)
  min1 = array[i];
}
Console.WriteLine(max1-min1);
Console.WriteLine($"[{string.Join(",", array)}]");



//Задайте одномерный массив, заполненный случайными числами. Найдите 
//сумму элементов, стоящих на нечетных позициях.
//[3, 7, 23, 12]->19
//[-4, -6, 8, 9, 6]->0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

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


//Задайте массив заполненный случайными положительными трехзначными
//числами. напишите программу, которая покажет количество четных 
//чисел в массиве.
//[ 345, 897, 568, 234]->2

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
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