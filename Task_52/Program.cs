// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int n = Promt("Введите кол-во строк");
int m = Promt("Введите кол-во столбцов");
int[,] array = CreateArray(n, m, 1, 20);
Console.WriteLine("Вот наш массив");
PrintArray(array);
FillArray(array);


int Promt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}


int[,] CreateArray(int n, int m, int min, int max)
{
    int[,] a = new int[n, m];
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < m; col++)
        {
            a[row, col] = new Random().Next(min, max+1);
        }
    }
    return a;
}


void PrintArray(int[,] array)
{
    double avarage = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col]}  "); 
        }
        Console.WriteLine(); 
    }
}

void FillArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avarage = (avarage + array[i, j]);
        }
        avarage = avarage / n;
        Console.Write(Math.Round(avarage, 2) + ";  ");
    }
    Console.WriteLine();
}
