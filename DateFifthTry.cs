using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class DateFifthTry
    {
        private string month;
        private int day;
        private int year;


        public void writeOutput()
        {
            Console.WriteLine(month + " " + day + ", " + year);
        }

        public void readInput()
        {
            bool tryAgain = true;
            while (tryAgain)
            {
                Console.WriteLine("Enter month, day, and year as three integers:-");
                Console.WriteLine("Use enter after each integer.");
                int monthInput = Convert.ToInt32(Console.ReadLine());
                int dayInput = Convert.ToInt32(Console.ReadLine());
                int yearInput = Convert.ToInt32(Console.ReadLine());
                if (dateOK(monthInput, dayInput, yearInput))
                {
                    setDate(monthInput, dayInput, yearInput);
                    tryAgain = false;
                }
                else
                    Console.WriteLine("Illegal date. Reenter input.");
            }
        }

        public void setDate(int month, int day, int year)
        {
            if (dateOK(month, day, year))
            {
                this.month = monthString(month);
                this.day = day;
                this.year = year;
            }
            else
            {
                Console.WriteLine("Fatal Error");
                Environment.Exit(0);
            }
        }

        private bool dateOK(int monthInt, int dayInt, int yearInt)
        {
            return ((monthInt >= 1) && (monthInt <= 12) &&
                (dayInt >= 1) && (dayInt <= 31) &&
                (yearInt >= 1000) && (yearInt <= 9999));

        }
        
        public void setMonth(int monthNumber)
        {
            if ((monthNumber <= 0) || (monthNumber > 12))
            {
                Console.WriteLine("Fatal Error");
                Environment.Exit(0);
            }
            else
                month = monthString(monthNumber);
        }
        public void setDay(int day)
        {
            if ((day <= 0) || (day > 31))
            {
                Console.WriteLine("Fatal Error");
                Environment.Exit(0);
            }
            else
                this.day = day;
        }
        public void setYear(int year)
        {
            if ((year < 1000) || (year > 9999))
            {
                Console.WriteLine("Fatal Error");
                Environment.Exit(0);
            }
            else
                this.year = year;
        }

        public bool equals(DateFifthTry otherDate)
        {
            return month.Equals(otherDate.month,StringComparison.OrdinalIgnoreCase)
            && (day == otherDate.day) && (year == otherDate.year);
        }

        public bool precedes(DateFifthTry otherDate)
        {
            return ((year < otherDate.year) 
                || (year == otherDate.year && getMonth() < otherDate.getMonth()) 
                || (year == otherDate.year && month.Equals(otherDate.month) && day < otherDate.day));
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
