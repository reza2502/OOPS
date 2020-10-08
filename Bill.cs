using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class Bill
    {
        public static readonly double RATE = 150.00;

        private int hours;
        private int minutes;
        private double fee;

        public void inputTimeWorked()
        {
            Console.WriteLine("Enter number of full hours worked");
            Console.WriteLine("followed by number of minutes:");
            hours = Convert.ToInt32(Console.ReadLine());
            minutes = Convert.ToInt32(Console.ReadLine());
        }
        private double computeFee(int hoursWorked, int minutesWorked)
        {
            minutesWorked = hoursWorked * 60 + minutesWorked;
            int quarterHours = minutesWorked / 15;
            //Any remaining fraction of a quarter hour is not
            //charged for.
            return quarterHours * RATE;
        }
        public void updateFee()
        {
            fee = computeFee(hours, minutes);
        }
        public void outputBill()
        {
            Console.WriteLine("Time worked: ");
            Console.WriteLine(hours + " hours and " + minutes +
            " minutes");
            Console.WriteLine("Rate: $" + RATE + " per quarter hour.");
            Console.WriteLine("Amount due: $" + fee);
        }
    }
}
