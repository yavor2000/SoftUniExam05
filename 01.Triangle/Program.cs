/* Problem 1. Triangle
 */

using System;

class Program
{
    static void Main()
    {
        double ax = double.Parse(Console.ReadLine());
        double ay = double.Parse(Console.ReadLine());
        double bx = double.Parse(Console.ReadLine());
        double by = double.Parse(Console.ReadLine());
        double cx = double.Parse(Console.ReadLine());
        double cy = double.Parse(Console.ReadLine());

        double distAB = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
        double distBC = Math.Sqrt((bx - cx) * (bx - cx) + (by - cy) * (by - cy));
        double distAC = Math.Sqrt((ax - cx) * (ax - cx) + (ay - cy) * (ay - cy));

        double p = (distAB + distBC + distAC) / 2;
        double area = Math.Sqrt((p * (p - distAB) * (p - distBC) * (p - distAC)));
        if (((distAB + distBC) > distAC) &&
            ((distAC + distBC) > distAB) &&
            ((distAB + distAC) > distAB) && (area != 0))
        {

            Console.WriteLine("Yes\n{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No\n{0:F2}", distAB);
        }
    }
}