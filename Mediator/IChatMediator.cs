using DP.Mediator;
namespace DP.Mediator
{
    public interface IChatMediator
    {
        void SendMessage(string message, IUser user);
        void RegisterUser(IUser user);
    }
}