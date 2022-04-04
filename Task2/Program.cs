int[,] mass = new int[3,4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        mass[i,j] = new Random().Next(0,10);
        System.Console.Write(mass[i,j] + " ");
    }
    System.Console.WriteLine();
}
int index1 = Convert.ToInt32(Console.ReadLine());
int index2 = Convert.ToInt32(Console.ReadLine());
if (index1<3 && index1>=0 && index2<4 && index2>=0)
    System.Console.WriteLine(mass[index1,index2]);
else System.Console.WriteLine("Такого элемента нет");