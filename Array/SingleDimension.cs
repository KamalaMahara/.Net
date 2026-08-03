using System;

using Haha;


class SingleDimension
{
  internal static void Main(string[] args)
  {
    Console.WriteLine("Enter the size of the array:");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] arr = new int[size];

    Console.WriteLine("Enter the elements of the array:");
    for (int i = 0; i < size; i++)
    {
      arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("The elements of the array are:");
    for (int i = 0; i < size; i++)
    {
      Console.WriteLine($"Element at index {i}: {arr[i]}");
    }
    MaxMin.FindMaxMin();
  }

}
