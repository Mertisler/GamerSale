﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSale
{
    internal interface IGameSaleService
    {
        void Sale(Game game,Gamer gamer);
        void MakeDiscount(Game game, Gamer gamer,Campaign campaign);
    }
}
