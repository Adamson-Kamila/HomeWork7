// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] getArray()
{
  int[,] array = new int[5, 5];
  Random random = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = random.Next(1, 10);
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
  return array;
}

void getArithmeticMean(int[,] array)

{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    float sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
      sum += array[i, j];
    }
    sum = sum / array.GetLength(1);
    Console.WriteLine(sum);
  }

}

int[,] array = getArray();
Console.WriteLine();
getArithmeticMean(array);
