/* Problem 3. House
 */

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mid = n / 2;
        int steni = n / 4;
        string stena = new string('.', n / 4) + "*" + new string('.', n - 2 * (n / 4) - 2) + "*" + new string('.', n / 4);
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(new string('.', (n - 1) / 2) + "*" + new string('.', (n - 1) / 2));
                continue;
            }
            if (i > 0 && i < mid)
            {
                Console.WriteLine(new string('.', (n - 1) / 2 - i) + "*" + new string('.', i * 2 - 1) + "*" + new string('.', (n - 1) / 2 - i));
                continue;
            }
            if (i == mid) { Console.WriteLine(new string('*', n)); continue; }
            if (i > mid && i < n - 1)
            {
                Console.WriteLine(stena); continue;
            }
            if (i == n - 1) Console.WriteLine(new string('.', n / 4) + new string('*', n - 2 * (n / 4)) + new string('.', n / 4));
        }
    }
}