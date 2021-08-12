using System;
using System.Collections.Generic;
using System.Text;

namespace day_8LineComparisionUsingOOPS
{
   public class UC_2
    {
        public static void CheckEquality()
        {

        
      
        Console.WriteLine("enter the co-ordinates of line1");
            Console.WriteLine("enter co-ordinates(x1,y1): ");
            double x1=double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("enter co-ordinates(x2,y2): ");
           double x2 = double.Parse(Console.ReadLine());
       double y2 = double.Parse(Console.ReadLine());
        Console.WriteLine("enter the co-ordinates of line2");
            Console.WriteLine("enter co-ordinates(a1,b1): ");
           double a1 = double.Parse(Console.ReadLine());
       double b1 = double.Parse(Console.ReadLine());
        Console.WriteLine("enter co-ordinates(a2,b2): ");
            double a2 = double.Parse(Console.ReadLine());
       double b2 = double.Parse(Console.ReadLine());
        double lentgh1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        double lentgh2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((a2 - b1), 2));


            string answer1 = Convert.ToString(lentgh1);
            string answer2 = Convert.ToString(lentgh2);
            Console.WriteLine(answer1.Equals(answer2));

        }
        }
    }

    

