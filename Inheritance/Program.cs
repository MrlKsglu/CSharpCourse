

Student[] students= new Student[2];
students[0]= new Student();

students[0].FirstName = "Meral";






Person[] people = new Person[] { students[0] };

foreach (var item in people)
{
    Console.WriteLine(item.FirstName);
}




class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}
class Student : Person
{
    public string Department { get; set; }
}
class Customer:Person
{
    public string City { get; set; }
}

