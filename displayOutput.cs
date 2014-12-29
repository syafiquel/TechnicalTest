using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TechnicalTest
{
    class displayOutput
    {
        public static string seperateKeyword()
        {
            string keyword = "$LTNG";
            using (StreamReader inputFile = new StreamReader("C:/TechnicalTest/DataTest.DAT"))
            {
                using (StreamWriter writeOutput = File.AppendText("C:/TechnicalTest/newInput.DAT"))
                {
                    foreach (string line in File.ReadLines(@"C:/TechnicalTest/DataTest.DAT"))
                    {
                        if (line.Contains(keyword))
                        {
                            writeOutput.WriteLine(line);
                        }
                    }
                }

            }
            return keyword;
        }

        public static void splitString()
        {
            //open the input file
            using (StreamReader inputFile = new StreamReader("C:/TechnicalTest/newInput.DAT"))
            {
                //append the output file during writing
                using (StreamWriter writeOutput = File.AppendText("C:/TechnicalTest/output.log"))
                {

                    //initialize the counter
                    int counter = 0;
                    //begin to read all lines in the text file
                    foreach (var line in File.ReadLines(@"C:/TechnicalTest/newInput.DAT"))
                    {
                        //split the particular data using substring method
                        string newline = line.ToString();
                        string date = newline.Substring(5, 8);
                        string time = newline.Substring(13, 6);
                        string card = newline.Substring(33, 18);
                        string manufacturing = newline.Substring(51, 8);
                        string fare = newline.Substring(68, 9);
                        string charge = newline.Substring(77, 11);
                        string balance = newline.Substring(88, 11);
                        //increment the counter
                        counter++;
                        //write the output into output.log
                        writeOutput.WriteLine("Line #:{0}, Transaction Date:{1}, Transaction Time:{2}, Card #:{3}, Manufacturing #:{4}, Fare Charges:{5}, Amount Charges:{6}, Balance:{7}", counter, date, time, card, manufacturing, fare, charge, balance);                   
                    }


                }

            }

        }

        public static void consoleOutput()
        {
            using (StreamReader readFile = new StreamReader("C:/TechnicalTest/newInput.DAT"))
            {
                foreach (var line in File.ReadAllLines(@"C:/TechnicalTest/newInput.DAT"))
                {
                    string newline = line.ToString();
                    string date = newline.Substring(5, 8);
                    string time = newline.Substring(13, 6);
                    string card = newline.Substring(33, 18);
                    string fare = newline.Substring(68, 9);
                    string balance = newline.Substring(88, 11);
                    decimal newFare = Convert.ToDecimal(fare);
                    decimal newBalance = Convert.ToDecimal(balance);

                    string dateYear = date.Substring(0, 4);
                    string dateMonth = date.Substring(4, 2);
                    string dateDay = date.Substring(6, 2);
                    int year = Convert.ToInt32(dateYear);
                    int month = Convert.ToInt32(dateMonth);
                    int day = Convert.ToInt32(dateDay);
                    DateTime dt = new DateTime(year, month, day);
                    string newDate = String.Format("{0:dd MMMMMMMMM yyyy}", dt);

                    string timeHour = time.Substring(0, 2);
                    string timeMin = time.Substring(2, 2);
                    string timeSec = time.Substring(4, 2);
                    int hour = Convert.ToInt32(timeHour);
                    int min = Convert.ToInt32(timeMin);
                    int sec = Convert.ToInt32(timeSec);
                    DateTime dt2 = new DateTime(year, month, day, hour, min, sec);
                    string newTime = String.Format("{0:HH:mm:ss}", dt2);

                    Console.WriteLine("Tarikh:           " + newDate);
                    Console.WriteLine("Masa:             " + newTime);
                    Console.WriteLine("Card #:           " + card);
                    Console.WriteLine("Fare Charges:     RM " + newFare);
                    Console.WriteLine("Balance:          RM " + newBalance);
                    Console.WriteLine();
                }
            }
        }
    }
}
