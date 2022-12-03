using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.Common
{
    class Game
    {
        List<Player> players; // игроки
        Deck deck; //колода
        List<Pair> bit;  // список отыграных пар
        Suit trump; // козырь
        Player attackPlayer; // атакующий игрок
        Player defendPlayer; // обороняющийся игрок

        public Game(List<Player> players)
        {
            this.players = players;
        }

        public void Play()
        {
            // создать кололоду, перемешать
            // раздать по 6 карт игрокам, определить козырь
            // определить начинающего игрока (минимальная карта с такой же мастью как козырь)
            while(true) // глобальный цикл, пока не определится победитель
            {
                while(true)
                {
                    // атакующий игрок кидает карту  или подкидывает
                    // обороняющийся игрок отвечает
                }

                // раздать карты 
                // выбрать следующую пару атакующий / обороняющийся

                // проверить - а может есть победитель

            }
        }
    }
}
