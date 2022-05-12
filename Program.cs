using System.Text;
using System;
using DP.Factory;
using DP.Mediator;
using DP.Proxy;

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
            // var chat = new Chat();
            // var graphics = new Graphics(chat);

            // graphics.UserSelectedAngryEmoji("red");
            // graphics.UserAddEmojiToChat(1);
            #endregion

            #region Mediator
            // IChatMediator mediator = new ChatMediator();
            // var vic = new User(mediator, "Victor");
            // var yos = new User(mediator, "Yosef");
            // var alec = new User(mediator, "Alex");
            // var mih = new User(mediator, "Micheal");
            // var yeh = new User(mediator, "Yehonatam");

            // mediator.RegisterUser(vic);
            // mediator.RegisterUser(yos);
            // mediator.RegisterUser(alec);
            // mediator.RegisterUser(mih);
            // mediator.RegisterUser(yeh);

            // vic.Send("Hello, I'm Vic");

            // yos.Send("Hello, I'm Yosef");

            #endregion

            #region Proxy
            var myCar = new Car();
            myCar.OpenDoor();
            myCar.Drive();
            myCar.Stop();

            var carRepair = new MechanicCarProxy(myCar);
            Rescue(carRepair);

            #endregion
        }
        static void Rescue(IRescue carProxy)
        {
            var carGps = carProxy.GetLocation();
            var gas = carProxy.GetGasReport();
            carProxy.StartRepair();
            carProxy.EndRepair();


        }
    }
}
