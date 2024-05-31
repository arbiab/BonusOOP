using System;
using System.Xml.Linq;
class ArrayMin

class Program
{
    static void Main(String[] args)
    {
        Zhvillues zhvillues = new Zhvillues(1, "Agim Krasniqi", "Zhvillues", 55500);
        Menaxher menaxher = new Menaxher(2, "Ahmet Shala", "Menaxher", 700000);
        Admin admin = new Admin(3, "Blerim Gashi", "Admin", 80000);
        ShfaqTeDhenat(zhvillues);
        Thread.Sleep(1000);
        ShfaqTeDhenat(menaxher);
        Thread.Sleep(1000);
        ShfaqTeDhenat(admin);
    }
    static void ShfaqTeDhenat (Employee employee)
    {
        Console.WriteLine($"Detajet E Puntorit:");
        Console.WriteLine($"ID: {employee.Id}");
        Console.WriteLine($"Emri: {employee.Emri}");
        Console.WriteLine($"Pozita: {employee.Pozita}");
        Console.WriteLine($"Rroga: {employee.Rroga}");
        Console.WriteLine($"Bonusi: {employee.CalculateBonus()}");
        Console.WriteLine($"Totali: {employee.CalculateBonus() + employee.Rroga}");
        Console.WriteLine();
    }
}
  

class Employee
{
    public int Id;
    public string Emri;
    public string Pozita;
    public int Rroga;
    public Employee(int id, string emri, string pozita, int rroga)
    {
        Id = id;
        Emri = emri;
        Pozita = pozita;
        Rroga = rroga;
    }
    public virtual double CalculateBonus() 
    {
        return 0;
    }
}
class Zhvillues : Employee
{
    public Zhvillues(int id,string emri , string pozita,int rroga) : base(id,emri,pozita,rroga)
    {
        
    }

    public override double CalculateBonus() {
        double bonus = Math.Max(50000, 0.20 * Rroga);
        return bonus;
    }
  
}
class Menaxher : Employee
{
    public Menaxher(int id, string emri, string pozita, int rroga) : base(id, emri, pozita, rroga)
    {

    }

    public override double CalculateBonus()
    {
        double bonus = Math.Max(50000, 0.25 * Rroga);
        return bonus;
    }
}
class Admin : Employee
{
    public Admin(int id, string emri, string pozita, int rroga) : base(id, emri, pozita, rroga)
    {

    }

    public override double CalculateBonus()
    {
        return 50000;
    }
}
