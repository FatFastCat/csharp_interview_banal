// 1 - Exercise 1 (Formatting, Interpolation)

static void InterpolationFormatting()
{
    Console.Clear();

    // Composite Formatting
    string first = "Hello";
    string second = "World";
    string result = string.Format("{0} {1}!", first, second);
    Console.WriteLine(result);

    // interpolation
    Console.WriteLine("interpolation");
    Console.WriteLine($"{first} {second}!");
    Console.WriteLine($"{second} {first}!");
    Console.WriteLine($"{first} {first} {first}!");

    // Formatting currency
    decimal price = 123.45m;
    int discount = 50;
    Console.WriteLine($"Price: {price:C} (Save {discount:C})");

    // Formatting numbers
    decimal measurement = 123456.78912m;
    Console.WriteLine($"Measurement: {measurement:N4} units");

    // Formatting percentages
    decimal tax = .36785m;
    Console.WriteLine($"Tax rate: {tax:P2}");

    // Combining formatting approaches
    price = 67.55m;
    decimal salePrice = 59.99m;

    string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

    yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
    Console.WriteLine(yourDiscount);
}

/*
* Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
* Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
* Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
* Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
* Methods that turn a string into an array of strings or characters (Split(), ToCharArray())
*/
static void PaddingAlignment()
{
    string paymentId = "769C";
    string payeeName = "Mr. Stephen Ortega";
    string paymentAmout = "$5,000.00";


    var formattedLine = paymentId.PadRight(6);
    formattedLine += payeeName.PadRight(24);
    formattedLine += paymentAmout.PadRight(10);

    Console.WriteLine(formattedLine);
}


static void PaddingAlignmentChallenge()
{
    Console.Clear();

    string customerName = "Ms. Barros";

    string currentProduct = "Magic Yield";
    int currentShares = 2975000;
    decimal currentReturn = 0.1275m;
    decimal currentProfit = 55000000.0m;

    string newProduct = "Glorious Future";
    decimal newReturn = 0.13125m;
    decimal newProfit = 63000000.0m;

    Console.WriteLine($"Dear {customerName},");
    Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
    Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
    Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}.\n");

    Console.WriteLine("Here's a quick comparison:\n");

    string comparisonMessage = currentProduct.PadRight(20) +
        currentReturn.ToString("P2").PadRight(10) +
        currentProfit.ToString("N2") +"\n" +
        newProduct.PadRight(20) +
        newReturn.ToString("P2").PadRight(10) +
        newProfit.ToString($"N2");

    Console.WriteLine(comparisonMessage);
}

string? selectMenu;

do
{
    Console.Clear();
    Console.WriteLine("1 - Exercise 1 (Formatting, Interpolation)");
    Console.WriteLine("2 - Exercise 2 (Padding and alignment)");
    Console.WriteLine("3 - Exercise 3 (Padding and alignment challenge)");
    Console.WriteLine("q - Exit");
    selectMenu = Console.ReadLine();

    switch (selectMenu)
    {
        case "1":
            InterpolationFormatting();
            Console.ReadLine();
            break;
        case "2":
            PaddingAlignment();
            Console.ReadLine();
            break;
        case "3":
            PaddingAlignmentChallenge();
            Console.ReadLine();
            break;
    }
} while (selectMenu != "q");    