using System;

namespace OOPS
{
    //class Program
    //{
    //    static void Main(string[] arg)
    //    {
    //        DateSecondTry Class
    //        DateSecondTry obj = new DateSecondTry();
    //        obj.readInput();
    //        obj.getMonth();
    //        obj.writeOutput();
    //        obj.happyGreeting();

    //        / DateThirdTry Class
    //        DateThirdTry date = new DateThirdTry();
    //        int year = 1882;
    //        date.setDate(6, 17, year);
    //        date.writeOutput();
    //        date.multiWriteOutput(3);
    //        date.setDate(6, 17, year);
    //    }
    //}

    //public class BillingDialog
    //{
    //    public static void Main(String[] args)
    //    {
    //        Console.WriteLine("Welcome to the law offices of");
    //        Console.WriteLine("Dewey, Cheatham, and Howe.");
    //        Bill yourBill = new Bill();
    //        yourBill.inputTimeWorked();
    //        yourBill.updateFee();
    //        yourBill.outputBill();
    //        Console.WriteLine("We have placed a lien on your house.");
    //        Console.WriteLine("It has been our pleasure to serve you.");
    //    }
    //}

    public class EqualsAndToStringDemo
    {
        public static void Main(String[] args)
        {
            DateFourthTry date1 = new DateFourthTry(),
            date2 = new DateFourthTry();
            date1.setDate(6, 17, 1882);
            date2.setDate(6, 17, 1882);
            if (date1.equals(date2))
                Console.WriteLine(date1.toString() + " equals " + date2.toString()); 
            else
                Console.WriteLine(date1.toString() + " does not equal " + date2.toString());
            date1.setDate(7, 28, 1750);
            if (date1.precedes(date2))
                Console.WriteLine(date1.toString() + " comes before " + date2.toString());
            else
                Console.WriteLine(date2.toString() + " comes before or is equal to " + date1.toString());
        }
    }

}
