using System;
using System.Threading.Channels;

namespace ClassDemo
{
    class Staff
    {
        //Field, variables declared inside the class
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        //===============Properties===================
        //Properties, allow us to modify private field
        public int HoursWorked
        {
            get { return hWorked; }
            set
            {
                if (value > 0)
                    hWorked = value;
                else
                {
                    hWorked = 0;
                }
            }
        }

        //==============Method===================================
        //Method 1, print calculate pay in console
        public void PrintMessage()
        {
            Console.WriteLine("Calculate Pay..");
        }

        //Method 2, generate the staff pay of staff with no argument
        public int CalculatePay()
        {
            PrintMessage();

            int staffPay;

            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
            {
                return 0;
            }
        }

        //Method 3, generate the staff pay with two arguments, bonus and allowance
        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
            {
                return 0;
            }
        }

        //================Constructors==========================================

        //constructor with one argument
        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("--------------------------------------------");
        }

        //constructors with two argument

        public Staff(string firstName, string lastName)
        {
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("----------------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Calculate Pay With two argument ====");
            Console.WriteLine("====staff With one argument ====");
            Console.WriteLine("\n");
            int pay;
            Staff staff1 = new Staff("Peter");
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400);
            Console.WriteLine("Pay = {0}", pay);
            Console.WriteLine("\n");
            Console.WriteLine("************************************************");
            Console.WriteLine("\n");
            Console.WriteLine("====Calculate Pay With one argument====");
            Console.WriteLine("====staff With two argument ====");
            Console.WriteLine("\n");
            Staff staff2 = new Staff("Yassin", "Ndali");
            staff2.HoursWorked = 200;
            pay = staff2.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);
            Console.WriteLine("\n");
            Console.WriteLine("************************************************");
            Console.WriteLine("====Calculate Pay With one argument====");
            Console.WriteLine("====staff With hworked less than 0 ====");
            Console.WriteLine("\n");
            Staff staff3 = new Staff("Juma");
            staff3.HoursWorked = -10;
            pay = staff3.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);
        }
    }
}
