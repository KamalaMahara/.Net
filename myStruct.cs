using System;
namespace ExampleNamespace
{
  struct Employee
  {
    public string name;
    public int age;
    public int roll;

    public Employee(string name, int age, int roll)
    {
      this.name = name;
      this.age = age;
      this.roll = roll;
    }

    public void Display()
    {
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Age: " + age);
      Console.WriteLine("Roll: " + roll);
    }
  }
}