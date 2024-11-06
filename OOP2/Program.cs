namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new TuzelKisi();
            musteri.Id = 1;
            musteri.CustomerNo = 12345;

            TuzelKisi tuzelKisi = new TuzelKisi();
            tuzelKisi.Id = 2;
            tuzelKisi.CustomerNo = 54321;
            tuzelKisi.VergiNo = "1234567890";
            tuzelKisi.SirketAdi = "Mtkc";

            GercekKisi gercekKisi = new GercekKisi();
            gercekKisi.Id = 3;
            gercekKisi.CustomerNo = 67890;
            gercekKisi.TcNo = "12345678901";
            gercekKisi.Adi = "Sinan";





        }
    }
}
