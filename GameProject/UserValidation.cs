using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidation : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.TcNo=="51208818508" && gamer.FirstName == "Sinan" && gamer.LastName=="Özuncu" && gamer.BirthYear=="2003")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
