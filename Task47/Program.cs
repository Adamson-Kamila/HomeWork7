// Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.

double [,] getArray()
{
  double [,] array = new double [4,5];

  for( int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {

    }
  }
    return array;
}

double [,] getRealNumbersArray(double [,] array)
{
  Random random = new Random();
  
  for( int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] =Math.Round(random.Next(-1, 11)* 1.1, 1);      //random.Next( -10, 11)+ random.NextDouble();
      Console.Write(array[i, j] + "\t");
    
    }
    Console.WriteLine();
  }
   return array;
}

double [,] myArray = getArray();
double [,] doubleArray = getRealNumbersArray(myArray);