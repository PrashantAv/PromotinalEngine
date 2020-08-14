using System.IO;
using System;
using System.Collections.Generic;

namespace mynamespace
{
public class Product
{
    public string Id { get; set; }
    public Product(string id)
    {
     Id = id;
    }
}


public class Program
{
   
   public static int GetTotalPrice(List<Product> products)
    {
        int counterOfA = 0;
        int priceOfA = 50;
        int counterOfB = 0;
        int priceOfB = 30;
        int counterOfC = 0;
        int priceOfC = 20;
        int counterOfD = 0;
        int priceOfD = 15;
	    int counterOfCDpair = 0;
	    int priceOfCDpair =30;
	   
    
        foreach (Product pr in products)
        {
            switch (pr.Id)
            {
                case "A":
                case "a":
                    counterOfA += 1;
                    break;
                case "B":
                case "b":
                    counterOfB += 1;
                    break;
                case "C":
                case "c":
                    counterOfC += 1;
                    break;
                case "D":
                case "d":
                    counterOfD += 1;
                    break;
            }
        }
        int totalPriceOfA = (counterOfA / 3) * 130 + (counterOfA % 3 * priceOfA);
        int totalPriceOfB = (counterOfB / 2) * 45 + (counterOfB % 2 * priceOfB);
	    if(counterOfC > 0 && counterOfD > 0)
		{
			while(counterOfC > 0 && counterOfD > 0)
			{
			 counterOfCDpair += 1;
		     counterOfC -= 1;
			 counterOfD -= 1;	
			}
        }
	   
        int totalPriceOfC = (counterOfC * priceOfC);
        int totalPriceOfD = (counterOfD * priceOfD);
	    int toalPriceofCDpair = (counterOfCDpair * priceOfCDpair);
        return totalPriceOfA + totalPriceOfB + totalPriceOfC + totalPriceOfD + toalPriceofCDpair;
    }   
    
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

            Console.WriteLine("Enter total number of products you want in entire order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {   
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type= Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
				Console.WriteLine("You can enter {0} more Products only ",a-i-1);
            }

            int totalPrice = GetTotalPrice(products);
            Console.WriteLine("Final total price:" + totalPrice);
            Console.ReadLine();
    }
}
}