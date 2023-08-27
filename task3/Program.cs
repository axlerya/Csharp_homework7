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

double[] ArithmeticMean(int[,] arr)
{
    double[] outArray = new double[arr.GetLength(1)];
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        double sum = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            sum=+arr[rows, columns];
        }
        outArray[columns] = sum / arr.GetLength(0);
    }
    return outArray;
}

void PrintArithmeticMean(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Среднее арифметическое значение в столбце №" + (i+1) + " = " + arr[i]);
    }
}

PrintArithmeticMean(ArithmeticMean(matrix));