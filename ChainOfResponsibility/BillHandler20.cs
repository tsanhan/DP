using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    class BillHandler20 : BillHandler
    {
        public override void HandleRequest(int amount)
        {
            if(amount >= 20)
            {
                Console.WriteLine("Giving 20 x" + amount / 20);
            }

            if(amount % 20 > 0)
            {
                if(next != null)
                {
                    next.HandleRequest(amount % 20);
                }
            }

        }
    }
}
