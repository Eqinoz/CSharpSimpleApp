namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IKrediManager konutKredisi = new KonutKredisi();
            IKrediManager esnafKredisi = new EsnafKredisi();

            new BasvuruManager().BasvuruYap(esnafKredisi);
        }
    }
}
