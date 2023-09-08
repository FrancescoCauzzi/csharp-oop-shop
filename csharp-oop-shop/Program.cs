namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Hairdryer", "An appliance used mainly to dry hair", 25M, 0.22M);
            Console.WriteLine($"The product name is {product.Name}");
            Console.WriteLine($"Description: {product.Description}");
            Console.WriteLine($"The product code is {product.ProductCode}");
            Console.WriteLine($"The product net price is: {product.Price}");
            Console.WriteLine($"The product gross price is: {product.GetGrossPrice()}");
            Console.WriteLine($"The extended name of the product is {product.GetFullName()}");




        }







    }
}