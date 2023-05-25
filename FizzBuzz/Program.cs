/*
===============
E X E R C I S E
===============
Here are the FizzBuzz rules that you need to implement in your code project:
- Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
- When the current value is divisible by 3, print the term Fizz next to the number.
- When the current value is divisible by 5, print the term Buzz next to the number.
- When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
===============
By MS Learn: 
https://learn.microsoft.com/en-us/training/modules/csharp-for/3-challenge
===============
********/


var word = "";

for (var i = 1; i < 101; i++)
{
    word = i.ToString();
    if (i % 15 == 0)
        word += " FizzBazz";
    else if (i % 5 == 0)
        word += " Buzz";
    else if (i % 3 == 0)
        word += " Fizz";
    Console.WriteLine($"{word}");
}
