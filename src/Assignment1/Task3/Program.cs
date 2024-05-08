Console.WriteLine("Enter numbers separated by , : ");
string s = Console.ReadLine();

string[] numberString = s.Split(',');

double[] numbers = new double[numberString.Length];
for (int i = 0; i < numberString.Length; i++)
{
    numbers[i] = Convert.ToDouble(numberString[i]);
}

double largest = double.MinValue;
double secondLargest = double.MinValue;

foreach (double num in numbers)
{
    if (num > largest)
    {
        secondLargest = largest;
        largest = num;
    }
    else if (num > secondLargest && num != largest)
    {
        secondLargest = num;
    }
}

Console.WriteLine(secondLargest);
    