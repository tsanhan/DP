using System;

namespace DP.Mediator
{
    public class User : IUser
    {
        private readonly IChatMediator mediator;
        private string name;

        public User(IChatMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{name} received: {message}");
        }

        public void Send(string message)
        {
            Console.WriteLine($"{name} sending: {message}");
            mediator.SendMessage(message, this);
        }
    }
}