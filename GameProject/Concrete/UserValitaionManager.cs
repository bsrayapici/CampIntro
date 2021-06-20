using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class UserValitaionManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Büşra" && gamer.LastName == "Yapıcı" && gamer.BirthYear == 1995)
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
