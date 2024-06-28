using Task7;

string username = "Mobinul.Ahasan";
string email = "";
string password = "123456";

string validationMessage = Membership.Validate(username, email, password);

if (!string.IsNullOrEmpty(validationMessage))
{
    Console.WriteLine("Validation failed: " + validationMessage);
}
else
{
    Console.WriteLine("Validation succeeded");
}