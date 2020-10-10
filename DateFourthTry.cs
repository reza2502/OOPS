using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class DateFourthTry
    {
        private string month;
        private int day;
        private int year;

        public string toString()
        {
            return this.month + " " + this.day + ", " + this.year;
        }

        public void writeOutput()
        {
            Console.WriteLine(toString());
        }

        public bool equals(DateFourthTry otherDate)
        {
            return ((month.Equals(otherDate.month))
            && (day == otherDate.day) && (year == otherDate.year));
        }

        public bool precedes(DateFourthTry otherDate)
        {
            return ((year < otherDate.year) ||
                (year == otherDate.year && getMonth() <
                otherDate.getMonth()) || (year == otherDate.year && month.Equals(otherDate.month)
                && day < otherDate.day));
        }

        public int getDay()
        {
            return this.day;
        }
        public int getYear()
        {
            return this.year;
        }
        public int getMonth()
        {
            if (this.month.Equals("January", StringComparison.OrdinalIgnoreCase))
                return 1;
            else if (this.month.Equals("February", StringComparison.OrdinalIgnoreCase))
                return 2;
            else if (this.month.Equals("March", StringComparison.OrdinalIgnoreCase))
                return 3;
            else if (this.month.Equals("April", StringComparison.OrdinalIgnoreCase))
                return 4;
            else if (this.month.Equals("May", StringComparison.OrdinalIgnoreCase))
                return 5;
            else if (this.month.Equals("June", StringComparison.OrdinalIgnoreCase))
                return 6;
            else if (this.month.Equals("July", StringComparison.OrdinalIgnoreCase))
                return 7;
            else if (this.month.Equals("August", StringComparison.OrdinalIgnoreCase))
                return 8;
            else if (this.month.Equals("September", StringComparison.OrdinalIgnoreCase))
                return 9;
            else if (this.month.Equals("October", StringComparison.OrdinalIgnoreCase))
                return 10;
            else if (this.month.Equals("November", StringComparison.OrdinalIgnoreCase))
                return 11;
            else if (this.month.Equals("December", StringComparison.OrdinalIgnoreCase))
                return 12;
            else
            {
                Console.WriteLine("Fatal Error");
                return 0; //Needed to keep the compiler happy
            }
        }

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


    }
}
