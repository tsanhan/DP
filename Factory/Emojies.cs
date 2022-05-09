namespace DP.Factory
{
    class Cool : Emoji
    {
        private string glass_color { get; set; }
        
        
        public Cool(int position, string glass_color) : base(position, "Cool")
        {
            this.glass_color = glass_color;
        }
    }

    class Angry : Emoji
    {
        private string red_strength { get; set; }
        
        public Angry(int position, string red_strength) : base(position, "Angry")
        {
            this.red_strength = red_strength;
        }
    }

    class PregnantMan : Emoji
    {
        private string race { get; set; }

        public PregnantMan(int position, string race) : base(position, "Pregnant Man")
        {
            this.race = race;
        }
    }
}