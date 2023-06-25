using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_LineComparisonDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string ans = "";
            do
            {
                Console.WriteLine(" 1: Line Copmarision Program \n 2: Check Equality Of Line \n 3: Check Equality using compare method");
                Console.WriteLine("Enter the choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        LineComparision line = new LineComparision(10, 20, 30, 40);
                        line.Calculate();
                        break;
                    case 2:
                        CheckEqualityOfLine equalityOfLine = new CheckEqualityOfLine();
                        equalityOfLine.Point();
                        break;
                    case 3:
                        CheckEqualityUsingCompareMethod compareLine = new CheckEqualityUsingCompareMethod();
                        compareLine.Point_Of_First_Line(10, 20, 30, 40);
                        compareLine.Point_Of_Last_tLine(10, 20, 30, 40);
                        compareLine.CompareLine();
                        break;
                    default:
                        Console.WriteLine("Please insert valid input");
                        break;
                }
                Console.WriteLine("Do you want to continue ?");
                ans = Console.ReadLine();
            } while (ans == "yes" || ans == "y");
        }
    }
}
