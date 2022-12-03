using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.Common
{
    class Player
    {
        string name;
        List<Card> hand;
        public Player(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Взять из колоды
        /// </summary>
        /// <param name="count"></param>
        /// <param name="deck"></param>
        void Take(int count, Deck deck)
        {
            for (int i = 0; i < count; i++)
            {
                if (deck.Count != 0)
                    hand.Add(deck.Take());
            }
        }

        void Take(List<Pair> pairs)
        {
            foreach(var pair in pairs)
            {
                hand.Add(pair.First);
                hand.Add(pair.Second);
            }
        }

        /// <summary>
        /// Сходить картой
        /// </summary>
        /// <returns></returns>
        public Card Throw()
        {
            return null;
        }

        /// <summary>
        /// Подкинуть
        /// </summary>
        /// <param name="pairs">сыгранные пары карт</param>
        /// <returns></returns>
        Card Thrown(List<Pair> pairs)
        {
            return null;
        }

        /// <summary>
        /// Отбиться т.е. выкинуть карту в ответ
        /// </summary>
        /// <param name="card"></param>
        /// <param name="trump"></param>
        /// <returns></returns>
        public virtual Card BeatOff(Card card, Suit trump)
        {
            return null;
        }

    }
}
