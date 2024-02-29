// See https://aka.ms/new-console-template for more information

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Meral";
            customer.LastName = "Köseoğlu";
            customer.City = "Ankara";


            Customer customer2 = new Customer
            {
                Id = 2, FirstName="Cihat", LastName="Köseoğlu", City="Ankara"
            };

            Console.WriteLine(customer.FirstName);


        }
    }

    

    
}