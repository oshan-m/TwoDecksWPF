using System;
namespace TwoDecksWPF
{
    public class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name {
            get { return   $"{Value} of {Suit}"; }
        }

        public Card(Values value,Suits Suit)
        {
            
            this.Suit = Suit;
            this.Value = value;

        }


        public override string ToString()
        {
            return Name;
        }

    }
}
