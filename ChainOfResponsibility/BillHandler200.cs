using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    class BillHandler200 : BillHandler
    {
        public override void HandleRequest(int amount)
        {
            if(amount >= 200)
            {
                Console.WriteLine("Giving 200 x" + amount / 200);
            }

            if(amount % 200 > 0)
            {
                if(next != null)
                {
                    next.HandleRequest(amount % 200);
                }
            }

        }
    }
}
