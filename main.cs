using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter temperature in Celsius");
    var x = Console.ReadLine();
    double x1 = Convert.ToDouble(x);
    var cool = (x1 * 9/5) + 32;
    Console.WriteLine ("Farenheit equivalent for " + (x1) + (" degrees Celsius is ") + (cool));
    if (cool < 32)
    {
      Console.WriteLine ("This temperature is below freezing temperature of 32 degrees farenheit");
    }
    else if (cool > 212)
    {
      
      Console.WriteLine ("This temperature is above boiling temperature  of 212 degrees farenheit");
    }
    else 
    {
      Console.WriteLine ("");
      
    }
    

  }
}