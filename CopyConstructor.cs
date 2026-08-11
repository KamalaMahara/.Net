using System;
namespace ConstructorEg;

class CopyConstructor
{
  int age;
  string name;


  public CopyConstructor(int age, string name)
  {
    this.age = age;
    this.name = name;
  }

  public CopyConstructor(CopyConstructor c)
  {
    this.age = c.age;
    this.name = c.name;
  }

}