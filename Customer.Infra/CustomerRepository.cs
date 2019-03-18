using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace Customer.Infra
{
    public class CustomerRepository : ICustomerRepository
    {
        List<Customer> CustomersInDataBase = new List<Customer>();
        //
        public void Add(Customer customer){
            customer.DateInsert = DateTime.Now;
            if (CustomersInDataBase.Count == 0)
                customer.Id = 0;
            else
                customer.Id = CustomersInDataBase[CustomersInDataBase.Count -1].Id + 1;

            CustomersInDataBase.Add(customer);
        }
        //
        public void Delete(Customer customer)
        {
            CustomersInDataBase.Remove(CustomersInDataBase[customer.Id]);
        }
        //
        public void Update(Customer customer)
        {
            customer.DateUpdate = DateTime.Now;
            customer.DateInsert = CustomersInDataBase[customer.Id].DateInsert;
            CustomersInDataBase[customer.Id] = customer;
        }
        //
        public Customer GetById(int id){
            var customer = CustomersInDataBase.Where(x => x.Id == id).FirstOrDefault();
            return customer;
        }
        //
        public List<Customer> GetCustomers(){
            return CustomersInDataBase.ToList<Customer>();
        }
    }
}
