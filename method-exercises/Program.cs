using System;
using System.Net;
using method_exercises;

public class Program
{
    static void Main(string[] args)
    {
        //menu common variables
        var menuSelect = "";

        //menu #2 variables
        int[] times = { 800, 1200, 1600, 2000 };
        int diff = 0;

        //menu #3 variables
        string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
        string[] address;
        bool validLength = false;
        bool validZeroes = false;
        bool validRange = false;

        do
        {
            Console.Clear();
            Console.WriteLine("1 - Display Random Numbers");
            Console.WriteLine("2 - Medicine Schedule");
            Console.WriteLine("3 - IP Validator");
            Console.WriteLine("exit - to exit");
            menuSelect = Console.ReadLine();
            switch (menuSelect)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Generating random numbers:");
                    RandomNumber.DisplayRandomNumbers();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Enter current GMT");
                    int currentGMT = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Current Medicine Schedule:");
                    MedicineSchedule.DisplayTimes(times);

                    Console.WriteLine("Enter new GMT");
                    int newGMT = Convert.ToInt32(Console.ReadLine());

                    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
                    {
                        Console.WriteLine("Invalid GMT");
                    }
                    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
                    {
                        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                        times = MedicineSchedule.AdjustTimes(times, diff);
                    }
                    else
                    {
                        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
                        times = MedicineSchedule.AdjustTimes(times, diff);
                    }

                    Console.WriteLine("New Medicine Schedule:");
                    MedicineSchedule.DisplayTimes(times);
                    Console.ReadLine();
                    break;

                case "3":
                    Console.Clear();
                    foreach (string ip in ipv4Input)
                    {
                        address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

                        validLength = IPValidator.ValidateLength(address);
                        validZeroes = IPValidator.ValidateZeroes(address);
                        validRange = IPValidator.ValidateRange(address);

                        if (validLength && validZeroes && validRange)
                        {
                            Console.WriteLine($"{ip} ip is a valid IPv4 address");
                        }
                        else
                        {
                            Console.WriteLine($"{ip} ip is an invalid IPv4 address");
                        }
                    }

                    Console.ReadLine();
                    break;
            }
        } while (menuSelect != "exit");
    }
}