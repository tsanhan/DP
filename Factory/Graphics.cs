namespace DP.Factory
{
    class Graphics
    {
        private EmojiCreator creator;
        private Chat chat;

        public Graphics(Chat chat)
        {
            this.chat = chat;
        }

        public void UserSelectedAngryEmoji(string red_strength)
        {
            creator = new AngryCreator(red_strength);
        }
        public void UserSelectedCoolEmoji(string glasses_color)
        {
            creator = new CoolCreator(glasses_color);
        }
        public void UserSelectedPregnantManEmoji(string race)
        {
            creator = new PregnantManCreator(race);
        }

        public void UserAddEmojiToChat(int position)
        {
            if (creator == null) return;
            Emoji emoji = creator.CreateEmoji(position);
            chat.AddEmoji(emoji);
        }
    }
}