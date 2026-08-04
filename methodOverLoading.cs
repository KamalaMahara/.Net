using System;
using ExampleNamespace;

public class MethodOverLoading
{
  public void Add(int a, int b)
  {
    Console.WriteLine("the sum of 2 num is " + (a + b));
  }

  public void Add(float a, int b)
  {
    Console.WriteLine("the sum of two no :" + (a + b));
  }
}