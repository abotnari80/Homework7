System.Console.WriteLine("Введите количество строк и столбцов");
int n = Convert.ToInt32(Console.ReadLine()); 
int m = Convert.ToInt32(Console.ReadLine()); 
double[,] array = new double[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
      array[i,j] = Math.Round(new Random().Next(-10,10) + new Random().NextDouble(), 1);  
      System.Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
}