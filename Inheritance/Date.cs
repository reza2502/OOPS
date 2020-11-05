using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Inheritance
{
    interface IComparable
    {
        public int Compare(object date);
    }

    public class Date
    {
        int day;
        int month;

        public Date(int month, int day)
        {
            this.month = month;
            this.day = day;
        }

        public int getMonth()
        {
            return this.month;
        }

        public int getDay()
        {
            return this.day;
        }

        public void setMonth(int month)
        {
            this.month = month;
        }

        public void setDay(int day)
        {
            this.day = day;
        }

        public int daysInMonth(int month)
        {
            int[] totalMonthDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month >= 0 && month < 12)
                return totalMonthDays[month - 1];
            else
            {
                Console.WriteLine("Fatal Error: Invalid Month.");
                Environment.Exit(0);
                return 0;
            }
        }

        public void nextDay()
        {
            this.day++;
            if (this.day > daysInMonth(this.month))
            {
                if (this.month == 12) this.month = 1; else this.month++;
                this.day = 1;
            }
        }

        public override string ToString()
        {
            string m = this.month < 10 ? "0" + this.month.ToString() : this.month.ToString();
            string d = this.day < 10 ? "0" + this.day.ToString() : this.day.ToString();

            return m + "/" + d;
        }
    }

    public class CalendarDate : Date, IComparable
    {
        int year;
        public CalendarDate(int year, int month, int day) : base(month,day)
        {
            this.year = year;
        }

        public int getYear()
        {
            return this.year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public override string ToString()
        {
            return this.year.ToString() + "/" + base.ToString();
        }

        public void nextDay()
        {
            int day = getDay();
            int month = getMonth();

            if (getDay() == 31 && getMonth() == 12)
            {
                this.year++;
                setMonth(1);
                setDay(1);
            }
            else
                base.nextDay();
        }

        public int Compare(object obj)
        {
            CalendarDate otherDate = obj as CalendarDate;

            if(otherDate.year > this.year) return -1;
            else if (otherDate.year < this.year) return 1;
            else
            {
                if (otherDate.getMonth() > this.getMonth()) return -1;
                else if (otherDate.getMonth() < this.getMonth()) return 1;
                else
                {
                    if (otherDate.getDay() > this.getDay()) return -1;
                    else if (otherDate.getDay() < this.getDay()) return 1;
                }
            }
            return 0;
        }
    }
}
