namespace DP.Factory
{
    class CoolCreator : EmojiCreator
    {
        private string glass_color;
    
        public CoolCreator(string glass_color)
        {
            this.glass_color = glass_color;
        }

        public override Emoji CreateEmoji(int position)
        {
            return new Cool(position, this.glass_color);
        }
    }



    class AngryCreator : EmojiCreator
    {
        private string red_strength;
    
        public AngryCreator(string red_strength)
        {
            this.red_strength = red_strength;
        }

        public override Emoji CreateEmoji(int position)
        {
            return new Angry(position, this.red_strength);
        }
    }

    class PregnantManCreator : EmojiCreator
    {
        private string race;
    
        public PregnantManCreator(string race)
        {
            this.race = race;
        }

        public override Emoji CreateEmoji(int position)
        {
            return new PregnantMan(position, this.race);
        }
    }
}