string[] inputs = Console.ReadLine().Split(',');

double[] numbers = new double[inputs.Length];
for (int i = 0; i < inputs.Length; i++)
{
    numbers[i] = Convert.ToDouble(inputs[i].Trim());
}

for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int j = 0; j < numbers.Length - i - 1; j++)
    {
        if (numbers[j] < numbers[j + 1])
        {
            double temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i]);
    if (i < numbers.Length - 1)
    {
        Console.Write(", ");
    }
}