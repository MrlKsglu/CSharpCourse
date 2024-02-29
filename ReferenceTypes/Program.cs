


//int sayi1 = 10;
//int sayi2 = 20;

//sayi1 = sayi2;

//sayi2 = 100;

//Console.WriteLine("Sayi1 " + sayi1);


//int[] sayilar1 = new int[] { 1, 2, 3 };

//int[] sayilar2 = new int[] { 10, 20, 30 };

//sayilar1 = sayilar2;

//sayilar2[0] = 88;

//Console.WriteLine(sayilar1[0]);



Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "Meral";
person2.FirstName = "Cihat";
person1=person2;

person2.FirstName = "Betüş";

//Console.WriteLine(person1.FirstName);




Customer customer = new Customer();
customer.FirstName = "Salih";
customer.CreditCardNumber = 123456789;
Employee employee = new Employee();
employee.FirstName = "Veli";

Person person3 = customer;

//Console.WriteLine(((Customer)person3).CreditCardNumber);


PersonManager personManager = new PersonManager();

personManager.Add(employee);


class Person//Base Class
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastNime { get; set; }

}



class Customer:Person//Müşteri
{

    public int CreditCardNumber { get; set; }

}

class Employee:Person//Çalışan
{
    public int EmployeeNumber { get; set; }



}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}