﻿IPersonManager customerManager=new CustomerManager();

customerManager.Add();

IPersonManager employeeManager =new EmployeeManager();
employeeManager.Add();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(new InternManager());

interface IPersonManager
{
    void Add();
    void Update();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Güncellendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Personel Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Personel Güncellendi");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer Güncellendi");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}