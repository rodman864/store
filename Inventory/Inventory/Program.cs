using System;
using System.Collections.Generic;

namespace MkinneyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory newProduct = new Inventory();

            Product myProduct = new Product();
            myProduct.ProductId = 1;
            myProduct.ProductName = "Stone Cold";

            newProduct.AddProduct("STO316", myProduct);
            newProduct.AddProduct("STO317", myProduct);
            newProduct.AddProduct("STO318", myProduct);
            newProduct.AddProduct("STO319", myProduct);
            newProduct.AddProduct("STO320", myProduct);
            newProduct.AddProduct("STO321", myProduct);
            newProduct.AddProduct("STO322", myProduct);
            newProduct.AddProduct("STO316", myProduct);


            newProduct.HowManyUsed();
        }
    }
}
public class Inventory
{
    private Dictionary<string, Product> products =
         new Dictionary<string, Product>();

    public void AddProduct(string key,
        Product theProduct)
    {
        bool allSectionsUsed = products.Count == 20;
       bool sectionUsed = products.ContainsKey(key);
        if (sectionUsed)
        {
            Console.WriteLine("Section is in use!");
        }
        else
        {
            products.Add(key, theProduct);

            Console.WriteLine("Product in the inventory!");

        }

    }
    public void HowManyUsed()
    {
        Console.WriteLine("We have: " +
            products.Count + " these many sections are used");
    }
}

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
}