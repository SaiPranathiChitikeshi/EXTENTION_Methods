using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    static class Booking
    {
        public static void BookingCode(this Department g)
        {
            Console.WriteLine("Method Name: Booking Code");
        }
    }

    public class ExtensionExample {
        public static void Main(string[] args)
        {
            Department department = new Department();
            department.Name();
            department.Code();
            department.CostCenterId();
            department.BookingCode();
        }
    }
}
