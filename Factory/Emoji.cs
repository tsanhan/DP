namespace DP.Factory
{
    


    abstract class Emoji
    {
        public int Position { get; set; }
        public string Say { get; set; }
        public Emoji(int position, string say)
        {
            this.Position = position;
            this.Say = say;
        }

        public void SayWhatYouWant(){
            System.Console.WriteLine("I Say: " + this.Say);
        }  
    }
}