using System;
using ExampleNamespace;

class A
{
  public void DisplayA()
  {
    Console.WriteLine("Class A");
  }

}

class B : A
{
  public void DisplayB()
  {
    Console.WriteLine("Class B");
  }
}


class C : B
{
  public void DisplayC()
  {
    Console.WriteLine("Class C");
  }
}