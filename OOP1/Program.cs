namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Klavye";
            product1.UnitPrice = 150;
            product1.UnitsInStock = 10;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
