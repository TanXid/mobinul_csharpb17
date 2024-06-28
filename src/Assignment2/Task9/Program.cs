using Task9;

var cart = new ShoppingCart(3);

cart.Items[0] = new CartItem { ItemId = 1, Price = 10.25, Quantity = 2 };
cart.Items[1] = new CartItem { ItemId = 2, Price = 20.75, Quantity = 1 };
cart.Items[2] = new CartItem { ItemId = 3, Price = 5.5, Quantity = 5 };

var total = cart.CalculateTotal();

Console.WriteLine($"Total price: {total}");