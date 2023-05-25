/*
===============
E X E R C I S E
===============
Here are the rules for the battle game that you need to implement in your code project:
- You must use either the do-while statement or the while statement as an outer game loop.
- The hero and the monster will start with 10 health points.
- All attacks will be a value between 1 and 10.
- The hero will attack first.
- Print the amount of health the monster lost and their remaining health.
- If the monster's health is greater than 0, it can attack the hero.
- Print the amount of health the hero lost and their remaining health.
- Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
- Print the winner.
===============
By MS Learn: 
https://learn.microsoft.com/en-us/training/modules/csharp-do-while/3-challenge
===============
*/


var heroHealth = 10;
var monsterHealth = 10;

Random rnd = new Random();

do
{
    var hitDamage = rnd.Next(1,11);
    monsterHealth -= hitDamage;
    Console.WriteLine($"Monster was damaged and lost {hitDamage} health and now has {monsterHealth} health.");

    if (monsterHealth <= 0) continue;

    hitDamage = rnd.Next(1, 11);
    heroHealth -= hitDamage;
    Console.WriteLine($"Her was damaged and lost {hitDamage} health and now has {heroHealth} health.");

} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");

