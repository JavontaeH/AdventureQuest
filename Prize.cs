using System;

namespace Quest
{
    public class Prize
    {
        private string _text { get; set; }

        public Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer adv)
        {
            if (adv.Awesomeness > 0)
            {
                for (int i = 0; i < adv.Awesomeness; i++)
                {
                    Console.WriteLine($"{_text}");
                }
            }
            else if (adv.Awesomeness <= 0)
            {
                Console.WriteLine($"pity");
            }
        }
    }
}
