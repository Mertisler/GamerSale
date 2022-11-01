using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSale
{
    internal class UserValiditaionManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "mert" && gamer.LastName == "işler" && gamer.NationalityId == 123456)
            { return true; }
            else
            { return false; }
        }
    }
}
