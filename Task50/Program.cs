// Напишите программу, которая на вход принимает позиции эелемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.
 

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


void element(int[,] myArray)
{

  Console.WriteLine("Ввведите номер строки: ");
  int row = int.Parse(Console.ReadLine()!);
  if (row >= myArray.GetLength(0)) Console.WriteLine($"{row} такой строки нет");
  else 
  {
    Console.WriteLine("Введите номер колонки: ");
    int column = int.Parse(Console.ReadLine()!);
    if (column >= myArray.GetLength(1)) Console.WriteLine($"{column} такой колонки нет");
    else Console.WriteLine(myArray[row-1, column-1]);
  }

}

int[,] myArray = getArray();
element(myArray);


