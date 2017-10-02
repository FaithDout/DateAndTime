using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString()); 
            /* Shows your present country's way of time */

            //Console.WriteLine(myValue.ToShortDateString());
            /* Shows just date */

            //Console.WriteLine(myValue.ToShortTimeString());
            /*Shows just the time */

            //Console.WriteLine(myValue.ToLongDateString());
            /* Shows long date */

            //Console.WriteLine(myValue.ToLongTimeString());
            /* Shows hours minutes and seconds */

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            /* This is chaining
             * Gets date and adds 3 days to it, 
             * Creates new date which is then accessed by the .
             * it is then converted to long date
             */

            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            /* Adds 3 hours to current time
             * Creates new time
             * Converts to long time string, showing hrs:minutes:seconds
             */

            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            /* Subtracting days from current day
             * There is no subtract method, therefore a negative is put in front of value
             * e.g. -3
             */

            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());
            /* Same thing for subtracting for time */

            //Console.WriteLine(myValue.Month);
            /* Print current month in value */

            //DateTime myBirthday = new DateTime(1996, 7, 12);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("7/12/1996");
            /* To show how many days or how much time from then to now
             * We use a timespan
             */

            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine("You have been alive for: {0} days and {1} hours."
                + " " + "That is AWESOME!!!",
                myAge.TotalDays, myAge.TotalHours);
           

            //We can also add and subtract to other parts of time and date
            //Console.WriteLine(myValue.AddMonths(3).ToLongDateString());
            /* Adds 3 months to present month */



            Console.ReadLine();
        }
    }
}
