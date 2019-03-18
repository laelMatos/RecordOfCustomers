using System;
using System.Collections.Generic;

namespace Customer.Service
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        Customer GetCustomerByID(int id);
        List<Customer> GetCustomers();
    }
}
