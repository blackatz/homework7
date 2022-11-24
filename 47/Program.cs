// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(int rows, int columns)
{
    var random = new Random();

    double[,] array = new double[rows, columns];

    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = 20.0*random.Next(-100, 101)/100.0;
        }
    }

    return array;
}

void PrintArray(double[,] input)
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

Console.WriteLine("Введите размерность массива");
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine()!);

var array = CreateArray(m, n);
PrintArray(array);


// void Main()
// { Int32 k, l, m, n;
// Console.Write("m n: ");
// var s = Console.ReadLine().Split(" ");
// m = Convert.ToInt32(s[0]);
// n = Convert.ToInt32(s[1]);
// Random rnd = new Random();
// double [,] A = new double [m,n];
// for (k = 0; k < m; k++)
// { for (l = 0; l < n; l++)
// { A[k,l]=20.0*rnd.Next()/2147483648-10.0;
// Console.Write(String.Format("{0,5:f1}",
// A[k,l])); } Console.WriteLine(); } } } }