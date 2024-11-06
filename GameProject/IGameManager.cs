using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface IGameManager
    {
        void Add(Gamer gamer, Games games);
        void Update(Games games);
        void Delete( Games games);
    }
}
