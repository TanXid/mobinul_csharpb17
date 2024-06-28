using Task3;

string connectionString = "Server=8088; Database=C#B-17; Uid=Tanjid019; Pwd=123456";
DatabaseConnection dbConnection = new DatabaseConnection(connectionString);


string retrievedConnectionString = dbConnection.ConnectionString;
Console.WriteLine($"Connection string:\n{retrievedConnectionString}");