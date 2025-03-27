using Database;

Console.WriteLine("Welcome to employee admin!");

Console.WriteLine("Add employee");

Console.Write("Name: ");
string name  = Console.ReadLine();

string imageFilePath;
while (true)
{
    Console.Write("Image (path to file): ");
    imageFilePath = Console.ReadLine();

    if (File.Exists(imageFilePath))
    {
        break;
    }
    else
    {
        Console.WriteLine("File not found. Please enter a valid file path.");
    }
};

Console.Write("Details: ");
string details  = Console.ReadLine();

byte[] imageData = File.ReadAllBytes(imageFilePath);

Employee newEmployee = new Employee()
{
    Name = name,
    ImageData = imageData,
    Details = details
};

Database.Database db = new Database.Database();

await db.SaveEmployee(newEmployee);

var employees = await db.GetAllEmployees();

foreach (var employee in employees)
{
    Console.WriteLine($"Name: {employee.Name} Image size: {employee.ImageData.Length} bytes");
}