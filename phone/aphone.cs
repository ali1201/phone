using System;

class aphone
{
    public string display;
    public string butry;
    public string model;
    public string colore;
    public string Ram;
    public int number;
    public aphone(string d, string b , string m , string c , string r)
    {
        display = d;
        butry = b;
        model = m;
        colore = c;
        Ram = r;
    }
    public void describe()
    {

        Console.WriteLine($"phone display  is : {display}");
        Console.WriteLine($"phone butry is : {butry}");
        Console.WriteLine($"phone model is : {model}");
        Console.WriteLine($"phone colore  is : {colore}");
        Console.WriteLine($"phone Ram is : {Ram}");
    }
    public static void START()
    {
        Console.WriteLine(" STARTING.........");
    }
    public static void off()
    {
        Console.WriteLine(" off..........");
    }
}

