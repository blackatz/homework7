// Задача 50. Напишите программу, которая на вход принимает значение 
// элемента в двумерном массиве, и возвращает позицию этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

bool Find(int[,] input)
{
    Console.WriteLine("Введите поисковое значение");
    int find = int.Parse(Console.ReadLine()!);
    bool finding = false;
    {
        for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            if (input[i,j] == find)
            {
            finding = true;
            Console.WriteLine("Элемент находится на позиции " + i + ", " + j);}
        }

    }
    }    
        if (finding == false)
        {
            Console.WriteLine("Элемент не найден");
        }    
    return finding;
}

Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);
var array = CreateArray(m, n);

PrintArray(array);
Console.WriteLine();

Find(array);
