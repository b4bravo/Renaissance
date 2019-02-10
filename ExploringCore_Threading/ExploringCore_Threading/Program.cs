using ExploringCore_Threading.BAL;
using System;
using System.Threading.Tasks;

namespace ExploringCore_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var CustomerBAL = new CustomerBAL();

            Task.Factory.StartNew(() =>
            {
                var customer = CustomerBAL.GetCustomer();
                Console.WriteLine($"{customer.Id} - {customer.LName}, {customer.FName}");
            });

            Console.ReadLine();
        }


    }
}
