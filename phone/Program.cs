using System;

namespace phone
{
  class Program
  {
    static void Main(string[] args)
    {
      Phone.Start();
      Phone iphone = new Phone("7,2", "10000M", " iphone", "red", "   16G");
      iphone.Describe();
      Phone.Off();

      Console.WriteLine("---------------------------------------------");

      Phone.Start();
      Phone samsung = new Phone("5,6", "6000m", "suamsung", "black", "2G");
      samsung.Describe();
      Phone.Off();
    }
  }
}

