using Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static string MainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("The options:");
        Console.WriteLine("1 - Public Transport Strategy");
        Console.WriteLine("2 - Walking Strategy");
        Console.WriteLine("3 - Road Strategy");
        Console.Write("\r\nSelect 1, 2 or 3: ");

        switch (Console.ReadLine())
        {
            case "1":
                Navigator.Navigator navigator1 = new Navigator.Navigator(new PublicTransportStrategy());
                return navigator1.MakeRoute("Sofia", "Varna");
                
            case "2":
                Navigator.Navigator navigator2 = new Navigator.Navigator(new WalkingStrategy());
                return navigator2.MakeRoute("Burgas", "Varna");
                
            case "3":
                Navigator.Navigator navigator3 = new Navigator.Navigator(new RoadStrategy());
                return navigator3.MakeRoute("Plovdiv", "Varna");
               
            default:
                Navigator.Navigator navigatorByDefault = new Navigator.Navigator(new PublicTransportStrategy());
                return navigatorByDefault.MakeRoute("Sofia", "Varna");     
        }
        Console.ReadLine();
    }
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine(MainMenu());
        }  
    }
}