using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_LineComparisonDemo
{
    internal class CheckEqualityOfLine
    {
        public void Point()
        {
            int x1 = 10, y1 = 10;
            int x2 = 20, y2 = 10;

            int p1 = 30, q1 = 30;
            int p2 = 40, q2 = 30;
            {
                double Line1 = Math.Sqrt((x2 - x1) * 2 + (y2 - y1) * 2);
                double Line2 = Math.Sqrt((p2 - p1) * 2 + (q2 - q1) * 2);

                if (Line1.Equals(Line2))
                {
                    Console.WriteLine("line1  is Equal To  Line2");
                    Console.WriteLine(Line1 + " is equal to" + Line2);
                }
                else
                {
                    Console.WriteLine("line1 is not Equal To Line2");
                    Console.WriteLine(Line1 + " is equal to" + Line2);
                }
            }
        }
    }
}
