Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();

int[,] matrix = new int[m, n];

for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        matrix[rows, columns] = rand.Next(-100, 100);
    }
}

Console.WriteLine("введите номер строки");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количномерество столбца");
int numColumn = Convert.ToInt32(Console.ReadLine());

try
{
    Console.WriteLine("эмелент с позицией " + "row:" + numRow + " column:" + numColumn +  " = " + matrix[numRow, numColumn]); 
}
catch 
{
    Console.WriteLine("такой позиции нет"); 
}