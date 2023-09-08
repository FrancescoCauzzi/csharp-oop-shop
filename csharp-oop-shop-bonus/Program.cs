namespace csharp_oop_shop_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product hairdryer = new Product("Hairdryer", "An appliance used mainly to dry hair", 45M, 0.22M);
            Console.WriteLine($"The product name is: {hairdryer.Name}");
            Console.WriteLine($"Description: {hairdryer.Description}");
            Console.WriteLine($"The product code is: {Product.PadProductCode(hairdryer.ProductCode)}");
            Console.WriteLine($"The product net price is: {hairdryer.Price}");
            Console.WriteLine($"The product gross price is: {hairdryer.GetGrossPrice()}");
            Console.WriteLine($"The extended name of the product is: {hairdryer.GetFullName()}");

            // Bonus 2
            Product refrigerator = new Product("Refrigerator", "A kitchen appliance for cooling and preserving food", 799.99M, 0.22M);
            Product washingMachine = new Product("Washing Machine", "An appliance for cleaning clothes automatically", 499.99M, 0.22M);
            Product microwaveOven = new Product("Microwave Oven", "A kitchen appliance for heating food quickly", 149.99M, 0.22M);
            Product coffeeMaker = new Product("Coffee Maker", "An appliance for brewing coffee", 59.99M, 0.22M);

            Product[] shopProducts = { hairdryer, refrigerator, washingMachine, microwaveOven, coffeeMaker };

            Console.WriteLine();

            Console.WriteLine("The list of products in our shop is:");
            int index = 1;
            foreach (Product shopProduct in shopProducts)
            {
                Console.WriteLine($"{index}. {shopProduct.Name} with code: {Product.PadProductCode(shopProduct.ProductCode)}");
                index++;
            }






        }
    }
}