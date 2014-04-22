/* Problem 4. Magic Dates
 */

using System;
using System.Globalization;
using System.Threading;

class Program
{
    static int magic = 0;
    
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        CultureInfo format = CultureInfo.InvariantCulture;
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        DateTime stY = DateTime.Today, enY = DateTime.Today;

        try
        {
            stY = DateTime.ParseExact(input1, "yyyy", format);
            enY = DateTime.ParseExact(input2, "yyyy", format);
        }
        catch
        {
            try
            {
                stY = DateTime.Parse(input1);
                enY = DateTime.Parse(input2);
            }
            catch { }
        }
        
        magic = int.Parse(Console.ReadLine());
        weight(stY.Year, enY.Year);
    }
    
    static void weight(int year0, int year1)
    {
        int count = 0;
        CultureInfo format = CultureInfo.InvariantCulture;
        DateTime stDate = DateTime.Parse("01.01." + year0.ToString());
        DateTime enDate = DateTime.Parse("12.31." + year1.ToString());
        string enD = enDate.Day.ToString("00") + enDate.Month.ToString("00") + enDate.Year.ToString("00");
        while (true)
        {
            if (stDate > enDate) break;
            string stD = stDate.Day.ToString("00") + stDate.Month.ToString("00") + stDate.Year.ToString("00");
            if (mag(stD) == magic)
            {
                Console.WriteLine(stDate.Day.ToString("00") + "-" + stDate.Month.ToString("00") + "-" + stDate.Year.ToString("00"));
                count++;
            }
            stDate = stDate.AddDays(1);
        }
        if (count == 0) Console.WriteLine("No");
    }
    static int mag(string str)
    {
        int n = str.Length;
        int[] num = new int[n];
        int rezult = 0;
        for (int i = 0; i < n; i++) num[i] = int.Parse(str[i].ToString());
        for (int i = 0; i < n - 1; i++)
            for (int k = i + 1; k < n; k++)
                rezult += num[i] * num[k];
        return rezult;
    }

}