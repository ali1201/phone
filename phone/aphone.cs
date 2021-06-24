using System;

class Phone
{
  public string display;
  public string butry;
  public string model;
  public string colore;
  public string ram;
  public int number;

  public Phone(string d, string b, string m, string c, string r)
  {
    display = d;
    butry = b;
    model = m;
    colore = c;
    ram = r;
  }

  public void Describe()
  {
    Console.WriteLine($"phone display  is : {display}");
    Console.WriteLine($"phone butry is : {butry}");
    Console.WriteLine($"phone model is : {model}");
    Console.WriteLine($"phone colore  is : {colore}");
    Console.WriteLine($"phone Ram is : {ram}");
  }

  public static void Start()
  {
    Console.WriteLine(" STARTING.........");
  }

  public static void Off()
  {
    Console.WriteLine(" off..........");
  }
}

