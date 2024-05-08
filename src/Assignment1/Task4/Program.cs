int num;
while (true)
{
    num = Convert.ToInt32(Console.ReadLine());

    if (num == 0)
        break;

    bool isPrime = true;
    if (num <= 1)
        isPrime = false;
    else
    {
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }

    if (isPrime)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}