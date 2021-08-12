using System;
using System.Collections.Generic;
using System.Text;

namespace day_8LineComparisionUsingOOPS
{
    public class UC_1
    {

        public static void lengthOfSingleLine()
        {



           Console.WriteLine("enter co-ordinates(x1,y1):");
           double x1 = double.Parse(Console.ReadLine());
           double y1 = double.Parse(Console.ReadLine());
           Console.WriteLine("enter co-ordinates(x2,y2)");
           double x2 = double.Parse(Console.ReadLine());
           double y2 = double.Parse(Console.ReadLine());
           double lentgh = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
           Console.WriteLine("the length of the line is :" + lentgh);
        }
    }
}
