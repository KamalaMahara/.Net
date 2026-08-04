using System;
using ExampleNamespace;

class Student
{
  string name;
  int age;
  int rollno;

  public Student(String name, int age, int rollno)
  {
    this.name = name;
    this.age = age;
    this.rollno = rollno;
  }

  public Student(int age, int roll)
  {
    this.age = age;
    this.rollno = roll;
    this.name = "";

  }

  public void Display()
  {
    Console.WriteLine("Name: " + name);
    Console.WriteLine("Age: " + age);
    Console.WriteLine("Roll No: " + rollno);
  }

}