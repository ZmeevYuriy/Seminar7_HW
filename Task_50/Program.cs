// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int n = Promt("Введите кол-во строк");
int m = Promt("Введите кол-во столбцов");
int[,] array = CreateArray(n, m, 1, 20);
Console.WriteLine("Вот наш массив");
PrintArray(array);


Console.WriteLine();
Console.WriteLine("Введите координаты а и b: ");

int a = Promt("Координата а: ");
int b = Promt("Координата b: ");
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
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col]} ");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] array)
{
        if (n >= a && m >= b)
        
            Console.WriteLine($"значение элемента {a} строки и {b} столбца равно: {array[a-1,b-1]}");
        
        else
        
            Console.WriteLine("такого элемента нет");     
}

