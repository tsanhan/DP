using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    class BillHandler50 : BillHandler
    {
        public override void HandleRequest(int amount)
        {
            if(amount >= 50)
            {
                Console.WriteLine("Giving 50 x" + amount / 50);
            }

            if(amount % 50 > 0)
            {
                if(next != null)
                {
                    next.HandleRequest(amount % 50);
                }
            }

        }
    }
}
