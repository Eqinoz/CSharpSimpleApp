using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamerManager
    {
        IUserValidation _userValidation;
        public GamerManager(UserValidation userValidation)
        {
            _userValidation = userValidation;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Başarılı");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }
        }

        public void Delete()
        {
           
        }

        public void Update()
        {
            
        }
    }
}
