int[,] array = new int[3,4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i,j] = new Random().Next(0,10);
        System.Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
}
System.Console.Write("Среднее арифметическое ");
double sa;
double sum = 0;
for (int i = 0; i < 3; i++)
{
    sum = array[i,0] + sum;
}
sa = sum/3;
System.Console.Write($"{Math.Round(sa,2)} ");
sum = 0;
for (int i = 0; i < 3; i++)
{
    sum = array[i,1] + sum;
}
sa = sum/3;
System.Console.Write($"{Math.Round(sa,2)} ");
sum = 0;
for (int i = 0; i < 3; i++)
{
    sum = array[i,2] + sum;
}
sa = sum/3;
System.Console.Write($"{Math.Round(sa,2)} ");
sum = 0;
for (int i = 0; i < 3; i++)
{
    sum = array[i,3] + sum;
}
sa = sum/3;
System.Console.Write($"{Math.Round(sa,2)} ");