using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    class BillHandler100 : BillHandler
    {
        public override void HandleRequest(int amount)
        {
            if(amount >= 100)
            {
                Console.WriteLine("Giving 100 x" + amount / 100);
            }

            if(amount % 100 > 0)
            {
                if(next != null)
                {
                    next.HandleRequest(amount % 100);
                }
            }

        }
    }
}
