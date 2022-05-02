using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public abstract class BillHandler
    {
        protected BillHandler next;

        public void SetNext(BillHandler next)
        {
            this.next = next;
        }

        public abstract void HandleRequest(int amount);
    }
}
