using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.Common
{
    /// <summary>
    /// Масть
    /// </summary>
    public enum Suit
    {
        Diamonds,   //Бубы
        Hearts,     //Черви
        Clubs,      //Крести
        Spades,     //Пики
    }

    /// <summary>
    /// Значение карты
    /// </summary>
    public enum Rank
    {
        Six = 6,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    public class Card
    {
        Suit suit;
        Rank rank;
        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
        public Suit Suit
        {
            get { return suit; }
        }
        public Rank Rank
        {
            get { return rank; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="card"></param>
        /// <param name="trump"></param>
        /// <returns> 0 если this бьет card, иначе 1</returns>
        int Fight(Card card, Suit trump)
        {
            if (suit == card.suit)
                return ((rank > card.rank) ? 0 : 1);
            else if ((suit == trump) && (card.suit != trump))
                return 0;
            else
                return 1;
        }
    }
}
