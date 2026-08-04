using System;
namespace ExampleNamespace
{
  class ExampleProgram
  {


    internal static void Sum(int a, int b)
    {
      int c;
      Console.WriteLine("enter two numbers");
      c = a + b;
      Console.WriteLine("the sum is " + c);
    }
    internal void Sub(int a, int b)
    {
      int c;
      Console.WriteLine("enter two numbers");
      c = a - b;
      Console.WriteLine("the difference is " + c);
    }

  }

}