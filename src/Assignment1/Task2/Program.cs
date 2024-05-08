Console.WriteLine(" Enter how many number you want to input.");
int n = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[n];

Console.WriteLine(" Enter the numbers: ");
for (int i = 0; i < n; i++)
{
    numbers[i] = Convert.ToDouble(Console.ReadLine());
}

for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - 1 - i; j++)
    {
        if (numbers[j] < numbers[j + 1])
        {
            double temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}

Console.WriteLine("Sorted numbers in descending order:");
foreach (double number in numbers)
{
    Console.WriteLine(number);
}