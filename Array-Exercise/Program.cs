void ResizeAndClear()
{
    Console.Clear();
    string[] pallets = { "B14", "A11", "B12", "A13" };
    Console.WriteLine("");

    Array.Clear(pallets, 0, 2);
    Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Array.Resize(ref pallets, 6);
    Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

    pallets[4] = "C01";
    pallets[5] = "C02";

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Array.Resize(ref pallets, 3);
    Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
    pallets = pallets.Reverse().ToArray();
    Array.Resize(ref pallets, 1);

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }
}


void SplitAndJoin()
{
    Console.Clear();
    string value = "abc123";
    char[] valueArray = value.ToCharArray();
    Array.Reverse(valueArray);
    //string result = new string(valueArray);
    string result = String.Join(",", valueArray);
    Console.WriteLine(result);

    string[] items = result.Split(",");
    foreach (string item in items)
    {
        Console.WriteLine(item);
    }
}


/*
 * Write code to reverse each word in a message
 */

void ReverceSentenceWords()
{
    Console.Clear();
    string pangram = "The quick brown fox jumps over the lazy dog";
    string[] words = pangram.Split(" ");
    for (int i = 0; i < words.Length; i++)
    {
        char[] letters = words[i].ToCharArray();
        Array.Reverse(letters);
        string word = new(letters);
        words[i] = word;
    }
    string pangramReverse = String.Join(" ", words);
    Console.WriteLine(pangramReverse);
}

/*
 * Data comes in many formats. 
 * In this challenge you have to parse the individual "Order IDs", 
 * and output the "OrderIDs" sorted and tagged as "Error" 
 * if they are not exactly four characters in length.
 */

void ErrorOrdersChallenge()
{
    Console.Clear();

    string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
    string[] orders = orderStream.Split(",");
    Array.Sort(orders);
    for (int i = 0; i < orders.Length; i++)
    {
        if (orders[i].Length == 4)
        {
            Console.WriteLine(orders[i]);
        }
        else
        {
            Console.WriteLine($"{orders[i]} \t - Error");
        }
        
    }
}

string? selectMenu;
do
{
    Console.Clear();
    Console.WriteLine("1 - Resize and Clear");
    Console.WriteLine("2 - Split and join");
    Console.WriteLine("3 - Reverse words in a sentence");
    Console.WriteLine("4 - Error orders challenge");
    Console.WriteLine("q - exit");
    selectMenu = Console.ReadLine();

    switch (selectMenu)
    {
        case "1":
            ResizeAndClear();
            Console.ReadLine();
            break;
        case "2":
            SplitAndJoin();
            Console.ReadLine();
            break;
        case "3":
            ReverceSentenceWords();
            Console.ReadLine();
            break;
        case "4":
            ErrorOrdersChallenge();
            Console.ReadLine();
            break;
    }

} while (selectMenu != "q");