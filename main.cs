using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the amount of cars");
    double amt = Convert.ToDouble(Console.ReadLine());
    
    int counter = 0;
    
    
     while (counter < amt)
    {
      int numcars = counter + 1;
      Console.WriteLine("Enter the distance covered by car" + "#" + numcars);
      double distance = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter the time taken by car" + "#" + numcars);
      double time = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The speed of car #" + numcars + " is " + distance/time + " miles per hour ");
    
    counter++;
    
    
    }
    
  }
}