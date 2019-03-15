using Customer.Infra;
using System;
using System.Collections.Generic;

namespace Customer.Service
{
    public class CustomerService : ICustomerService
    {

        ICustomerRepository customerRepository = new CustomerRepository();
        //Add new customer
        public void Add(Customer customer)
        {
            customer.Validate();

            var ExistingCustomers = customerRepository.GetCustomersByCpf(customer.Cpf).Count;

            if (ExistingCustomers != 0)
                throw new Exception("Customer already exists");//O cliente já existe

            customerRepository.Add(customer);           
        }
        //Update customer
        public void Update(Customer customer)
        {
            customer.Validate();
            this.customerRepository.Update(customer);
        }
        //
        public void Delete(Customer customer)
        {
            customer = customerRepository.GetById(customer.Id);
            if (customer == null)
                throw new Exception("Customer not found");//Cliente não encontrado
            this.customerRepository.Delete(customer);
        }
        //Get customer by id
        public Customer GetCustomerByID(int id)
        {
            var customer = customerRepository.GetById(id);
            if (customer == null)
                throw new Exception("Customer not found");//Cliente não encontrado
            return customer;
        }
        //Get customers
        public List<Customer> GetCustomers()
        {
            return customerRepository.GetCustomers();
        }
        //Get customers by cpf
        public List<Customer> GetCustomersByCpf(string cpf)
        {
            return customerRepository.GetCustomersByCpf(cpf);
        }
        //Get customers by name
        public List<Customer> GetCustomersByName(string name)
        {
            return customerRepository.GetCustomersByName(name);
        }
    }
}
