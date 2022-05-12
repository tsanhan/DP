using System.Collections.Generic;

namespace DP.Mediator
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<IUser> users = new List<IUser>();
        public void RegisterUser(IUser user)
        {
            users.Add(user);
        }
        public void SendMessage(string message, IUser user)
        {
            foreach (IUser u in users)
                if (u != user) u.Receive(message);
        }
    }
}