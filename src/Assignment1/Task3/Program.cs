string input = Console.ReadLine();

string[] numberStrings = input.Split(',');

double largest = double.MinValue;
double secondLargest = double.MinValue;

foreach (var numberString in numberStrings)
{
    double number = Convert.ToDouble(numberString.Trim());
    if (number > largest)
    {
        secondLargest = largest;
        largest = number;
    }
    else if (number > secondLargest && number != largest)
    {
        secondLargest = number;
    }
}

Console.WriteLine(secondLargest);
