using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSale
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(" Campaign has been add");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(" Campaign has been Delete");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(" Campaign has been Remove");
        }
    }
}
