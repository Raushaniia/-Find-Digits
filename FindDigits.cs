using System;

class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int counter = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while (temp != 0)
            {
                int s = temp % 10;
                if (s != 0 && n % s == 0)
                {
                    counter++;
                }
                temp = temp / 10;
            }
            Console.WriteLine(counter);
        }
    }
}

