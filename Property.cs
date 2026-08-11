using System;
namespace ExampleNamespace
{
  class Property
  {
    private string name = "";

    public string _Name
    {
      get { return name; }

      set
      {
        if (value.Length > 0)
        {
          name = value;
        }
        else
        {
          Console.WriteLine("Name cannot be empty.");
        }
      }
    }

  }
}