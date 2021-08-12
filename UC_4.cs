using System;
using System.Collections.Generic;
using System.Text;

namespace day_8LineComparisionUsingOOPS
{
    class UC_4
    {
         public double x1, x2, y1, y2;
         public double a1, a2, b1, b2;
        public double length1, length2;
        public void userInputs()
        {

            double x1, x2, y1, y2;
            double a1, a2, b1, b2;
            Console.WriteLine("enter the co-ordinates of line1");
            Console.WriteLine("enter co-ordinates(x1,y1): ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter co-ordinates(x2,y2): ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());



            Console.WriteLine("enter the co-ordinates of line2");
            Console.WriteLine("enter co-ordinates(a1,b1): ");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter co-ordinates(a2,b2): ");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());

        }
        public void calculation()
        {



            length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            length2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((a2 - b1), 2));
        }

            //Console.WriteLine("L1 "+length1+ "L2 "+length2);

        public void compare()
        {

        
            if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("length of the line 1 is gretar length of line2");


            }
            else if (length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("length of the line 1 is lesser length of line2.");

            }
            else
            {

                Console.WriteLine("length of the line is equal.");
            }

        }
    }
}

        
    


        
    

