Console.Clear();

int[,] getArray()
{
  int[,] array = new int[5, 5];
  Random random = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = random.Next(1, 21);
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
  return array;
}



bool element(int[,] myArray, int num)
{
  for (int i = 0; i < myArray.GetLength(0); i++)
  {
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
      if (myArray[i, j] == num) return true;
    }
  }
  return false;
}


int[,] myArray = getArray();

Console.WriteLine("Ввведите число: ");
int num = int.Parse(Console.ReadLine()!);
bool trigger = element(myArray, num);
if (trigger) Console.WriteLine($"число {num} есть в массиве");
else Console.WriteLine($"числа {num} нет в массиве");
