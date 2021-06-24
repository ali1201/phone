using System;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {

            aphone.START(); 
            aphone a = new aphone("7,2","10000M", " iphone", "red", "   16G");
            a.describe();
            aphone.off();  
            Console.WriteLine("---------------------------------------------");
            aphone.START();
            aphone b = new aphone("5,6","6000m","suamsung","black","2G");
            b.describe();
            aphone.off();




        }
    }
}

