// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine();
Console.Write("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5, 5];
InitMatrix(numbers);

void InitMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(10, 100);
            }   
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}

Console.WriteLine();

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента - {numbers[n-1,m-1]}");
}

Console.WriteLine();
PrintMatrix(numbers);
Console.WriteLine();