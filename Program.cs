using System;

// Завдання 1: Клас Address
class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

// Завдання 2: Клас Converter
class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / usd;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / eur;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / pln;
    }

    public double ConvertFromUSD(double usd)
    {
        return usd * this.usd;
    }

    public double ConvertFromEUR(double eur)
    {
        return eur * this.eur;
    }

    public double ConvertFromPLN(double pln)
    {
        return pln * this.pln;
    }
}

// Завдання 3: Клас Employee
class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalary(string position, int experience)
    {
        double baseSalary = 0;

        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 50000;
                break;
            case "developer":
                baseSalary = 60000;
                break;
            case "designer":
                baseSalary = 55000;
                break;
            default:
                Console.WriteLine("Invalid position");
                return;
        }

        double tax = baseSalary * 0.15; // Assuming a 15% tax rate
        double salary = baseSalary + (experience * 1000);
        double netSalary = salary - tax;

        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Base Salary: {baseSalary}");
        Console.WriteLine($"Experience: {experience} years");
        Console.WriteLine($"Tax: {tax}");
        Console.WriteLine($"Net Salary: {netSalary}");
    }
}

// Завдання 4: Клас User
class User
{
    public string Login { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public int Age { get; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Login: {Login}");
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Registration Date: {RegistrationDate}");
    }
}

class Program
{
    static void Main()
    {

        // Завдання 1: Клас Address
        Address myAddress = new Address
        {
            Index = "03056",
            Country = "Україна",
            City = "Київ",
            Street = "Вулиця Хрещатик",
            House = "1",
            Apartment = "5"
        };

        Console.WriteLine("Завдання 1: Клас Address");
        Console.WriteLine($"Індекс: {myAddress.Index}");
        Console.WriteLine($"Країна: {myAddress.Country}");
        Console.WriteLine($"Місто: {myAddress.City}");
        Console.WriteLine($"Вулиця: {myAddress.Street}");
        Console.WriteLine($"Будинок: {myAddress.House}");
        Console.WriteLine($"Квартира: {myAddress.Apartment}");
        Console.WriteLine();

        // Завдання 2: Клас Converter
        Converter converter = new Converter(36.75,38.69, 8.4);

        double uahAmount = 1000;

        double usdEquivalent = converter.ConvertToUSD(uahAmount);
        Console.WriteLine($"1000 UAH = {usdEquivalent} USD");

        double eurEquivalent = converter.ConvertToEUR(uahAmount);
        Console.WriteLine($"1000 UAH = {eurEquivalent} EUR");

        double plnEquivalent = converter.ConvertToPLN(uahAmount);
        Console.WriteLine($"1000 UAH = {plnEquivalent} PLN");

        double convertedBackToUAH = converter.ConvertFromUSD(50);
        Console.WriteLine($"50 USD = {convertedBackToUAH} UAH");

        Console.WriteLine();

        // Завдання 3: Клас Employee
        Employee employee = new Employee("Ivan", "Melnyk");
        employee.CalculateSalary("developer", 5);
        Console.WriteLine();

        // Завдання 4: Клас User
        User user = new User("andi", "Andriy", "Ivanichenko", 18);
        user.DisplayUserInfo();
    }
}
