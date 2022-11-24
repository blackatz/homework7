// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int rows, int columns)
{
    var random = new Random();
    int[,] array = new int[rows, columns];

    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }

    return array;
}

void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {

            Console.Write(input[i, j]);
            if (j != input.GetLength(1) - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}

double Average(int[,] input)
{
    double average = 0;
    {
        for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            average = average + input[i, j]; 
        }
            average = average/input.GetLength(1);
            average = Math.Round(average, 2);
            Console.WriteLine("Среднее арифметическое строки " + (i+1) + " = " + average);
        }
    }
    return average;
}

Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
var array = CreateArray(m, n);

PrintArray(array);
Console.WriteLine();
Average(array);