using System;
using ExampleNamespace;
using ConstructorEg;
class Pogram
{
  static void Main(string[] args)
  { //method overloading
    // MethodOverLoading m = new MethodOverLoading();
    // m.Add(20, 40);
    // m.Add(20.5f, 40);

    //constructor overloading

    // Student s1 = new Student("kmla", 20, 1001);
    // s1.Display();

    // Student s2 = new Student(21, 1004);
    // s2.Display();

    //single inheritance

    // Dog d = new Dog();
    // d.Eat();
    // d.Bark();


    //multiLevel inheitance

    // C c = new C();
    // c.DisplayA();
    // c.DisplayB();
    // c.DisplayC();


    //hierarchical inheritance

    // Human h = new Human();
    // h.Speak();

    // Man m = new Man();
    // m.Speak();
    // m.Strong();

    // Woman w = new Woman();
    // w.Speak();
    // w.Beautiful();



    //structure

    // Employee emp;
    // emp.name = "John Doe";
    // emp.age = 30;
    // emp.roll = 101;
    // emp.Display();


    // copy constructor
    // CopyConstructor c1 = new CopyConstructor(20, "km");
    // CopyConstructor c2 = new CopyConstructor(c1);


    //Property

    Property p = new Property();
    p._Name = "kmla";          //set
    Console.WriteLine(p._Name);  //get


  }
}