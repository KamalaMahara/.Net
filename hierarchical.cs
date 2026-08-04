using System;
using ExampleNamespace;

class Human
{
  public void Speak()
  {
    Console.WriteLine("Speakinggg..");
  }
}

class Man : Human
{
  public void Strong()
  {
    Console.WriteLine(" man are built in strong ...");
  }
}

class Woman : Human
{
  public void Beautiful()
  {
    Console.WriteLine(" woman are built in beautiful ...");
  }
}