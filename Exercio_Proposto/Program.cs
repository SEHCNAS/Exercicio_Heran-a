using System;
using System.Collections.Generic;
using Exercio_Proposto.Entidades;
using System.Globalization;

namespace Exercio_Proposto {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> ListProducts = new List<Product>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Product #{0} data: ",i);

                Console.Write("Common, Used or Imported (C/U/I)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'c' || ch == 'C') {

                    ListProducts.Add(new Product(name, price));

                }
                else if (ch == 'u' || ch == 'U') {
                    Console.Write("Manufacture date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    ListProducts.Add(new UsedProduct(name,price,date));

                } 
                else if (ch == 'i' || ch == 'I') {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ListProducts.Add(new ImportedProduct(name, price, customFee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product emp in ListProducts) {
                Console.WriteLine(emp.PriceTag());

            }
        }
    }
}
