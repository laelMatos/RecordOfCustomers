using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Customer.Infra;
using Customer.Service;


namespace Customer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void NaoDeveHaverNomeNulo()
        //{
        //    Customer customer = new Customer("Lael");
        //}
        //[TestMethod]
        //public void ObterUsuarioPorIdAposInsercao()
        //{

        //}
        [TestMethod]
        public void TesteAtualizarUsuario()
        {
            Customer customer = new Customer("Lael")
            {
                Cpf = "054.654.456-58",
            };
            CustomerService customers = new CustomerService();
            customers.Add(customer);

            var CustomerUpdated = customers.GetCustomerByID(customer.Id);
            CustomerUpdated.SetName("João");
            customers.Update(CustomerUpdated);

            var foiAtualizado = customers.GetCustomerByID(CustomerUpdated.Id);
            Assert.AreEqual("João", customer.Name);


        }
        [TestMethod]
        public void TesteScriptValidaEmail()
        {
            string email = "cgl.ael@gmail.";
            //email = email.Split("");
            bool tem = email.Substring(email.IndexOf("@")).Contains(".");
            int apos = email.Substring(email.IndexOf("@")).Substring(email.Substring(email.IndexOf("@")).IndexOf(".") + 1).Length;
            
            Console.WriteLine("Tem @ : "+ email.Contains("@"));    
            Console.WriteLine("Após o @ tem ponto : " + email.Substring(email.IndexOf("@")).Contains("."));            
            Console.WriteLine("Após o ponto tem mais de 1 caractere : " + (apos > 1));
        }
        
         [TestMethod]
        public void TesteBuscaUsuarioExistente()
        {
            Customer customer;
            customer = new Customer("Lael")
            {
                Cpf = "054.654.456-58",
                Email = "cglael@gmail.com"
            };
            CustomerService customers = new CustomerService();
            customers.Add(customer);
            customer = new Customer("Lael")
            {
                Cpf = "054.654.456-58",
                Email = "cglael@gmail.com"
            };


           //var teste =  customers.GetCustomers().FindAll(x=> x.Cpf == customer.Cpf).Count;
           // if (teste >0)
           //     throw new Exception("Cliente existente!!!");//O cliente já existe

            customers.Add(customer);

            foreach (Customer client in customers.GetCustomers())
                Console.WriteLine(client.Cpf);

            //foreach (Customer client in customers.GetCustomers())
            //    if (client.Cpf == customer.Cpf)
            //        throw new Exception("Customer already exists");//O cliente já existe



        }
    }
}
