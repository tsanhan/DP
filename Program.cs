using System.Text;
using System;
using DP.Factory;

namespace DP
{
    internal class Program
    {
        public static int MyProperty { get; set; }

        

        static void Main(string[] args)
        { 
            #region Singleton

            //var sngltn1 = Singleton.GetInstance();
            //var sngltn2 = Singleton.GetInstance();

            //if(sngltn1 == sngltn2)
            //{
            //    Console.WriteLine("Singleton works!");
            //} else
            //{
            //    Console.WriteLine("Ooops");
            //}
            #endregion

            #region Chain of Responsibility
            // BillHandler bill200 = new BillHandler200();
            // BillHandler bill100 = new BillHandler100();
            // BillHandler bill50 = new BillHandler50();
            // BillHandler bill20 = new BillHandler20();
        
            // StringBuilder sb = new StringBuilder("asdasd");
            // sb.Append("asd").Append("asd");
            
            
            // bill200.SetNext(bill100).SetNext(bill50).SetNext(bill20).SetNext(null);
            // // bill100.SetNext(bill50);
            // // bill50.SetNext(bill20);
            // // bill20.SetNext(null);

            // Console.WriteLine("Withdrow 770:");
            // bill200.HandleRequest(770);

            // Console.WriteLine("Withdrow 100:");
            // bill200.HandleRequest(100);

            // Console.WriteLine("Withdrow 210:");
            // bill200.HandleRequest(210);

            // bill200.SetNext(bill50);
            // Console.WriteLine("Withdrow 770:");
            // bill200.HandleRequest(770);

            #endregion

            #region Factory
                var chat = new Chat();
                var graphics = new Graphics(chat);

                graphics.UserSelectedAngryEmoji("red");
                graphics.UserAddEmojiToChat(1);
            #endregion
        }
    }
}
