using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GameManager: IGameManager
    {
        int sepet = 0;
        int gameNumber = 0;
        string alinanOyunlar = "";

        public void Add(Gamer gamer, Games games)
        {
            Console.WriteLine("Oyun Eklendi: " + games.GameName);
            sepet = sepet + games.GamePrice;
            Console.WriteLine("Güncel Sepet Tutarı: " + games.GamePrice + " TL");
            alinanOyunlar = alinanOyunlar + games.GameName + " ";
            Console.WriteLine(gamer.FirstName+ " sepetindeki oyunlar "+ alinanOyunlar);
            gameNumber++;
            


        }

        public void Delete(Games games)
        {
            sepet = sepet - games.GamePrice;
            Console.WriteLine("Güncel Sepet Tutarı: " + sepet + " TL"); // "Current Basket Amount:
            gameNumber--;

        }

        public void Update(Gamer gamer, Games games)
        {
            sepet = sepet + games.GamePrice;
             // "Current Basket Amount:
            gameNumber++;
            if (gameNumber == 3) {
                sepet = sepet - (sepet * 25 / 100);
                Console.WriteLine("Kampanya İndirimi Uygulandı. Güncel Sepet Tutarı: " + sepet + " TL");
            }
            else
            {
                Console.WriteLine("Güncel Sepet Tutarı: " + sepet + " TL");
            }
            alinanOyunlar = alinanOyunlar + games.GameName + " ";
            Console.WriteLine(gamer.FirstName + " sepetindeki oyunlar " + alinanOyunlar);


        }
    }
}
