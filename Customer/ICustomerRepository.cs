using System;
using System.Collections.Generic;
using System.Text;

namespace Customer
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);

        Customer GetById(int id);
        List<Customer> GetCustomers();
    }
}
