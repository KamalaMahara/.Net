using System;

namespace Haha
{
  class MaxMin
  {
    internal static void FindMaxMin()
    {
      Console.WriteLine("Enter size of array:");
      int size = Convert.ToInt32(Console.ReadLine());
      int[] arr = new int[size];

      Console.WriteLine("Enter elements:");
      for (int i = 0; i < size; i++)
        arr[i] = Convert.ToInt32(Console.ReadLine());

      int max = arr[0], min = arr[0];
      foreach (int val in arr)
      {
        if (val > max) max = val;
        if (val < min) min = val;
      }

      Console.WriteLine($"Max = {max}, Min = {min}");
    }
  }
}
