using System;
//using System.ComponentModel.DataAnnotations;

namespace Customer
{
    public class Customer
    {
        //Construtor classe Customer
        public Customer(string name)
        {
            ValidateName(name);
            this.Name = name;
        }
        //
        public void SetName(string name)
        {
            ValidateName(name);
            this.Name = name;
        }
        //Variaveis
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Email { get; set; }
        public string Cpf { get;  set ; }
        public string Cel { get; set; }
        public bool Whats { get; set; }
        public string Tel { get; set; }
        public string Ramal { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public DateTime DateInsert{ get; set; }
        public DateTime DateUpdate { get; set; }
        //Validade CPF end Email
        public void Validate()
        {
            ValidateCpf();
            ValidateEmail();
        }
        //Validate Name
        private void ValidateName(string name)
        {
            if (name == null || name.Length < 2)
                throw new Exception("Invalid customer name");
        }
        //Validate CPF
        private void ValidateCpf()
        {
            if (this.Cpf == null || this.Cpf.Length < 11 || this.Cpf == "")
                throw new Exception("Invalid CPF");
        }
        //Validate Email
        private void ValidateEmail()
        {
            if (this.Email == null || this.Email == "" || !this.Email.Contains("@") ||  
                !this.Email.Substring(this.Email.IndexOf("@")).Contains(".") ||
                    !(this.Email.Substring(this.Email.IndexOf("@")).Substring(this.Email.Substring(this.Email.IndexOf("@")).IndexOf(".") + 1).Length > 1))
                throw new Exception("Invalid E-mail");
        }
    }
}
