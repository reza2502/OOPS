using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    public class DateSecondTry
    {
        private String month;
        private int day;
        private int year; //a four digit number.
        public void writeOutput()
        {
            Console.WriteLine(this.month + " " + this.day + ", " + this.year);
        }
        public void readInput()
        {
            Console.WriteLine("Enter Month :-");
            this.month = Console.ReadLine();
            Console.WriteLine("Enter Day :-");
            this.day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year :-");
            this.year = Convert.ToInt32(Console.ReadLine());
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

        public int getNextYear()
        {
            return this.year + 1;
        }

        public void happyGreeting()
        {
            for(int i=0;i<this.day;i++)
            {
                Console.WriteLine("Happy Days!");
            }
        }
    }
}
