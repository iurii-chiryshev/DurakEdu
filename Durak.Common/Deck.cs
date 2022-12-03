using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.Common
{
    
    class Deck
    {
        List<Card> stack;
        public Deck()
        {

        }
        /// <summary>
        /// Перемешать карты
        /// </summary>
        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Взять из колоды одну карту
        /// </summary>
        /// <returns></returns>
        public Card Take()
        {
            //TODO implement me
            return null;
        }

        /// <summary>
        /// Взять из колоды несколько карт
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public List<Card> Take(int count)
        {
            //TODO implement me
            return new List<Card>();
        }
        /// <summary>
        /// Добавить карту в колоду
        /// </summary>
        /// <param name="a"></param>
        public void Add(Card a)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return stack.Count; }
        }
    }
}
