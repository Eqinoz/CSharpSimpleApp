namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double applePrice, bananaPrice, orangePrice, stawberryPrice;
            applePrice = 0.99;
            bananaPrice = 1.29;
            orangePrice = 1.49;
            stawberryPrice = 2.99;

            Console.WriteLine("---***Fiyat Listesi***---");
            Console.WriteLine("Elma Fiyatı: "+ applePrice);
            Console.WriteLine("Muz Fiyatı: " + bananaPrice);
            Console.WriteLine("Portakal Fiyatı: " + orangePrice);
            Console.WriteLine("Çilek Fiyatı: " + stawberryPrice);

            Console.WriteLine("");
            Console.WriteLine("");

            double appleAmount, bananaAmount, orangeAmount, stawberryAmount;

            Console.Write("Alınan Elma Miktarını Giriniz: ");
            appleAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Alınan Muz Miktarını Giriniz: ");
            bananaAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Alınan Portakal Miktarını Giriniz: ");
            orangeAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Alınan Çilek Miktarını Giriniz: ");
            stawberryAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("");

            double totalApplePrice, totalBananaPrice, totalOrangePrice, totalStawberryPrice, totalPrice;
            totalApplePrice = applePrice * appleAmount;
            totalBananaPrice = bananaPrice * bananaAmount;
            totalOrangePrice = orangePrice * orangeAmount;
            totalStawberryPrice = stawberryPrice * stawberryAmount;


            Console.WriteLine("---***Fiş***---");
            Console.WriteLine("Elma Fiyatı: " + totalApplePrice);
            Console.WriteLine("Muz Fiyatı: " + totalBananaPrice);
            Console.WriteLine("Portakal Fiyatı: " + totalOrangePrice);
            Console.WriteLine("Çilek Fiyatı: " + totalStawberryPrice);
            Console.WriteLine("Toplam Fiyat: " + (totalApplePrice + totalBananaPrice + totalOrangePrice + totalStawberryPrice));
        }
    }
}
