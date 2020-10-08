using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    public class DateFirstTry
    {

        public String month;
        public int day;
        public int year; //a four digit number.

        public void writeOutput()
        {
            Console.WriteLine(month + " " + day + ", " + year);
        }

        public void MakeItNewYears()
        {
            this.month = "January";
            this.day = 1;
        }

        public string yellIfNewYear()
        {
            if(this.month == "January" && this.day == 1)
            {
                return "Hurrah!";
            }
            else
            {
                return "Not New Year's Day.";
            }
        }
    }
}
