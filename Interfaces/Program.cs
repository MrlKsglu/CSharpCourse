using Interfaces;

PersonManager personManager = new PersonManager();

Student student = new Student { FirstName = "Ayşe", Departmant = "Mekansal" };

IPersone persone = new Worker();

CustomerManager customerManager = new CustomerManager();
//customerManager.Add(new SqlServerCustomerDal());

ICustomerDal[] customerDals = new ICustomerDal[] { new SqlServerCustomerDal(), new OracleCustomerDal(),new MySqlCustomerDal()};

foreach (var item in customerDals)
{
    item.Add();
}



personManager.Add(student);



interface IPersone
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}

class Customer : IPersone
{
    public int Id { get ; set ; }
    public string FirstName { get; set ; }
    public string LastName { get ; set ; }

    public string Adress { get; set; }
}


class Student:IPersone
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Departmant { get; set; }


}

class Worker : IPersone
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Departmant { get; set; }


}

class PersonManager
{
    public void Add(IPersone persone)
    {
        
        Console.WriteLine(persone.FirstName);
        
    }
}