using System;

class Program
{
    static void Main(string[] args)
    {
      Address house1= new Address("1341 platinum bulivard","viena","WA","USA");
      Customer patron1= new Customer("Ethan",house1);
      Product item1= new Product("Shoes","iF22C",3.5,2);
      Product item2= new Product("Cat","M30w11",20,4);
      Order purchase1=new Order(patron1);
      purchase1.AddItem(item1);
      purchase1.AddItem(item2);
      Console.WriteLine($"Packing Label:\n{purchase1.PackingLabel()}");
      Console.WriteLine($"Shiping Label:\n{purchase1.ShipingLabel()}");
      Console.Write("Total Cost:$ ");
      Console.WriteLine(purchase1.TotalPrice());

      Address house2= new Address("1221 Royal Vista AVE","Ceder","BC","Canada");
      Customer patron2= new Customer("Zachary ",house2);
      Product itemA1= new Product("Ketchup Chipps","1LL09",4.5,5);
      Product itemA2= new Product("Donuts","D01n7s",1.5,12);
      Order purchase2=new Order(patron2);
      purchase2.AddItem(itemA1);
      purchase2.AddItem(itemA2);
      Console.WriteLine();
      Console.WriteLine($"Packing Label: \n{purchase2.PackingLabel()}");
      Console.WriteLine( $"Shiping Label:\n{purchase2.ShipingLabel()}");
      Console.Write("Total Cost:$ ");
      Console.WriteLine(purchase2.TotalPrice());

      
    }
}