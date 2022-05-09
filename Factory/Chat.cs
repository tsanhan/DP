namespace DP.Factory
{
    class Chat
    {
        public void AddEmoji(Emoji emoji)
        {
            System.Console.WriteLine("the emoji is in position" + emoji.Position.ToString());
            emoji.SayWhatYouWant();
        }    
    }
}