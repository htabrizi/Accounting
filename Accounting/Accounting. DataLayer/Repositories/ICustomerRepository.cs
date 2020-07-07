using System.Collections.Generic;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository

    {
        List<Customers> GetAllCustomers();
        Customers GetCustomerbyID(int customerId);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
        void Save();
   }
}
