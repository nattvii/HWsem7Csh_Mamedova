// Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
Console.Write("Fill in a matrix size: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Fill in a number of the line");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Fill in a number of the column");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10, 10];
FillMatrixRandomNumbers(numbers);


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

string release(int[] array, int n, int m);
{
for (int i = 0; i < array.Length; i++)
{
        for (int j = 0; j < matrix.GetLength(1); j++) 
    {
         if (matrix[i] == n)
    } 
    {
        if (array[j] == m)
    }
}
}
    
    return $"The line's elemnt is {n}; The column's element is {m}; {numbers[n-1, m-1]}";
return "This elemnt does not exist";
    





