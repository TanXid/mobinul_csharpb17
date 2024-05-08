using System.Drawing;

Console.Write(" Enter the size of a 2D square array(must be odd): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[100, 100];

if (n % 2 == 0)
{
    Console.WriteLine(" Size must be an odd number. ");
    return;
}

Console.WriteLine(" Enter the values for the array: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($" Value of [{i},{j}]: ");
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine(" The 2D array is: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

int firstDiagonalSum = 0;
for (int i = 0; i < n; i++)
{
    firstDiagonalSum += array[i, i];
}

int secondDiagonalSum = 0;
for (int i = 0; i < n; i++)
{
    secondDiagonalSum += array[i, n - 1 - i];
}

Console.WriteLine($" 1st Diagonal Sum: {firstDiagonalSum}");
Console.WriteLine($" 2st Diagonal Sum: {secondDiagonalSum}");