using System;
using Bakery.Models;

namespace Bakery.Program
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Breads: $5 per loaf. Buy 2, get 1 free!");
      Console.WriteLine("Pastries: $2 each or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.");

      Console.Write("How many loaves of bread would you like? ");
      int breadCount = int.Parse(Console.ReadLine());

      Console.WriteLine("How many pastries would you like?");
      int pastryCount = int.Parse(Console.ReadLine());

      Bread bread = new Bread(breadCount);
      Pastry pastry = new Pastry(pastryCount);

      double totalCost = bread.GetCost() + pastry.GetCost();
      Console.WriteLine($"Your total cost is ${totalCost}.");
      







    }

  }

}

