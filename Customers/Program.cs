// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer customer = new Customer();

class Customer
{

    public Customer()
    {
        Console.WriteLine("Deneme deneme");
    }
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string City { get; set; }

}