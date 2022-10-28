// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int n = Promt("Введите кол-во строк");
int m = Promt("Введите кол-во столбцов");
double[,] array = CreateArray(n, m, -1000, 1000);
Console.WriteLine("Вот наш массив");
PrintArray(array);

int Promt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

double[,] CreateArray(int n, int m, int min, int max)
{
    double[,] a = new double[n, m];
    
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < m; col++)
        {
            a[row, col] = Convert.ToDouble(new Random().Next(min, max)/100.0);
        }         
        
    }
    return a;
}

void PrintArray(double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write(Math.Round(array[row, col], 2) + "  ");
        }
        Console.WriteLine();
    }
}