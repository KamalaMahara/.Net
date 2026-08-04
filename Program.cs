using System;
using ExampleNamespace;
class Pogram
{
  static void Main(string[] args)
  {
    MethodOverLoading m = new MethodOverLoading();
    m.Add(20, 40);
    m.Add(20.5f, 40);

  }
}