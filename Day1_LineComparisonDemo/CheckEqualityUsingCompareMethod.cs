using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_LineComparisonDemo
{
    public class CheckEqualityUsingCompareMethod
    {
        int x1, y1, x2, y2;
        int p1, q1, p2, q2;
        public void Point_Of_First_Line(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public void Point_Of_Last_tLine(int p1, int q1, int p2, int q2)
        {
            this.p1 = p1;
            this.q1 = q1;
            this.p2 = p2;
            this.q2 = q2;
        }
        public void CompareLine() { 
            {
                double Line1 = Math.Sqrt((x2 - x1) * 2 + (y2 - y1) * 2);
                double Line2 = Math.Sqrt((p2 - p1) * 2 + (q2 - q1) * 2);

                Double Equality = Line1.CompareTo(Line2);
                if (Equality > 0)
                {
                    Console.WriteLine("line1 is greater than Line2");
                    Console.WriteLine(Line1 + " is greater than : " + Line2);
                }
                else if (Equality < 0)
                {
                    Console.WriteLine("line1 is Less than Line2");
                    Console.WriteLine(Line1 + " is less than than : " + Line2);
                }
                else
                {
                    Console.WriteLine("line1 is Equal To Line2");
                    Console.WriteLine(Line1 + " is equal to : " + Line2);
                }

            }
        }
    }
}
