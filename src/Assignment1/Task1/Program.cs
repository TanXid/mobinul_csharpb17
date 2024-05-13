int size = Convert.ToInt32(Console.ReadLine()); 

double[,] squareArray = new double[size, size];

for (int i = 0; i < size; i++)
{
    string[] inputValues = Console.ReadLine().Split(' ');
    for (int j = 0; j < size; j++)
    {
        squareArray[i, j] = Convert.ToDouble(inputValues[j]);
    }
}

double firstDiagonalSum = 0;
double secondDiagonalSum = 0;

for (int i = 0; i < size; i++)
{
    firstDiagonalSum += squareArray[i, i];
    secondDiagonalSum += squareArray[i, size - i - 1];
}

Console.WriteLine();
Console.WriteLine($"1st Diagonal Sum: {firstDiagonalSum}");
Console.WriteLine($"2nd Diagonal Sum: {secondDiagonalSum}");
