using System;
namespace method_exercises
{
    public static class MedicineSchedule
    {
        // menu #2 DisplayTimes
        public static void DisplayTimes(int[] times)
        {
            /* Format and display medicine times */
            foreach (int val in times)
            {
                string time = val.ToString();
                int len = time.Length;

                if (len >= 3)
                {
                    time = time.Insert(len - 2, ":");
                }
                else if (len == 2)
                {
                    time = time.Insert(0, "0:");
                }
                else
                {
                    time = time.Insert(0, "0:0");
                }

                Console.Write($"{time} ");
            }

            Console.WriteLine();
        }

        // menu #2 AdjustTimes
        public static int[] AdjustTimes(int[] times, int diff)
        {
            /* Adjust the times by adding the difference, keeping the value within 24 hours */
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = ((times[i] + diff)) % 2400;
            }

            return times;
        }
    }
}

