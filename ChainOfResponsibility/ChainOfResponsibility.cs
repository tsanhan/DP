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

        public BillHandler SetNext(BillHandler next)
        {
            this.next = next;
            return this.next;
        }

        public abstract void HandleRequest(int amount);
    }
}
