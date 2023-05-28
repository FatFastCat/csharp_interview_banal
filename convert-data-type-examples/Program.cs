/*
===============
E X E R C I S E
===============
Create a looping structure that can be used to iterate through each string value in the array values.
- Rule 1: If the value is alphanumeric, concatenate it to form a message.
- Rule 2: If the value is numeric, add it to the total.
===============
By MS Learn: 
https://learn.microsoft.com/en-us/training/modules/csharp-convert-cast/4-challenge
===============
*/


static void exercise1()
{
    string[] values = { "12.3", "45", "ABC", "11", "DEF" };

    decimal sum = 0m;
    string message = "";

    foreach (var value in values)
    {
        if (decimal.TryParse(value, out decimal number))
            sum += number;
        else
            message += value;
    }
 
    Console.WriteLine($"Message: {message}\nTotal: {sum}");
    ;
}

/*
===============
E X E R C I S E
===============
Replace the code comments in the starter code with your own code to solve the challenge
- Solve for result1: Divide value1 by value2, display the result as an int
- Solve for result2: Divide value2 by value3, display the result as a decimal
- Solve for result3: Divide value3 by value1, display the result as a float
===============
By MS Learn: 
https://learn.microsoft.com/en-us/training/modules/csharp-convert-cast/6-challenge-2
===============
*/

static void exercise2()
{
    int value1 = 12;
    decimal value2 = 6.2m;
    float value3 = 4.3f;


    var result1 = Convert.ToInt32((decimal)value1 / value2);
    var result2 = value2 / (decimal)value3;
    var result3 = value3 / value1;

    Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

    // Your code here to set result2
    Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

    // Your code here to set result3
    Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
}

Console.WriteLine($"-----\nExercise1 result:");
exercise1();
Console.WriteLine($"-----\nExercise2 result:");
exercise2();