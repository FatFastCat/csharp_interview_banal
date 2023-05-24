string word;

for (int i = 1; i < 101; i++)
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
