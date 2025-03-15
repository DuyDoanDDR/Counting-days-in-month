int month;
Console.WriteLine("Enter Counted Month: ");
while (true)
    if (int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12)
    {
        break;
    }
    else
    {
        Console.WriteLine("\nEnter month as an integer (>=1 and <=12) !\nEnter Counted Month :");
    }
switch (month)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("The month has 31 days");
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("The month has 30 days");
        break;
        
    case 2:
        Console.WriteLine("Feb has 28 or 29 days");
        break;
}