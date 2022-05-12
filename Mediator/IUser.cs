namespace DP.Mediator
{
    public interface IUser
    {
        void Send(string message);
        void Receive(string message);
    }
}