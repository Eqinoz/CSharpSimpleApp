namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.productName = "Elma";
            product.productPrice = 12.85;
            product.productDescription = "Yeşil Elma";

            Product product2 = new Product();
            product2.productName = "Muz";
            product2.productPrice = 15.85;
            product2.productDescription = "Yerli Muz";

            Product[] products = new Product[] { product, product2 };

            foreach (Product p in products) {
                Console.WriteLine("Ürün Adı: " + p.productName);
                Console.WriteLine("Ürün Fiyatı: " + p.productPrice);
                Console.WriteLine("Ürün Açıklaması: " + p.productDescription);
                Console.WriteLine("");
            }
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product);
            sepetManager.Add(product2);
        }
    }
}
