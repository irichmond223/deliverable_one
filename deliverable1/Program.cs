using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Totalnumber1,Totalnumber2,Totalnumber3;
            double total, average;


             Console.WriteLine("Enter a number 1: ");
            Totalnumber1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a number 2: ");
            Totalnumber2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a number 3: ");
            Totalnumber3 = Convert.ToDouble(Console.ReadLine());

            total = Totalnumber1 + Totalnumber2 + Totalnumber3;
            average = total / 3;

            //Convert from double to decimal using explicit convention
            decimal userInput = (decimal)Totalnumber1;
            userInput = 0.00M;
            userInput = Convert.ToDecimal(total);

            //Console.WriteLine("Total: " + total);
            Console.WriteLine("The Average: " + average);
            Console.WriteLine("The Smallest Amount: " + Math.Min(Totalnumber1, Math.Min(Totalnumber2, Totalnumber3)));
            Console.WriteLine("The Largest Amount: " + Math.Max(Totalnumber1, Math.Max(Totalnumber2, Totalnumber3)));
            Console.ReadLine();

            Console.WriteLine("US: " + userInput.ToString("C"));
            Console.WriteLine("Swedish: " + userInput.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));
            Console.WriteLine("Japanese: " + userInput.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Thai: " + userInput.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));
            Console.ReadLine();
        }
    }
}
