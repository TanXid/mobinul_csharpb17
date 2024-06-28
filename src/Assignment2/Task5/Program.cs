using Task5;

IShape circle = new Circle(5);
IShape square = new Square(4);

Console.WriteLine($"The area of the circle is: {circle.CalculateArea()}");
Console.WriteLine($"The area of the square is: {square.CalculateArea()}");