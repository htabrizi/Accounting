using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Services;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository customer = new CustomerRepository();

            var list = customer.GetAllCustomers();
        }
    }
}
