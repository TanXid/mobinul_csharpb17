using Task2;

Lock myLock = new Lock();

myLock.LockStatus = "Open";
Console.WriteLine($"Lock status: {myLock.LockStatus}");

myLock.LockStatus = "Close";
Console.WriteLine($"Lock status: {myLock.LockStatus}");

string newStatus = "Locked";
if (newStatus == "Open" || newStatus == "Close")
{
    myLock.LockStatus = newStatus;
    Console.WriteLine($"Lock status: {myLock.LockStatus}");
}
else
{
    Console.WriteLine($"Error: Invalid lock status '{newStatus}'. LockStatus must be either 'Open' or 'Close'");
}