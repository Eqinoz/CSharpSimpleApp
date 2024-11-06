using System.Collections.Generic;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim;
            Gamer gamer = new Gamer();
            Console.WriteLine("------Oyuncu Kayıt------");
            Console.Write("İsminiz:");
            gamer.FirstName = Console.ReadLine();
            Console.Write("Soyisminiz:");
            gamer.LastName = Console.ReadLine();
            Console.Write("Doğum Yılınız:");
            gamer.BirthYear = Console.ReadLine();
            Console.Write("Tc Kimlik Numaranız:");
            gamer.TcNo = Console.ReadLine();
            GamerManager gamerManager = new GamerManager(new UserValidation());
            gamerManager.Add(gamer);
            Console.WriteLine("------Oyuncu Kayıt------");
            Console.WriteLine(" ");

            List<Games> games = new List<Games>
            {
                new Games {Id = 1, GameName = "GTA V", GameType = "Aksiyon", GamePrice = 100},
                new Games {Id = 2, GameName = "FIFA 21", GameType = "Spor", GamePrice = 200},
                new Games {Id = 3, GameName = "PES 21", GameType = "Spor", GamePrice = 150},
                new Games {Id = 4, GameName = "CS GO", GameType = "FPS", GamePrice = 50},
                new Games {Id = 5, GameName = "PUBG", GameType = "FPS", GamePrice = 75}
            };

            Console.WriteLine("-----Satın Almak İstediğiniz Oyunu Seçiniz------");
            Console.WriteLine("****Kampanya 3 Oyun Alımında %25 İndirim****");
            foreach (var game in games)
            {
                Console.WriteLine(game.Id+" " +"Oyun Adı: " + game.GameName + " Oyun Türü: " + game.GameType + " Oyun Fiyatı: " + game.GamePrice);
            }
            Console.Write("Seçiminiz:");
            secim = Convert.ToInt32(Console.ReadLine());
            
            GameManager gameManager = new GameManager();
            foreach (var game in games)
            {
                if (secim == game.Id)
                {
                    gameManager.Add(gamer, game);
                }
            }
            Console.WriteLine("Alışverişe Devam Etmek İster Misiniz? (E/H)");
            string devam = Console.ReadLine();
            do
            {
                Console.WriteLine("-----Satın Almak İstediğiniz Oyunu Seçiniz------");
                foreach (var game in games)
                {
                    Console.WriteLine(game.Id + " " + "Oyun Adı: " + game.GameName + " Oyun Türü: " + game.GameType + " Oyun Fiyatı: " + game.GamePrice);
                }
                Console.Write("Seçiminiz:");
                secim = Convert.ToInt32(Console.ReadLine());


                foreach (var game in games)
                {
                    if (secim == game.Id)
                    {
                        gameManager.Update(gamer, game);
                    }
                }
                Console.WriteLine("Alışverişe Devam Etmek İster Misiniz? (E/H)");
                 devam = Console.ReadLine();

            } while (devam == "E" || devam=="e");
            Console.WriteLine("Alışverişiniz Tamamlanmıştır. İyi Oyunlar.");
            Console.ReadKey();



        }
    }
}
