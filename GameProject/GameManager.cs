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
        public void Add(Gamer gamer, Games games)
        {
            Console.WriteLine("Oyun Eklendi: " + games.GameName);
            sepet = sepet + games.GamePrice;
            Console.WriteLine("Güncel Sepet Tutarı: " + games.GamePrice + " TL");
            
        }

        public void Delete(Games games)
        {
            sepet = sepet - games.GamePrice;
            Console.WriteLine("Güncel Sepet Tutarı: " + sepet + " TL"); // "Current Basket Amount:

        }

        public void Update(Games games)
        {
            sepet = sepet + games.GamePrice;
            Console.WriteLine("Güncel Sepet Tutarı: " + sepet + " TL"); // "Current Basket Amount:

        }
    }
}
