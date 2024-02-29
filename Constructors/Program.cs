


Customer customer1 = new Customer { Id = 3, FirstName="Meral",LastName="Köseoğlu", City="Ankara"};

Customer customer2 = new Customer(2,"Abuduk","Köseoğlu","Ankara");

Console.WriteLine(customer2.FirstName);

class Customer
{
    public Customer()
    {
        
    }

    public Customer(int id, string firstName, string lastName, string city)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.City = city;

        Console.WriteLine("Constructor çalışıyor");
    }
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string City { get; set; }


}
