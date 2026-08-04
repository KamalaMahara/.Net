using System;
using ExampleNamespace;

class Animal
{
  public void Eat()
  {
    Console.WriteLine("eatinggg..");
  }
}

class Dog : Animal
{
  public void Bark()
  {
    Console.WriteLine("barkinggg..");
  }
}