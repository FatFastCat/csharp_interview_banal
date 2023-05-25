/*
===============
E X E R C I S E
===============
Code project 1 - write code that validates integer input
Here are the conditions that your first coding project must implement:
- Your solution must include either a do-while or while iteration.
- Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
- Inside the iteration block:
- - Your solution must use a Console.ReadLine() statement to obtain input from the user.
- - Your solution must ensure that the input is a valid representation of an integer.
- - If the integer value is not between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
- - Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
- Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
===============
By MS Learn: 
https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements
===============
********/

void CodeProject1()
{
    Console.WriteLine("==== Code project 1 =====");

    int number;
    int[] numberRange = { 5, 6, 7, 8, 9, 10 };

    Console.WriteLine("Enter an integer value between 5 and 10");
    do
    {
        var input = Console.ReadLine();
        bool isNumber = int.TryParse(input, out number);

        if (isNumber)
        {
            if (numberRange.Contains(number))
            {
                break;
            }
            else
            {
                Console.WriteLine($"You entered {input}. Please enter a " +
                    $"number between 5 and 10.");
                continue;
            }
        }
        else
        {
            Console.WriteLine($"Sorry, you entered an invalid number " +
                $"({input}), please try again");
            continue;
        }

    } while (true);

    Console.WriteLine($"Your input value ({number}) has been accepted.");
}


/*
===============
E X E R C I S E
===============
Code project 2 - write code that validates string input
Here are the conditions that your second coding project must implement:
- Your solution must include either a do-while or while iteration.
- Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.
- Inside the iteration block:
- - Your solution must use a Console.ReadLine() statement to obtain input from the user.
- - Your solution must ensure that the value entered matches one of the three role options.
- - Your solution should use the Trim() method on the input value to ignore leading and training space characters.
- - Your solution should use the ToLower() method on the input value to ignore case.
- - If the value entered is not a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
- Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
===============
By MS Learn: 
https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements
===============
********/

void CodeProject2()
{
    Console.WriteLine("==== Code project 2 =====");

    string[] roles = { "Administrator", "Manager", "User" };
    string userRole;

    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    do
    {
        var userInput = Console.ReadLine();
        userRole = string.IsNullOrEmpty(userInput) ? "" : userInput.Trim()
            .ToLower();
        userRole = char.ToUpper(userRole[0]) + userRole[1..];

        if (roles.Contains(userRole))
            break;
        else
            Console.WriteLine($"The role name that you entered, " +
                $"\"{userInput}\" is not valid. Enter your role " +
                $"name (Administrator, Manager, or User)");
    } while (true);

    Console.WriteLine($"Your input value ({userRole}) has been accepted.");
}


/*
===============
E X E R C I S E
===============
Code project 3 - Write code in the code editor to implement code that achieves the project conditions
- your solution must use the following string array to represent the input to your coding logic:
- - string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
- Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.
- Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you will process inside the loops should be named myString.
- In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there is no period character in the string, a value of -1 will be returned.
- Your solution must include an inner do-while or while loop that can be used to process the myString variable.
- In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
- In the inner loop, your solution must not display the period character.
- In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.
===============
By MS Learn: 
https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements
===============
********/

void CodeProject3()
{
    string[] myStrings = new string[2] { "I like pizza. I like roast chicken." +
        " I like salad", "I like all three of the menu choices" };
    int periodLocation;
    int countMyStrings = myStrings.Length;
    for (int i = 0; i < countMyStrings; i++)
    {
        string myString = myStrings[i];
        periodLocation = myString.IndexOf(".");

        string mySentence;

        while (periodLocation != -1)
        {
            mySentence = myString.Remove(periodLocation);
            myString = myString[(periodLocation + 1)..].Trim();
            periodLocation = myString.IndexOf(".");
            Console.WriteLine(mySentence);
        }
        mySentence = myString.Trim();
        Console.WriteLine(mySentence);
    }
}


/*
===============
P R O G M E N U
===============
*/


string userSelect;

do
{
    Console.WriteLine("select a project: ");
    Console.WriteLine("1 - write code that validates integer input");
    Console.WriteLine("2 - write code that validates string input");
    Console.WriteLine("3 - Write code in the code editor to implement " +
        "code that achieves the project conditions");
    Console.WriteLine("q - exit");
    var input = Console.ReadLine();
    userSelect = string.IsNullOrEmpty(input) ? "" : input;

    switch (userSelect)
    {
        case "1":
            CodeProject1();
            break;
        case "2":
            CodeProject2();
            break;
        case "3":
            CodeProject3();
            break;
    }
} while (userSelect != "q");