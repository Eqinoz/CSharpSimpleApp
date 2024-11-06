using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface IGamerManager
    {
        void Add(Gamer gamer);
        void Update();
        void Delete();
    }
}
