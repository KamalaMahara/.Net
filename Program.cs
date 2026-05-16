class Program
{
  static void Main(string[] args)
  {
    int num;
    Console.WriteLine("Enter a number:");
    num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 == 0)
    {
      Console.WriteLine("the number is even");
    }
    else
    {
      Console.WriteLine("the number is odd");
    }
  }
}