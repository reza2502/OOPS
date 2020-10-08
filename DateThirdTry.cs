using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    public class DateThirdTry
    {
        private String month;
        private int day;
        private int year; //a four digit number.
        public void setDate(int newMonth, int newDay, int newYear)
        {
            this.month = monthString(newMonth);
            this.day = newDay;
            this.year = newYear;
            Console.WriteLine("Date changed to " + newMonth + " " + newDay + ", " + newYear);
        }
        public string monthString(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    Console.WriteLine("Fatal Error");
                    return "Error";
            }
        }

        public void writeOutput()
        {
            Console.WriteLine(this.month + " " + this.day + ", " + this.year);
        }

        public double fractionDone(int targetDay)
        {
            double thisDay = this.day;
            return thisDay / targetDay;
        }

        public void advanceYear(int addYear)
        {
            this.year += addYear;
        }

        //P 227, Q8: Yes its legal
        public void multiWriteOutput(int count)
        {
            while (count > 0)
            {
                writeOutput();
                count--;
            }
        }
    }
}
