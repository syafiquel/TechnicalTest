using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TechnicalTest
{
    class fareCalculator
    {
        public static decimal sum;
        public static void Calculate()
        {

            using (StreamReader readFile = new StreamReader("C:/TechnicalTest/newInput.DAT"))
            {
                int totalLines = 0;
                foreach (var line in File.ReadLines(@"C:/TechnicalTest/newInput.DAT"))
                {
                    totalLines++;
                    string newline = line.ToString();
                    decimal fare = Convert.ToDecimal(newline.Substring(68, 9));
                    decimal[] arr = new decimal[totalLines];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] += fare;
                    }
                    sum = arr.Sum();
                }
            }
            Console.WriteLine("Total Fare Charges = RM " + sum);
            Console.WriteLine();
        }
    }
}
