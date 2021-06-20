using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);



        }
    }

        






        //int, double, bool... değer tip
        // diziler classlar, interfaceler, .... referans tip
        //değer tiplerde atamalar değer üzerinde olur tüm bağlar kopar.
        // ref out

    

}
    
