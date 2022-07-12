//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] numbers = new int[4];

void NewRandomArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void PrintArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int ArrayPositiveNumbers(int[] array){
    int n1 = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      n1++;
    }
  }
  return n1;
}

NewRandomArray(numbers, 100, 1000);
PrintArray(numbers);
Console.WriteLine();

int n1 = ArrayPositiveNumbers(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {n1}");


//Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Write("Введиnt количество элементов массива: ");
int inpNumbers = Convert.ToInt32(Console.ReadLine());


int RandomArray(int inpNumbers, int min, int max)
{
    int[] randArray = new int[inpNumbers];
    int sumElements = 0;
    for(int i = 0; i < randArray.Length; i++)
    {
        randArray[i] = new Random().Next(min, max);

        Console.Write(randArray[i] + " ");
    if (i % 2 != 1)
      {
        sumElements = sumElements + randArray[i];
      }
    }
    return sumElements;
}

int randArray =  RandomArray(inpNumbers, 1, 10);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randArray}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] NewArray = new double[10];
for (int i = 0; i < NewArray.Length; i++ )
  {
    NewArray[i] = new Random().Next(1, 10);
    Console.Write(NewArray[i] + " ");
  }

double max = NewArray[0];
double min = NewArray[0];

for (int i = 1; i < NewArray.Length; i++)
  {
    if (max < NewArray[i])
    {
      max = NewArray[i];
    }
        if (min > NewArray[i])
    {
      min = NewArray[i];
    }
  }

  double result = max - min;

  Console.WriteLine($"\nразница между между максимальным ({max}) и минимальным({min}) элементами: {result}");
  */